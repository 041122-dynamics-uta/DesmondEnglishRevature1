#Design
bold="\033[1m"
nc="\033[0m"
red="\033[31m"
yellow="\033[33m"

#Bash Calculator Challenge!!!

#Welcome user to "The Calculator"
greeting () {
echo  "\033[40;38;5;82m Hello \033[30;48;5;82m World \033[0m"
echo "\n  	${yellow}${bold}Welcome User to 'The Calculator', What shall I call you Human? \n${nc}" 
read input  
echo "\n	${yellow}${bold}Hello $input\n${nc}"
echo "${bold}\n$input, What would like to do? Choose from the following!\n${nc}"
calculation
}
#Build Calculation Menu for User
calculation () {
PS3='Please enter your choice: '
options=("Addition" "Subtraction" "Multiplication" "Division" "Quit")
select opt in "${options[@]}"
do
    case $opt in
        "Addition")
            echo "Addition"
            input
            add
            break
            ;;
        "Subtraction")
            echo "Subtraction"
            input
            subtract
            break
            ;;
        "Multiplication")
            echo "Multiplication"
            input
            multiply
            break
            ;;
        "Division")
            echo "Division"
            input
            divide
            break
            ;;
        "Quit")
            exit
            ;;
        *) echo "invalid option" calculation;;
    esac
done
}
#produce @ least 4 different functions for each calculation(5 for modulus maybe)
#DO NOT print each result, create seperate result(function) 
add () {
        result=$(( num1 + num2 ))
        resultType="Sum"
        final
}
subtract () {
        result=$(( num1 - num2 ))
        resultType="Difference"
        final
}
multiply () {
        result=$(( num1 * num2 ))
        resultType="Product"
        final 
}
divide () {
    if [ $num2 == 0 ];
	then 
        echo  ${red}${bold}Incorrect Option. Try Again!${nc}
    else
	    result=$((num1 / num2))
        resultType="Quotient"
	    remainder=$((num1 % num2))
        final
    fi
}
#Build Calculation Loop
input () { 
echo "\n${yellow}${bold}Enter your first number.\n${nc}" 
    read num1 
echo "\n${yellow}${bold}Enter your second number.\n${nc}" 
    read num2
}

#Hit enter after inputs by user to produce results from result(function)
final () {
    if [ $resultType == "Sum" ] || [ $resultType == "Difference" ] || [ $resultType == "Product" ]
    then
        echo --------------------------------
        echo $resultType of $num1 and $num2 is $result 
        echo --------------------------------
    else 
        echo -----------------------------------------------
        echo $resultType of $num1 and $num2 is $result with remainder of $remainder
        echo -----------------------------------------------
    fi
    #User gets to choose to enter another calculation or quit "The Calculator" Game Loop
    #Would You Like To START the Game Again?
    echo "\n${yellow}${bold}Would You Like To START the Game Again? $input${nc}\n"
    echo Y or N
    read ans 
        if [  $ans == "y" ]
        then
            calculation
        else 
            exit
        fi 
}
greeting