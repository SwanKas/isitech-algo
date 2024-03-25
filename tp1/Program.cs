namespace tp1;

class Program
{
    public static void Main(string[] args){
        // Exo 1
        int[] arr = { 1, 2, 3, 4, 5 };
        int cible = 3;
        Console.WriteLine($"Est-ce que {cible} est présent dans le tableau ? {searchInteger(arr, cible)}"); 
        
        // Exo 2
        string str = "hello";
        string strReversed = reverseString(str);
        Console.WriteLine($"La chaîne '{str}' à l'envers est '{strReversed}'"); 
        
        // Exo 3
        string str2 = "hello";
        int nbVoyelles = countVowels(str2);
        Console.WriteLine($"Le nombre de voyelles dans la chaîne '{str2}' est {nbVoyelles}"); 
        
        // Exo 4
        int[] arr2 = { 1, 2, 3, 4, 5 };
        int somme = sumArray(arr2);
        Console.WriteLine($"La somme des éléments dans le tableau est {somme}"); 
        
        // Exo 5
        int[] arr3 = { 1, 3, 5, 7, 9 };
        int max = findMax(arr3);
        Console.WriteLine($"La valeur maximale dans le tableau est {max}"); 
            }

    // Exo 1: Search Function
    public static bool searchInteger(int[] arrayNumber, int find){
        foreach (int num in arrayNumber)
        {
            if (num == find)
                return true;
        }
        return false;
    }

    // Exo 2: Reverse String
    public static string reverseString(string input){
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Exo 3: Count Vowels
    public static int countVowels(string input){
        int count = 0;
        foreach (char c in input){
            if ("aeiouyAEIOUY".IndexOf(c) != -1){
                count++;
            }
        }
        return count;
    }

    // Exo 4: Sum of Array
    public static int sumArray(int[] array){
        int sum = 0;
        foreach (int num in array){
            sum += num;
        }
        return sum;
    }

    // Exo 5: Find Maximum Value in an Array
    public static int findMax(int[] array){
        int max = array[0];
        foreach (int num in array){
            if (num > max){
                max = num;
            }
        }
        return max;
    }

}

