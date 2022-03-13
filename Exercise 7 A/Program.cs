// See https://aka.ms/new-console-template for more information
int num1, num2, answer1, answerRemainder;
Console.WriteLine("Please enter two whole numbers and the programe will divide the smaller number by the bigger number also the programe will display the answer using a quotient and remainder");
Console.Write("\n Please enter your first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\n Please enter your second number");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num2 != 0) answer1 = num1 / num2;
{
    Console.WriteLine("\n\nThe answer is = " + answer1 + "with a remainder of " + answerRemainder);
}
else if (num1 < num2 && num1 != 0)
{
    answer1 = num2 / num1;
    answerRemainder = num2 % num1;
    Console.WriteLine("\n\nThe answer is = "+ answer1 + " with a remainder of" + answerRemainder);
}
else
{
    Console.WriteLine("\n\nError! Cannot divide by 0");
}