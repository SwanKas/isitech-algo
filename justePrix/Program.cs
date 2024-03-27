using System;
class Program {
    static void Main(){
        Console.Clear();
        Random rand = new Random();
        int limit = 500;
        int randInt = rand.Next(limit);
        bool numberFound = false;

        while (!numberFound){
            Console.WriteLine($"Entrer un nombre compris entre 0 et {limit}:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int inputPlayer)){
                if (inputPlayer > randInt){
                    Console.WriteLine("Le nombre est plus petit.");
                }
                else if (inputPlayer < randInt){
                    Console.WriteLine("Le nombre est plus grand.");
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
    }
}
