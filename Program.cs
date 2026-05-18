//https://learn.microsoft.com/fr-fr/training/paths/get-started-c-sharp-part-1/
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

//Console.WriteLine("Entrez votre prénom : ");
//string prenom = Console.ReadLine();
//Console.WriteLine("Bonjour, " + prenom + "!");
Console.WriteLine($"Hello {name}!");

string projectName = "ACME";

string englinshMessage = "View English output";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(englinshMessage + ":" + $" \n\tc:\\Exercise\\{projectName}\\data.txt");
Console.WriteLine(russianMessage + ":" + $" \n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");


