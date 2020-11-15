/*////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///// This Program is intended to be used with a  Tiva TM4C123GH6PM. The Firmware supplied below is meant to create a thermostat out of the processor.	  ////
///// This relies on the main loop of the program being infinite where  LED1 will show solid: red for heating and activating the heat source,		  //// 
///// blue for cooling activating the cooling source, and yellow for stand by when the temperature is in an acceptable region (+/- 2 degrees of set temp) ////
///// The reading of the temperature relis on the Timer1A to time out every 10 second (adjustable) during the timeout period LED1 will toggle green when ///// 
///// the ADC is read for the current temperature values and GPIOF Handler for the setting of the desired temperature.					 /////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////AUTHORS: Daniel Gray and Ryan Coffin												   Date:6/2018  //////
/////PURPOSE: Final Project for Microprocessor Digital Design												//////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

#include "TM4C123GH6PM.h"

/*Definitions*/
#define LCD_DATA GPIOB 
#define LCD_CTRL GPIOA  
#define RS 0x20         /* PORTA BIT5 mask */
#define RW 0x40         /* PORTA BIT6 mask */
#define EN 0x80         /* PORTA BIT7 mask */

/*Function Prototypes*/
void delayUs(int n);
void LCD_command(unsigned char command);
void LCD_data(unsigned char data);
void LCD_init(void);
void timer1A_init(void);
void delayMs(int n);

/*Variables*/ 
int result;
int setpoint=70;        /*initial desired temperature*/
int r;                  /*holds the 10s value of room tempurature after ascii conversion*/
int m;                  /*holds the 1s value of room tempurature after ascii conversion*/
int s;                  /*holds the 10s value of desired temperature after ascii conversion*/
int p;                  /*holds the 1s value of the desired temperature after ascii conversion*/
int t;                  /*holds the 10s value of the desired temperature before asccis conversion*/
int t2;                 /*holds the 10s value of room tempurature before ascii conversion*/
double temp;            /*room temperature stored as F*/



