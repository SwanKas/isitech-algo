namespace tp3;

class Program{

        public static void Main(string[] args){
        // Exo 1
        string inputString = "Hello World";
        string result1 = getFirstAndLastCharacter(inputString);
        Console.WriteLine($"The first and last characters of '{inputString}' are: {result1}");

        // Exo 2
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Tabbleau de base:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        shuffleArray(array);
        Console.WriteLine("Tableau melange:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Exo 3
        int number = -5;
        checkPositiveNegativeZero(number);

        // Exo 4
        int[] array2 = { 1, 2, 3, 4, 2, 2, 5 };
        int target = 2;
        int count = countIdenticalElements(array2, target);
        Console.WriteLine($"The number {target} appears {count} times in the array.");
    }
    // Exo 1: First and Last Character
    public static string getFirstAndLastCharacter(string input){
        if (string.IsNullOrEmpty(input) || input.Length == 1)
            return input;
        
        return input[0].ToString() + input[^1];
    }

    // Exo 2: Shuffle an Array
    public static void shuffleArray(int[] array){
        Random rand = new Random();
        for (int i = array.Length - 1; i > 0; i--){
            int randomIndex = rand.Next(0, i + 1);
            int tmp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = tmp;
        }
    }

    // Exo 3: Positive, Negative, or Zero
    public static void checkPositiveNegativeZero(int number){
        if (number > 0)
            Console.WriteLine($"{number} is positive.");
        else if (number < 0)
            Console.WriteLine($"{number} is negative.");
        else
            Console.WriteLine($"{number} is zero.");
    }

    // Exo 4: Count Identical Elements in an Array
    public static int countIdenticalElements(int[] array, int target)
    {
        int count = 0;
        foreach (int num in array){
            if (num == target)
                count++;
        }
        return count;
    }

}
