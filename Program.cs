//Name: Ulises Ortega
//Date: 09.07.22
//Project Name: Adding Numbers
/*Description: 
The program ask the user to enter 2 numbers, 
User input will be check to be validated, 
if a number will store it and is not a number, It will ask the user to enter a number
once both are numbers are validated as numbers, It will move to sum both numbers.*/ 
//Revised by: 

string userChoice = "";

int num1, num2, result;
bool checkNum1, CheckNum2;

do{


do{
Console.WriteLine("Please Type the First Number");
//string n1 = Console.ReadLine();
checkNum1 = Int32.TryParse(Console.ReadLine(), out num1);
if (checkNum1 == false)
{
    Console.WriteLine("that is not a number, please enter a number");
}
}while(checkNum1 == false);


do{
Console.WriteLine("Please Type the Second Number");
//string n2 = Console.ReadLine();
checkNum1 = Int32.TryParse(Console.ReadLine(), out num2);
if (checkNum1 == false)
{
    Console.WriteLine("that is not a number, Please enter a number");
}
}while(checkNum1 == false);


result = num1+num2;
Console.WriteLine("Your Total is " + result);


do
{
    Console.WriteLine("Do you want to continue: Yes or No?");
    userChoice = Console.ReadLine().ToUpper();
    if(userChoice != "YES" && userChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");