/*Main Program*/
int main (void)
{
	LCD_init();'
    
/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////	
							INITIALIAZATIONS 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// */
/* enable clock to GPIOF at clock gating control register */
    SYSCTL->RCGCGPIO |= 0x20;
    SYSCTL->RCGCGPIO |= 0x10;
    SYSCTL->RCGCADC |= 1;   
    
/* initialize PE3 for AIN0 input  */
	GPIOE->AFSEL |= 8;   	/* enable alternate function */
	GPIOE->DEN &= ~8;    	/* disable digital function */
	GPIOE->AMSEL |= 8;   	/* enable analog function */
   
/* enable the GPIO pins for the LED (PF3, 2 1) as output */
    GPIOF->DIR = 0x0e;
/* enable the GPIO pins for digital function */
    GPIOF->DEN = 0x0e;
	
/* initialize ADC0 */
	ADC1->ACTSS &= ~8;    	/* disable SS3 during configuration */
	ADC1->EMUX &= ~0xF000;	/* software trigger conversion */
	ADC1->SSMUX3 = 1;     	/* get input from channel 1 */
	ADC1->SSCTL3 |= 6;    	/* take one sample at a time, set flag at 1st sample */
	ADC1->ACTSS |= 8;     	/* enable ADC0 sequencer 3 */
	
   
////////////////////////////////////////////////////////////////
/* PORTF0 has special function, need to unlock to modify */
		
	
    GPIOF->LOCK = 0x4C4F434B;   /* unlock commit register */
    GPIOF->CR = 0x01;          /*make PORTF0 configurable */
    GPIOF->LOCK = 0;            /* lock commit register */

    /* configure PORTF for switch input and LED output */
    GPIOF->DIR &= ~0x11;        /* make PORTF4 input for switch */
    GPIOF->DEN |= 0x1F;         /* make PORTF4-0 digital pins */
    GPIOF->PUR |= 0x11;         /* enable pull up for PORTF4, 0 */
    
    /* configure PORTF4, 0 for falling edge trigger interrupt */
    GPIOF->IS  &= ~0x11;        /* make bit 4, 0 edge sensitive */
    GPIOF->IBE &= ~0x11;        /* trigger is controlled by IEV */
    GPIOF->IEV &= ~0x11;        /* falling edge trigger */
    GPIOF->ICR |= 0x11;         /* clear any prior interrupt */
    GPIOF->IM  |= 0x11;         /* unmask interrupt */
    
    /* enable interrupt in NVIC and set priority to 3 */
    NVIC->IP[30] = 3 << 5;     /* set interrupt priority to 3 */
    NVIC->ISER[0] |= 0x40000000;    /* enable IRQ30 (D30 of ISER[0]) */
//////////////////////////////////////////////////////////////
    timer1A_init(); /* setup timer1A interrupt */
    

    __enable_irq(); /* global enable IRQs */


/*////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			Initial Read: 10 seconds window while the system intializes and reads the room temperature
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
GPIOF->DATA =0x0A;                  /* turn on Yellow LED */
/* converts Setpoint which holds the initial desire room temperature in to two individual integers  and asigns their asci value for the LCD display*/
t=(setpoint/10);
s=t+48;
p=setpoint-(t*10)+48;

/* Prints initial desired temperature to LCD display*/    
    	LCD_command(1);                 /* clear display */
    	LCD_command(0x80);              /* lcd cursor location first line*/  
    	LCD_data('S');
	LCD_data('e');
	LCD_data('t');
	LCD_data(' ');
	LCD_data('T');
	LCD_data('e');
	LCD_data('m');
	LCD_data('p');
	LCD_data(':');
	LCD_data(' ');
    	LCD_data(s );
	LCD_data(p);
	LCD_data(' ');
	LCD_data('F');
	LCD_command(0xC0);              /* lcd cursor location  second line*/
	LCD_data('R');
	LCD_data('e');	
	LCD_data('a');
	LCD_data('d');
	LCD_data('i');
	LCD_data('n');
	LCD_data('g');
	LCD_data(' ');
	LCD_data('R');
	LCD_data('o');
	LCD_data('o');
    	LCD_data('m');
    	delayMs(10000);
   	 GPIOF->DATA = 0;                /* turn off LED */ 
                
                
/*////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
								MAIN LOOP OF PROGRAM
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    
while(1)
{
/*Checks for updates to the desired temperature*/
    delayMs(200);
    GPIOF->DATA = 0;            /* turn off all LED */
	t=(setpoint/10);
	s=t+48;
	p=setpoint-(t*10)+48;		
	
/*Checks for updates to room temperature*/		
	temp=((result*100)/4096)*1.8+32;
	t2=(temp/10);
	r=t2+48;
	m=temp-(t2*10)+48;

/*Updates the LCD display*/
    LCD_command(1);                 /* clear display */
    		LCD_command(0x80);              /* lcd cursor location first line*/
    	LCD_data('S');
    	LCD_data('e');
	LCD_data('t');
	LCD_data(' ');
	LCD_data('T');
	LCD_data('e');
	LCD_data('m');
	LCD_data('p');
	LCD_data(':');
	LCD_data(' ');
	LCD_data(s );
	LCD_data(p);
	LCD_data(' ');
	LCD_data('F');
	LCD_command(0xC0);              /* lcd cursor location  second line*/
	LCD_data('R');
	LCD_data('o');
	LCD_data('o');
	LCD_data('m');
	LCD_data(' ');
	LCD_data('T');
	LCD_data('e');
	LCD_data('m');
	LCD_data('p');
	LCD_data(':');
	LCD_data(' ');
	LCD_data(r);
	LCD_data(m);	
	LCD_data(' ');
    	LCD_data('F');

	if(setpoint > temp -2)
	{
		GPIOF->DATA = 0x02;	        /* turn on Red LED and send signal for heat */
	}
	else if(setpoint < temp +2)
	{
		GPIOF->DATA = 0x04;	        /* turn on Blue LED and send signal for AC*/
	}
	else
	{
		GPIOF->DATA = 0x0A;	        /* turn on Yellow LED and system standby*/
	}
	 }
}
////////////////////////////////////////////////Functions and Handlers//////////////////////////////////////////////////////////////////
/* Setup Timer1A to create 1 Hz interrupt */
void timer1A_init(void)
{
    SYSCTL->RCGCTIMER |= 2;             /* enable clock to Timer Block 1 */
    TIMER1->CTL = 0;                    /* disable Timer1 before initialization */
    TIMER1->CFG = 0x00;                 /* 32-bit option */
    TIMER1->TAMR = 0x02;                /* periodic mode and down-counter */
    TIMER1->TAPR = 1;                   /* 16000000 Hz / 1 = 16000000 Hz */
    TIMER1->TAILR = 16000000*10-1;      /* timer legnth deterimined by 16000000*time-1*/
    TIMER1->ICR = 0x1;                  /* clear the Timer1A timeout flag */
    TIMER1->IMR |= 0x01;                /* enable Timer1A timeout interrupt */
    TIMER1->CTL |= 0x01;                /* enable Timer1A after initialization */
    NVIC->ISER[0] |= 0x00200000;        /* enable IRQ21 (D21 of ISER[0]) */
}


 /*Reads the ADC to take in temperature*/
