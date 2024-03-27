using System;

class Program
{
    const int width = 20;
    const int height = 10;
    static int crossX = width / 2;
    static int crossY = height / 2;
    static ConsoleKeyInfo keyInfo;

    static void Main(string[] args){
        Console.CursorVisible = false;
        Console.Title = "Move the Cross";
        Console.SetWindowSize(width + 1, height + 1);
        Console.SetBufferSize(width + 1, height + 1);

        DrawSquare();

        while (true)
        {
            DrawCross();
            var key = Console.ReadKey(true).Key;
            MoveCross(key);
        }
    }

    static void DrawSquare(){
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(new string('-', width)); // creer une ligne horizontale qui a pour longueur la width mis en const tout en haut
        for (int i = 1; i < height; i++){ // creer une ligne verticale qui a pour longueur la height mis en const tout en haut{

            Console.SetCursorPosition (0, i);
            Console.Write("|");
            Console.SetCursorPosition(width, i);
            Console.Write("|");
        }
        Console.SetCursorPosition(0, height); //creer une ligne horizontale qui a pour longueur la width mis en const tout en haut
        Console.WriteLine(new string('-', width));
    }

    static void DrawCross(){
        Console.SetCursorPosition(crossX, crossY);
        Console.Write("+");
    }

    static void MoveCross(ConsoleKey key){ // bouger le curseur en fonctions de la touche (fleche)
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (crossY > 1)
                    crossY--;
                break;
            case ConsoleKey.DownArrow:
                if (crossY < height - 1)
                    crossY++;
                break;
            case ConsoleKey.LeftArrow:
                if (crossX > 1)
                    crossX--;
                break;
            case ConsoleKey.RightArrow:
                if (crossX < width - 1)
                    crossX++;
                break;
        }

        DrawSquare();
    }
}
