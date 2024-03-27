using System;
class Program {
    static void Main(){
        Console.Clear();
        Random rand = new Random();
        int limit = 10000;
        int tryMax = 20;
        int randInt = rand.Next(limit);
        bool numberFound = false;

        while (!numberFound && tryMax > 0){
            Console.WriteLine($"Entrer un nombre compris entre 0 et {limit}:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int inputPlayer)){
                if (inputPlayer > randInt){
                    Console.WriteLine("Le nombre est plus petit.");
                    tryMax--;
                }
                else if (inputPlayer < randInt){
                    Console.WriteLine("Le nombre est plus grand.");
                    tryMax--;
                }
                else{
                    Console.WriteLine($"Félicitations ! Vous avez deviné le bon nombre : {randInt}");
                    numberFound = true;
                }
            }
            else{
                Console.WriteLine("Entrer un nombre valide.");
            }
        }
        if(tryMax == 0){
            Console.WriteLine($"Nombre d'essais maximum atteind PERDU, le bon nombre etait {randInt}");
        }
    }
}
