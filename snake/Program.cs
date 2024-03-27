using System;

class Program
{
    const int width = 20;
    const int height = 10;
    static int[] snakeX = new int[100];
    static int[] snakeY = new int[100];
    static int snakeLength = 1;
    static int coinX;
    static int coinY;
    static int score = 0;
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.Title = "Snake Game";
        Console.SetWindowSize(width + 1, height + 1);
        Console.SetBufferSize(width + 1, height + 1);

        snakeX[0] = width / 2;
        snakeY[0] = height / 2;

        placeCoin();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                changeDirection(key);
            }

            moveSnake();
            if (checkCollision())
                break;

            displayPlayGround();
            System.Threading.Thread.Sleep(100); // Pour ralentir le jeu
        }

        Console.Clear();
        Console.WriteLine($"Game Over! Your score is: {score}");
    }

    static void displayPlayGround(){
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(new string('-', width));
        for (int i = 1; i < height; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("|");
            Console.SetCursorPosition(width, i);
            Console.Write("|");
        }
        Console.SetCursorPosition(0, height);
        Console.WriteLine(new string('-', width));

        for (int i = 0; i < snakeLength; i++)
        {
            Console.SetCursorPosition(snakeX[i], snakeY[i]);
            Console.Write("+");
        }

        Console.SetCursorPosition(coinX, coinY);
        Console.Write("O");

        Console.WriteLine($"Score: {score}");
    }

    static void moveSnake()
    {
        for (int i = snakeLength - 1; i > 0; i--)
        {
            snakeX[i] = snakeX[i - 1];
            snakeY[i] = snakeY[i - 1];
        }

        switch (direction)
        {
            case Direction.Up:
                snakeY[0]--;
                break;
            case Direction.Down:
                snakeY[0]++;
                break;
            case Direction.Left:
                snakeX[0]--;
                break;
            case Direction.Right:
                snakeX[0]++;
                break;
        }
    }

    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    static Direction direction = Direction.Right;

    static void changeDirection(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (direction != Direction.Down)
                    direction = Direction.Up;
                break;
            case ConsoleKey.DownArrow:
                if (direction != Direction.Up)
                    direction = Direction.Down;
                break;
            case ConsoleKey.LeftArrow:
                if (direction != Direction.Right)
                    direction = Direction.Left;
                break;
            case ConsoleKey.RightArrow:
                if (direction != Direction.Left)
                    direction = Direction.Right;
                break;
        }
    }

    static void placeCoin()
    {
        coinX = random.Next(1, width);
        coinY = random.Next(1, height);
    }

    static bool checkCollision()
    {
        if (snakeX[0] == coinX && snakeY[0] == coinY)
        {
            score++;
            snakeLength++;
            placeCoin();
        }

        if (snakeX[0] <= 0 || snakeX[0] >= width || snakeY[0] <= 0 || snakeY[0] >= height)
            return true;

        for (int i = 1; i < snakeLength; i++)
        {
            if (snakeX[0] == snakeX[i] && snakeY[0] == snakeY[i])
                return true;
        }

        return false;
    }
}
