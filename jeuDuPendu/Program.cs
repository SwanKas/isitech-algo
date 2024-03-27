using System;

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
        int tryRemaining = 9;

        while (tryRemaining > 0){
            Console.Clear();
            displayHangMan(tryRemaining);
            Console.WriteLine($"Nombre de tentatives restantes: {tryRemaining}");
            Console.WriteLine("Joueur 2 le mot a trouver ressemble a ca " + string.Concat(wordHidden));
            Console.WriteLine("Joueur 2 donner une lettre:");
            string inputPlayer2 = Console.ReadLine().ToUpper();

            if (inputPlayer2.Length != 1 || !char.IsLetter(inputPlayer2[0])){
                Console.WriteLine("Veuillez entrer une seule lettre valide.");
                continue;
            }

            char guess = inputPlayer2[0];
            bool wordFounded = false;

            for (int i = 0; i < word.Length; i++){
                if (Char.ToUpper(word[i]) == guess){
                    wordHidden[i] = word[i];
                    wordFounded = true;
                }
            }

            if (!wordFounded){
                tryRemaining--;
            }

            if (string.Join("", wordHidden) == word){
                Console.Clear();
                Console.WriteLine("Félicitations ! Vous avez deviner le mot : " + word);
                return;
            }
        }

        Console.Clear();
        displayHangMan(tryRemaining);
        Console.WriteLine("Désolé, vous avez perdu, le mot était : " + word);
    }

    static void displayHangMan(int tryRemaining){
        string[] hangman = {
            "______",
            "|    |",
            "|   " + (tryRemaining < 9 ? (tryRemaining < 1 ? "☠️" : "🙂") : ""),
            "|  " + (tryRemaining < 8 ? "/" : "") + (tryRemaining < 7 ? "[ ]" : "") + (tryRemaining < 6 ? "\\" : ""),
            "|   " + (tryRemaining < 5 ? "|" : "") + (tryRemaining < 4 ? " |" : ""),
            "|   " + (tryRemaining < 3 ? "/ " : "") + (tryRemaining < 2 ? "\\" : ""),
            "|"
        };

        foreach (string line in hangman){
            Console.WriteLine(line);
        }
    }

}
