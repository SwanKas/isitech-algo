using System;

namespace tp2
{
class Program{
    public static void Main(string[] args){
        Console.WriteLine("");
        // Exo 1
        Console.WriteLine("Exo 1");
        Console.Write("Entrez la temperature en Celsius : ");
        double celsius;
        if (!double.TryParse(Console.ReadLine(), out celsius)){
            Console.WriteLine("Erreur : Veuillez entrer un nombre valide pour la température en Celsius.");
            return;
        }
        double fahrenheit = convertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"La temperature en Fahrenheit est : {fahrenheit}");

        Console.WriteLine("");
        // Exo 2
        Console.WriteLine("Exo 2");
        Console.Write("Entrez le premier nombre : ");
        double num1;
        if (!double.TryParse(Console.ReadLine(), out num1)){
            Console.WriteLine("Erreur : Veuillez entrer un nombre valide pour le premier nombre.");
            return;
        }
        Console.Write("Entrez le deuxième nombre : ");
        double num2;
        if (!double.TryParse(Console.ReadLine(), out num2)){
            Console.WriteLine("Erreur : Veuillez entrer un nombre valide pour le deuxième nombre.");
            return;
        }
        Console.Write("Entrez le troisième nombre : ");
        double num3;
        if (!double.TryParse(Console.ReadLine(), out num3)){
            Console.WriteLine("Erreur : Veuillez entrer un nombre valide pour le troisième nombre.");
            return;
        }
        double average = calculateAverage(num1, num2, num3);
        Console.WriteLine($"La moyenne des trois nombres est : {average}");

        Console.WriteLine("");
        // Exo 3
        Console.WriteLine("Exo 3");
        Console.Write("Entrez un nombre : ");
        int userInput;
        if (!int.TryParse(Console.ReadLine(), out userInput)){
            Console.WriteLine("Erreur : Veuillez entrer un nombre entier.");
            return;
        }
        string evenOrOdd = checkEvenOrOdd(userInput);
        Console.WriteLine($"Le nombre est {evenOrOdd}");

        Console.WriteLine("");
        // Exo 4
        Console.WriteLine("Exo 4");
        Console.Write("Entrez un nombre : ");
        int inputNumber;
        if (!int.TryParse(Console.ReadLine(), out inputNumber)){
            Console.WriteLine("Erreur : Veuillez entrer un nombre entier.");
            return;
        }
        displayMultiples(inputNumber);

        Console.WriteLine("");
        // Exo 5
        Console.WriteLine("Exo 5");
        Console.Write("Entrez un entier N pour calculer la somme des N premiers nombres naturels : ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n)){
            Console.WriteLine("Erreur : Veuillez entrer un nombre entier.");
            return;
        }
        int sum = calculateSumOfFirstNNaturalNumbers(n);
        Console.WriteLine($"La somme des N premiers nombres naturels est : {sum}");
    }

    // Exo 1: Temperature Converter CELSIUS TO FAHRENHEIT
    public static double convertCelsiusToFahrenheit(double celsius){
        return celsius * 9 / 5 + 32;
    }

    // Exo 2: Average Calculator
    public static double calculateAverage(double num1, double num2, double num3){
        return (num1 + num2 + num3) / 3;
    }

    // Exo 3: Even or Odd Number
    public static string checkEvenOrOdd(int number){
        return (number % 2 == 0) ? "pair" : "impair";
    }

    // Exo 4: Multiples of Number
    public static void displayMultiples(int number){
        Console.WriteLine($"Les dix premiers multiples de {number} sont :");
        for (int i = 1; i <= 10; i++){
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    // Exo 5: Sum of First N Natural Numbers
    public static int calculateSumOfFirstNNaturalNumbers(int n){
        return n * (n + 1) / 2;
    }
}
}
