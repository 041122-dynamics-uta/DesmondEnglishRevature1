#!bin/bash

#Getting started with conditionals

Read in one character from STDIN.

If the character is 'Y' or 'y' display "YES".

If the character is 'N' or 'n' display "NO".

No other character will be provided as input.

##############################################

#read input character from STDIN
#if "Y" or "y" display "YES"
#if otherwise display "NO"

read input 

if  [[ "$input" == "Y" || "$input" == "y" ]];
then 
    echo "YES"
else
    echo "NO"
fi
