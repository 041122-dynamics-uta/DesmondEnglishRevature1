#!bin/bash

#More on Conditionals

Given three integers (X, Y, and Z) representing the three sides of a triangle, identify whether the triangle is scalene, isosceles, or equilateral.

- If all three sides are equal, output EQUILATERAL.
- Otherwise, if any two sides are equal, output ISOSCELES.
- Otherwise, output SCALENE.

##############################################

#identify the traingle output

read x
read y
read z

if [[ $x -eq $y && $x -eq $z ]]; #(&&(AND-Operator))
then 
    echo EQUILATERAL
elif [[ $x -eq $y || $x -eq $z || $y -eq $z ]]; #(||(OR-Operator))
then
    echo ISOSCELES
else 
    echo SCALENE    
fi
