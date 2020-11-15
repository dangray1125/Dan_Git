/*////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///// This Program was an exercise to remain familiar with looping and control statments while dealing with the stated problem of taking a string from a  ////
///// user and chreating a character pyramid from the characters in the string.									  	  //// 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////AUTHORS: Daniel Gray														Date:2/29/2020	  ////
/////PURPOSE: Coding Exercise: Character Pyramid (C++)													  ////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

#include <iostream>
#include <string>

using namespace std;

int main()
{
   string pyramid_string;
   int rows{};
      
cout<< "Enter a sting of characters (Letters of Numbers) with out spaces: ";
getline(cin,pyramid_string);
rows=pyramid_string.length();

//for loop 1  uses 'i' to set the current row of the pyramid with '1' being the top and as i get larger the pyramid grows down.
for(int i{1};i<=rows;i++){
    int k{};            // keeps track of the character of the string starting at 0 every time the loop starts a new row.
    string blk=" ";     // used as a string variable to insert spaces after each character of the pyramid.
    
//for loop 2: uses 'space' to add the proper number of spaces to each row.
    for(int space{0};space<=rows-i;++space){
        cout<<"  ";
    }
    
//while loop 1: handles the printing of the charcaters on the left hand of the pyramid.    
            while(k!=i){
            cout<<pyramid_string.at(k)+blk;
            k++;
            }
            
//while loop 2: handles the printing of the characters on the left hand of the pyramid.
            while(k<=i&&i>1&&k>1){
            k--;
            cout<<pyramid_string.at(k-1)+blk;
            }
            
//endl concludes the most current row of the pyramid
       cout<<endl;
}

   return 0;
 }