void TIMER1A_Handler(void)     
{
    volatile int readback;
		
    if (TIMER1->MIS & 0x1)                  /* Timer1A timeout flag */
    {   
        GPIOF->DATA = 0;                    /* turn off LED */ 
        delayMs(200);
        GPIOF->DATA = 0x08;                 /* turn on Green LED */
        delayMs(200);
        ADC1->PSSI |= 8;    	            /* start a conversion sequence 3 */
        while((ADC1->RIS & 8) == 1) ;       /* wait for conversion complete */
            result = ADC1->SSFIFO3;         /* read conversion result */
            ADC1->ISC = 8;      	        /* clear completion flag */
            GPIOF->DATA = 0;                /* turn off LED */		
////////////////////////////////////////////////////////////////////////////////////////
/*Handles the ascii conversion of the room temperatue with in the interupt handler*/
    temp=((result*100)/4096)*1.8+32;
    t2=(temp/10);
    r=t2+48;
    m=temp-(t2*10)+48;		
///////////////////////////////////////////////////////////////////////////////////////
			
/*LCD update within the interupt handler*/			
    LCD_command(1);                     /* clear display */
    LCD_command(0x80);                  /* lcd cursor location first line*/
    LCD_data('S');
    LCD_data('e');
    LCD_data('t');
    LCD_data(' ');
    LCD_data('T');
    LCD_data('e');
    LCD_data('m');
    LCD_data('p');
    LCD_data(':');
    LCD_data(' ');
    LCD_data(s);
    LCD_data(p);
    LCD_data(' ');
    LCD_command(0xC0);                  /* lcd cursor location  second line*/
    LCD_data('R');
    LCD_data('o');
    LCD_data('o');
    LCD_data('m');
    LCD_data(' ');
    LCD_data('T');
    LCD_data('e');
    LCD_data('m');
    LCD_data('p');
    LCD_data(':');
    LCD_data(' ');
    LCD_data(r);
    LCD_data(m);
    LCD_data(' ');
	
    TIMER1->ICR = 0x1; 	                /* clear the Timer1A timeout flag */
    readback = TIMER1->ICR;             /* a read to force clearing of interrupt flag */
    TIMER1->ICR = 0x1;                  /* clear the Timer1A timeout flag */
    readback = TIMER1->ICR;             /* a read to force clearing of interrupt flag */		
    }
    else
    {   /* should not get here, but if we do */
        TIMER1->ICR = TIMER1->MIS;     /* clear all flags */
        readback = TIMER1->ICR;        /* a read to force clearing of interrupt flag */
    }
}



