using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

//Welcome the user and prompt them to enter the room specifications 
Console.WriteLine("Thank you for choosing the Room Detail Generator! Please enter the length and width specifications bellow :^).");
Console.WriteLine("What is the length of the room? ");
double Length = double.Parse(Console.ReadLine());

Console.WriteLine("What is the width of the room? ");
double Width = double.Parse(Console.ReadLine());

//Calculate the room specifications
double Area = Length * Width;
Console.WriteLine($"The area of the room is {Area} square feet");
double Perimeter = (Length + Width) * 2;
Console.WriteLine($"The perimeter of the room is {Perimeter}");

//Classify if the room is small, medium or large. List the result in square feet
if (Area <= 250)
{
    Console.WriteLine("The room is small sized.");
}
else if (Area <= 650 && Area >= 251)
{
    Console.WriteLine("The room is medium sized");
}
else
{
    Console.WriteLine("The room is large sized");
}