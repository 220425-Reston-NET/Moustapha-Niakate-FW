# This is a comment
# It is just like putting a sticky note to your code to give a meaningfull message
# of what you are doing in this script
# echo is a way forus to give feeback to the person running the shell scripting

echo "this is my first shell script!"

#Variables
msg="Hello World variable"
echo $msg # Syntax is what we need to write to specify that we are referencing a variable
# Control Flow
# They are a way to tell the programme to run multiple lines of code multiples times or
# We can tell the program to run lines of code if a condition is meet 

# If Statements
ten=10
five=5
thirteen=13

echo "===First If==="
if [ "$ten" -ge "$five" ]
then
echo "Greater!"
echo "$ten > $five"
fi

echo "===Second If==="

if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then
echo "Lesser!"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -ge "$thirteen" ]
then
echo "Greater"
echo "$five > $thirteen"
else
echo "Nothing Matches"
fi

# Loop Statement
# Is way to repeat multiple lines of code x amount of times you want 

# For Loops statements
# Will repeat x amount of times 
# usefull if you know how many times you need to execute those lines ofcode
 
echo "===First Loop==="
for number in 1 2 3 4 5
do
echo "Hello"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

# While Loop Statement 
# Useful when you don't know how many times you need to execute those lines of code 
# Will repeat your lines of code multiple times as long as the condition is true
echo "===While Loop==="

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) # $((mathematical operation)) syntax is how we can do math 
echo "$five"
done

# Input and Output
# We can ask for inputer from the user that is using the shell scripting and output some sort of response 
echo "What is your name?"
# read name # Read [whatever variable name you specify] will store the user input in that variable
echo "Hello $name, welcome to programming!"

# making the shell menu

clear # clear command will clear all the text in terminal
repeat="true"

while [ "$repeat" == "true" ]
do
echo "Welcome to shell scripting!"
echo  "What do you want to do today?"
echo "enter 1 for adding two numbers"
echo "enter 2 to exit"

read answer
if [ "$answer" == "1" ]
then
echo "Give me number 1"
read num1
echo "Give me number 2"
read num2
echo "The sum is $(($num1+$num2))"
elif [ "$answer" == "2" ]
then
	repeat="false"

else
echo "please enter a correct option"

fi

done

