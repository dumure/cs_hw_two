using System.Data;
using System.Net.Http.Headers;

internal class Tasks
{
    public static void TaskOne()
    {
        int rmin = 1;
        int rmax = 100;
        int size = 5;
        int[] arr = new int[size];
        int value;
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value:\n >>> ");
            if (int.TryParse(Console.ReadLine(), out value))
            {
                arr[i] = value;
            }
        }
        int rows = 3, cols = 4;
        int[,] mdarr = new int[rows, cols];
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Random random = new Random();
                mdarr[r,c] = random.Next(rmin, rmax);
            }
        }
        Console.WriteLine("Array: ");
        Console.Write("\t");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("Multidimensional array: ");
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write($"\t{mdarr[r, c]}");
            }
            Console.WriteLine();
        }
        int[] help_arr = new int[rows * cols];
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                help_arr[r * cols + c] = mdarr[r, c];
            }
        }
        Console.WriteLine($"Common maximum element: { (new int[] {help_arr.Max(), arr.Max()}).Max() }");
        Console.WriteLine($"Common minimum element: { (new int[] {help_arr.Min(), arr.Min()}).Min() }");
        Console.WriteLine($"Total sum of elements: {arr.Sum() + help_arr.Sum()}");
        int prod = 1;
        for (int i = 0; i < size; i++)
        {
            prod *= arr[i];
        }
        for (int j = 0; j < rows * cols; j++)
        {
            prod *= help_arr[j];
        }
        Console.WriteLine($"Total product of elements: {prod}");
        int odd_sum = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 != 0)
            {
                odd_sum += arr[i];
            }
        }
        Console.WriteLine($"Odd elements sum in array: {odd_sum}");
        int col_odd_sum = 0;
        for (int r = 0; r < rows; r += 2)
        {
            for (int c = 0; c < cols; c++)
            {
                col_odd_sum += mdarr[r, c];
            }
        }
        Console.WriteLine($"Odd columns' elements sum in multidimensional array: {col_odd_sum}");
    }
    public static void TaskTwo()
    {
        int rows = 5, cols = 5;
        int[,] mdarr = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Random random = new Random();
                mdarr[i, j] = random.Next(-100, 100);
            }
        }
        Console.WriteLine("Multidimensional array: ");
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write($"\t{mdarr[r, c]}");
            }
            Console.WriteLine();
        }
        int sum = 0;
        int[] help_arr = new int[rows * cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                help_arr[rows * i + j] = mdarr[i, j];
            }
        }
        bool flag = false;
        int mini = -1, maxi = -1;
        for (int i = 0; i < rows * cols; i++)
        {
            if (help_arr[i] == help_arr.Max())
            {
                maxi = i;
            }
            if (help_arr[i] == help_arr.Min())
            {
                mini = i;
            }
        }
        if (maxi != -1 && mini != 0)
        {
            for (int i = mini + 1; i < maxi; i++)
            {
                sum += help_arr[i];
            }
        }
        Console.WriteLine($"Sum of elements beetwen min and max: {sum}");
    }
}
