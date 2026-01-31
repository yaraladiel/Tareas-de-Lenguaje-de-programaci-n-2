using System;  

// Variables iniciales about myself
string Name = "Yeremi";  
string LastName = "Yola Liveren";  
int Age = 19;  // Como número entero
float Height = 1.7f;  // La altura como decimal con f indica que es float

//Datos del programador "yo"
Console.WriteLine($"Hello, my name is {Name} {LastName}");
Console.WriteLine($"I am from RD, I'm {Age} years old, and my height is {Height} Centimeters\n");

// Pedir datos al usuario
Console.Write("Name: ");
string? UserName = Console.ReadLine();  

Console.Write("LastName: ");
string? UserLastName = Console.ReadLine(); 

Console.Write("Age: ");
string ageInput = Console.ReadLine(); 
int UserAge = Convert.ToInt32(ageInput);  // Convertir texto a número

// Convertir texto a número
Console.Write("Height: ");
string heightInput = Console.ReadLine();  // Leer altura como texto
float UserHeight = Convert.ToSingle(heightInput);  // Convertir texto a decimal

// Mostrar datos del usuario
Console.WriteLine($"¡Welcome {UserName} {UserLastName}!");
Console.WriteLine($"Your age is {UserAge} years old, and your height is {UserHeight} meters\n");