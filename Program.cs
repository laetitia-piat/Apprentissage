using System.Data;

string name = "Laetitia";
char letter = 'A';
int number = 42;
float pi = 3.14159254893626f;
float temperature = 25.5f;
double e = 2.71828555445555888889966333333333321;
decimal money = 19.99m;
bool isRaining = true;
var message = "Welcome to C# programming!";
Console.WriteLine("Hello, " + name + "!");
Console.WriteLine(number);
Console.WriteLine(letter);
Console.WriteLine(pi);
Console.WriteLine(Math.Round(e,2));
Console.WriteLine(money);
Console.WriteLine(isRaining);

Exercice.Addition(5, 3);
Exercice.Substraction(10, 4);

money += 10;
Console.WriteLine(money);
Console.WriteLine(message);
Console.Write("Hello, " + name + "! ");
Console.Write("You have " + number + " messages in your inbox. ");
Console.WriteLine("The temperature is " + temperature + " degrees Celsius.");

Console.WriteLine("Entrez votre prénom : ");
string prenom = Console.ReadLine();
Console.WriteLine("Bonjour, " + prenom + "!");

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");