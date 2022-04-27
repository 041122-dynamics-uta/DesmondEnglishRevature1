#!bin/bash

#Comparing Numbers

Given two integers, *X* and *Y*, identify whether *X < Y*  or *X > Y* or *X = Y*.

Exactly one of the following lines:

- *X is less than Y*

- *X is greater than Y*

- *X is equal to Y*

##############################################
#from the two input integers find out whether they are greater, lesser than, or equal to!

read x
read y 

#ALWAYS REMEMBER YOUR SPACES AND THEN STATEMENTS!!!
if [ $x -gt $y ]
    then 
    echo X is greater than Y
elif [ $x -lt $y ]
then
    echo X is less than Y
else 
 echo X is equal to Y
 fi

