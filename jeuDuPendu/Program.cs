namespace consoleProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Joueur 1 rentrer le mot pour le jeu pendu:");
        string word = null;
        while (true){
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
                break;
            word += key.KeyChar;
        }
        char[] wordHidden = new char[word.Length];
        for (int i = 0; i < word.Length; i++){
            wordHidden[i] = '_';
        }
        int tryRemainin = 9;
        Console.WriteLine(wordHidden);


        while (tryRemainin > 0){        
            Console.WriteLine("Nombre de tentatives restantes: " + tryRemainin.ToString());
            Console.WriteLine("Joueur 2 le mot a trouver ressemble a ca " + string.Concat(wordHidden));
            Console.WriteLine("Joueur 2 donner une lettre:");
            string inputPlayer2 = Console.ReadLine();
            if(inputPlayer2.Length > 1){
                Console.WriteLine("Joueur 2 veuillez entrer qu'une seule lettre:");
                continue;
            }
            tryRemainin -= 1;
        }

    }
}