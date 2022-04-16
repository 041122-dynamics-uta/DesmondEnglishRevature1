#The World of Numbers

Given two integers, *X* and *Y*, find their sum, difference, product, and quotient.

##############################################

#find sum, difference, product, and quotient, of two integers respectively!

#contains integer to be read out
read x
read y

#To perform an operation, surround the variables with (()) or [] and precede with a $ sign.
#respective calculations
echo $(expr $x + $y)
echo $(expr $x - $y)
echo $(expr $x \* $y)
echo $(expr $x / $y)
~
