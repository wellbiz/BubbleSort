using System; 
  
class bubblesort 
{
    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
    static void bubbleSort(int []arr) 
    { 
        for (var i = 0; i < arr.Length - 1; i++) 
            for (int j = 0; j < arr.Length - i - 1; j++) 
                if (arr[j] > arr[j + 1]) 
                {
                    // swap temp and arr[i] 
                    Swap<int>(ref arr[j], ref arr[j + 1]);
                } 
    } 
  
    /* Prints the array */
    static void printArray(int []arr) 
    { 
        int n = arr.Length; 
        for (int i = 0; i < n; ++i) 
            Console.Write(arr[i] + " "); 
        Console.WriteLine(); 
    } 
  

 
    public static void Main() 
    {
        const int size = 10;
        int[] arr = new int[size];
        Random rnd = new Random();

        //Получить случайное число (в диапазоне от 0 до 10)
        for (int i = 0; i < size; i++)
        {
            arr[i] = rnd.Next(0, 10);
        }
        bubbleSort(arr); 
        Console.WriteLine("Sorted array"); 
        printArray(arr); 
    } 
  
} 