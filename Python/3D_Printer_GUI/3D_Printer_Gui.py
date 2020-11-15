##### This code generates a graphical user interface which interfaces with a 
##### Ceramic 3D printer which runs the Marlin Firmware over the use of USB 
##### Connection.
##### Authors: Dan Gray and Alex Aragona                           Date:12/06/19

from tkinter import filedialog
from tkinter import *
from tkinter import ttk
# CONSTANTS
X = 20

# Preset values
axisMotors = 100
flowMotor = 100
xCoord = 0
yCoord = 0
zCoord = 0

''' ******Commands*****
Below you will find all commands used for push button assigned tasks
'''
# Browser Button
def browse_button():
    # Allow user to select a directory and store it in global var
    # called folder_path
    global folder_path
    filename = filedialog.askopenfilename()
    folder_path.set(filename)
    print(filename)


# Window of the GUI
uI = Tk()
uI.title("Ceramic 3D Printer Tool")
uI.geometry('600x600')
uI.configure(background="grey")

# Tab1 instructions
tabControl= ttk.Notebook(uI)
tab1= ttk.Frame(tabControl)
tabControl.add(tab1, text= "Print Control")
tabControl.pack(expand= 1, fill= 'both')
bgColor= Frame(tab1)
bgColor.configure(bg="grey")
bgColor.place(height=700, width=700)
# Tab2 Instructions
tab2= ttk.Frame(tabControl)
tabControl.add(tab2, text= "Set Up")
tabControl.pack(expand= 1, fill= 'both')
bgColor= Frame(tab2)
bgColor.configure(bg="grey")
bgColor.place(height=700, width=700)
'''
 ****** Inside tab1 ******
 Below you will find the code that allows for the display of
 all items under tab1.
'''
# Connection Status Label
cStat = Label(tab1, text="Connection Status:", font="none 14 bold", bg="grey", fg="white")
cStat.place(x=X, y=10)
conexBtn = Button(tab1, text="Connect", bg="black", width=7, highlightbackground="grey")
conexBtn.place(x=415, y=10)

# File Browser Entry Box and Button
folder_path = StringVar()
fileSelect = Entry(tab1, text=folder_path, fg="black", bg="white", width=56, highlightbackground="grey")
fileSelect.place(x=X, y=50)
browseButton = Button(tab1, text="Browse", bg="black", command=browse_button, highlightbackground="grey")
browseButton.place(x=425, y=80)

'''
 ****** Print Control Settings ******
 Below you will find the code that allows for the modifications of
 print setting during the printing process.
'''
printControlSettings = Label(tab1, text="Print Control Settings", font="none 14 bold", bg="grey", fg="white")
printControlSettings.place(x=X, y=90)
# Axis Motor Ratio Heading
motorRatio = Label(tab1, text=" Axis Motor Ratios", font="none 12 bold", bg="grey", fg="white")
motorRatio.place(x=30, y=115)
# X - Axis Motor
motorRatioXLabel = Label(tab1, text=" X Axis: ", font="none 12 bold", bg="grey", fg="white")
motorRatioXLabel.place(x=50, y=135)
motorRatioXSet = Label(tab1, text=axisMotors, font="none 12 bold", bg="grey", fg="white", width=2)
motorRatioXSet.place(x=105, y=135)
# Y - Axis Motor
motorRatioYLabel = Label(tab1, text=" Y Axis: ", font="none 12 bold", bg="grey", fg="white")
motorRatioYLabel.place(x=140, y=135)
motorRatioYSet = Label(tab1, text=axisMotors, font="none 12 bold", bg="grey", fg="white", width=3)
motorRatioYSet.place(x=195, y=135)
# Z - Axis Motor
motorRatioZLabel = Label(tab1, text=" Z Axis: ", font="none 12 bold", bg="grey", fg="white")
motorRatioZLabel.place(x=230, y=135)
motorRatioZSet = Label(tab1, text=axisMotors, font="none 12 bold", bg="grey", fg="white", width=3)
motorRatioZSet.place(x=285, y=135)
# Axis Motor Modifications Button
axisMotorButton = Button(tab1, text="Change Axis Ratios", bg="black", command=browse_button, highlightbackground="grey")
axisMotorButton.place(x=350, y=135)
# Flow rate motor
flowMotorLabel = Label(tab1, text="Flow Rate: ", font="none 12 bold", bg="grey", fg="white")
flowMotorLabel.place(x=50, y=165)
flowMotorSet = Label(tab1, text=flowMotor, font="none 12 bold", bg="grey", fg="white", width=3)
flowMotorSet.place(x=120, y=165)
# Flow Rate Motor Modifications Button
flowMotorButton = Button(tab1, text="Change Flow Rate", bg="black", command=browse_button, highlightbackground="grey")
flowMotorButton.place(x=350, y=165)
# Print Button
printButton = Button(tab1, text="Print", bg="black", command=browse_button, highlightbackground="grey", width=10)
printButton.place(x=160, y=400)
# Cancel Button
cancelButton = Button(tab1, text="Cancel", bg="black", command=browse_button, highlightbackground="grey", width=10)
cancelButton.place(x=248, y=400)
# Pause Button
pauseButton = Button(tab1, text="Pause", bg="black", command=browse_button, highlightbackground="grey", width=21)
pauseButton.place(x=160, y=425)
'''
 ****** Home and Prime Buttons ******
 Below you will find the code that allows for the display of
 print status during the printing process.
'''
# Home Button
phHomeButton = Button(tab1, text="Home Print Head", bg="black", command=browse_button, highlightbackground="grey")
phHomeButton.place(x=300, y=220)

