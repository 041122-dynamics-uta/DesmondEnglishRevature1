#1.The user starts the bash script.

#2.The script welcomes the user

#3.The script presents the user with a menu that allows the user to choose between the options add, subtract, multiply, or divide.

#4.After the user chooses a calculation type, they are prompted to enter the two integers. This can be one integer at a time.

#5.After pressing enter, the result is presented to the user.

#6.The user can choose to exit the program or choose to make another calculation.

##############################################################################################

#Colors
bold="\033[1m"
nc="\033[0m"
red="\033[31m"
blue="\033[34m"



#Greeting
echo '\n  	Welcome User to "The Calculator", What shall I call you human? \n '  

read input  

echo "\n	${blue}${bold}Hello $input \n${nc}"


echo "${bold}\n$input, what would like to do? Choose from the following!\n${nc}"

#While loop, user can choose to exit program or make another calculation.
while [ true ]
do

#Calculation Options
echo "	 'a' Addition | 's' Subtracton | 'm' Multiplication | 'd' Division | 'q' Quit "
echo "\nEnter Your Choice\n"
read c 


#Loops through chosen calculation option
if [ $c == a ];
then echo "Enter first number.\n"
    read num1
    echo "Enter second number.\n"
    read num2
	num3=$(( num1 + num2 ))
	echo "${bold}${blue}The sum is $num3\n${nc}"
elif [ $c == s ];
then echo "Enter first number.\n"
    read num1
    echo "Enter second number.\n"
    read num2
	num3=$(( num1 - num2 ))
	echo "${bold}${blue}The sub is $num3\n${nc}"
elif [ $c == m ];
then echo "Enter first number.\n"
    read num1
    echo "Enter second number.\n"
    read num2
	num3=$(( num1 * num2 ))
	echo "${bold}${blue}The product is $num3\n${nc}"
elif [ $c == d ]; 
then echo "Enter first number.\n"
    read num1
    echo "Enter second number.\n"
    read num2
		if [ $num2 == 0 ];
		then echo  ${red}${bold}Incorrect Option. Try Again${nc}
		exit
		fi
	num3=$((num1 / num2))
	mod=$((num1 % num2))
	echo  ${bold}${blue}The quotient is $num3${nc}
	echo  ${bold}${blue}The modulus is $mod${nc}
else [ $c == "q" ];
	exit
fi
done