/* SW1 is connected to PF4 pin, SW2 is connected to PF0. Both of them trigger PORTF interrupt 
Interupt handler that reads the switches for updates and prepares them ofr the LCD*/
void GPIOF_Handler(void)
{
    int i;
    volatile int readback;
    while (GPIOF->MIS != 0)
    {
        delayMs(50);
        if (GPIOF->MIS & 0x10)
        {		                        /* is it SW1(PF4)? */
                                    /* GPIOF4 pin interrupt */
            if (setpoint>=66) 
            {
                delayMs(50);
                setpoint=setpoint-1;
                delayMs(50);
            }   
            GPIOF->ICR |= 0x10;         /* clear the interrupt flag */
            readback = GPIOF->ICR;      /* a read to force clearing of interrupt flag */
            delayMs(50);
        } 
        else if (GPIOF->MIS & 0x01)     /* then it must be SW2(PF0) */
        {                               /* GPIOF0 pin interrupt */
            delayMs(50);
            if (setpoint<=84)
            {
                delayMs(50);
                setpoint=setpoint+1;
                delayMs(50);
            }
            GPIOF->ICR |= 0x01;         /* clear the interrupt flag */
            readback = GPIOF->ICR;      /* a read to force clearing of interrupt flag */
            delayMs(50);
        }
        else                            /* We should never get here. */
        {                               /* But if we do, clear all pending interrupts. */
            GPIOF->ICR = GPIOF->MIS;
            readback = GPIOF->ICR;      /* a read to force clearing of interrupt flag */
            delayMs(50);
        }
    }
}

/*Initializes the LCD for use with the microcontroller*/
void LCD_init(void)                 
{ 
    SYSCTL->RCGCGPIO |= 0x01;       /* enable clock to GPIOA */
    SYSCTL->RCGCGPIO |= 0x02;       /* enable clock to GPIOB */
    
    LCD_CTRL->DIR |= 0xE0;          /* set PORTA pin 7-5 as output for control */
    LCD_CTRL->DEN |= 0xE0;          /* set PORTA pin 7-5 as digital pins */
    LCD_DATA->DIR = 0xFF;           /* set all PORTB pins as output for data */
    LCD_DATA->DEN = 0xFF;           /* set all PORTB pins as digital pins */

    delayMs(20);                    /* initialization sequence */
    LCD_command(0x30);
    delayMs(5);
    LCD_command(0x30);
    delayUs(100);
    LCD_command(0x30);
    
    LCD_command(0x38);              /* set 8-bit data, 2-line, 5x7 font */
    LCD_command(0x06);              /* move cursor right */
    LCD_command(0x01);              /* clear screen, move cursor to home */
    LCD_command(0x0F);              /* turn on display, cursor blinking */
}   
/*LCD update handler call*/
void LCD_command(unsigned char command)
{
    LCD_CTRL->DATA = 0;             /* RS = 0, R/W = 0 */
    LCD_DATA->DATA = command;
    LCD_CTRL->DATA = EN;            /* pulse E */
    delayUs(0);
    LCD_CTRL->DATA = 0;
    if (command < 4)
        delayMs(2);                 /* command 1 and 2 needs up to 1.64ms */
    else
        delayUs(40);                /* all others 40 us */
}

/*Handler that allows for the printing of data to the LCD*/
void LCD_data(unsigned char data)
{
    LCD_CTRL->DATA = RS;            /* RS = 1, R/W = 0 */
    LCD_DATA->DATA = data;
    LCD_CTRL->DATA = EN | RS;       /* pulse E */
    delayUs(0);
    LCD_CTRL->DATA = 0;
    delayUs(40);
}

/* delay n milliseconds (16 MHz CPU clock) */
void delayMs(int n)
{
    int i, j;
    for(i = 0 ; i < n; i++)
        for(j = 0; j < 3180; j++)
            {}                      /* do nothing for 1 ms */
}

/* delay n microseconds (16 MHz CPU clock) */
void delayUs(int n)
{
    int i, j;
    for(i = 0 ; i < n; i++)
        for(j = 0; j < 3; j++)
            {}                      /* do nothing for 1 us */
}

/* This function is called by the startup assembly code to perform system specific initialization tasks. */
void SystemInit(void)
{
    __disable_irq();                /* disable all IRQs */
    
    /* Grant coprocessor access */
    /* This is required since TM4C123G has a floating point coprocessor */
    SCB->CPACR |= 0x00F00000;
}