# Prime Button
primeButton = Button(tab1, text="Prime Printer", bg="black", command=browse_button, highlightbackground="grey", width=15)
primeButton.place(x=125, y=220)

'''
 ****** Print Staus ******
 Below you will find the code that allows for the display of
 print status during the printing process.
'''
printStatus = Label(tab1, text="Printing Status", font="none 14 bold", bg="grey", fg="white")
printStatus.place(x=170, y=275)
# Axis Motor Ratio Heading
motorStatus = Label(tab1, text=" Current Axis Coordinates", font="none 12 bold", bg="grey", fg="white")
motorStatus.place(x=30, y=295)
# X - Axis Motor
motorStatusXLabel = Label(tab1, text=" X Axis: ", font="none 12 bold", bg="grey", fg="white")
motorStatusXLabel.place(x=50, y=320)
motorStatusXSet = Label(tab1, text=xCoord, font="none 12 bold", bg="grey", fg="white", width=2)
motorStatusXSet.place(x=105, y=320)
# Y - Axis Motor
motorStatusYLabel = Label(tab1, text=" Y Axis: ", font="none 12 bold", bg="grey", fg="white")
motorStatusYLabel.place(x=140, y=320)
motorStatusYSet = Label(tab1, text=yCoord, font="none 12 bold", bg="grey", fg="white", width=3)
motorStatusYSet.place(x=195, y=320)
# Z - Axis Motor
motorStatusZLabel = Label(tab1, text=" Z Axis: ", font="none 12 bold", bg="grey", fg="white")
motorStatusZLabel.place(x=230, y=320)
motorStatusZSet = Label(tab1, text=zCoord, font="none 12 bold", bg="grey", fg="white", width=3)
motorStatusZSet.place(x=285, y=320)
'''
 ****** Inside tab2 ******
 Below you will find the code that allows for the display of
 print status during the printing process.
'''
# WiFi SetUp
ipAddLabel= Label(tab2, text="ip Address", font="none 12 bold", bg="grey", fg="white")
ipAddLabel.place(x=125, y=180)
ipAdd=Entry(tab2, width=40, text="a")
ipAdd.place(x=125, y=200)

portNumLabel= Label(tab2, text="Port Number", font="none 12 bold", bg="grey", fg="white")
portNumLabel.place(x=125, y=260)
portNum=Entry(tab2, width=40, text="b")
portNum.place(x=125, y=280)

WiFiSetBtn= Button(tab2, text="Submit", bg="black", command=browse_button, highlightbackground="grey", width=21)
WiFiSetBtn.place(x=200, y=325)

# settings window
sWindow = Canvas(tab1, bg="white")

# Run GUI
uI.mainloop()
