// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to Westech Applicants App");
Console.WriteLine("Please enter the name of your city or Village: ");
string CityVillage = Console.ReadLine(); //This line reads or accepts user input and stores it in a variable called CityVillage
Console.WriteLine("Please enter your First Name: ");
string firstName = Console.ReadLine(); //This line accepts input and stores it in firstName
Console.WriteLine("Please enter your last name");
string lastName = Console.ReadLine();//This line accepts input and stores it in lastName
Console.WriteLine("Please enter your gender in the form of F for Female or M for Male: ");
string gender = Console.ReadLine();//This line accepts input and stores it in gender
Console.WriteLine("Please enter your age: ");
int age = Console.Read();//This line accepts input and stores it in age
//Displaying the entered information
Console.WriteLine("Your name is " + firstName + " " + lastName + ". From " + CityVillage);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
if (gender.Equals("M"))
{
    gender = new string("Male");
}
else
{
    gender = new string("Female"); ;
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.

Console.Write("Your age is ");
Console.Write(age);
Console.WriteLine(". And you are a "+gender);
