using System;
using System.Data;
using System.Runtime.ExceptionServices;

internal class Exercise_session7
{
    static void TaoMangNgauNhien(int[,] a, int rows, int columns)
    {
        Random random = new Random();

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = random.Next(0, 100);
            }
        }
    }
    static void XuatMang(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void XuatHang(int[,] a, int row, int columns)
    {

        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[row, j] + "\t");
        }
        Console.WriteLine();

    }
    static void XuatCot(int[,] a, int rows, int column)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            Console.WriteLine(a[i, column]);
        }
        Console.WriteLine();

    }
    static int TimMax(int[,] a, int rows, int columns)
    {
        int max = a[0, 0];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max)
                {
                    max = a[i, j];
                }
            }

        }
        return max;
    }
    static int[,] TransposeMatrix(int[,]a)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                transposed[j, i] = a[i, j];
            }
            Console.WriteLine();
        }
        return transposed;
    }
    static void InDuongCheoChinh(int[,]a)
    {
        for (int i= 0; i<a.GetLength(0); i++)
        {
            Console.Write(a[i,i]+ "\t");
        }
        Console.WriteLine();
    }
    static void InDuongCheoPhu(int[,]a)
    {
        for (int i=0; i<a.GetLength(0); i++)
        {
            Console.Write(a[i,a.GetLength(0)-1-i] + "\t");
        }
        Console.WriteLine();
    }
    private static void Main71(string[] args)
    {
        //create and print matrix
        int[,] a;
        Console.Write("Nhap so N: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Nhap so M: ");
        int col = int.Parse(Console.ReadLine());
        a = new int[row, col];
        TaoMangNgauNhien(a, row, col);
        XuatMang(a);

        Console.WriteLine();
        //in hang/cot
        Console.Write("Ban muon in 1 hang hay cot (hang/cot): ");
        string choice = Console.ReadLine().ToLower();
        if (choice == "hang")
        {
            Console.Write("Nhap so hang muon in: ");
            int N = int.Parse(Console.ReadLine()) - 1;
            if (N >= 0 && N < row)
            {
                XuatHang(a, N, col);
            }
            else
            {
                Console.WriteLine("So hang khong hop le.");
            }
        }
        else if (choice == "cot")
        {
            Console.Write("Nhap so cot muon in: ");
            int M = int.Parse(Console.ReadLine()) - 1;
            if (M >= 0 && M < col)
            {
                XuatCot(a, row, M);

            }
            else
            {
                Console.WriteLine("So hang khong hop le.");

            }
        }
        else
        {
            Console.WriteLine("Vui long chon dung.");
        }

        Console.WriteLine();
        //maxvalue of the matrix
        int max = TimMax(a, row, col);
        Console.WriteLine($"\nMax value is: {max}");

        Console.WriteLine();
        //transpose the matrix
        int[,] transposed = TransposeMatrix(a);
        Console.WriteLine("\nTransposed maxtrix:");
        XuatMang(transposed);
        Console.WriteLine();
        //In duong cheo chinh(chi danh cho ma tran vuong
        if (row==col)
        {
            Console.WriteLine("\nDuong cheo chinh:");
            InDuongCheoChinh(a);

            Console.WriteLine("\nDuong cheo phu:");
            InDuongCheoPhu(a);
        }
        else
        {
            Console.WriteLine("\nKhong phai ma tran vuong");
        }
            
    }
    /// <summary>
    /// Create a jagged array and initialize it using the following values for its rows and columns; 
    /// Then, display it.
    /// </summary>
    /// <param name="args"></param>
    private static void Main72(string[] args)
    {
        int[][] jaggedArray = new int[4][];
        jaggedArray[0] = new int[] { 1, 1, 1, 1, 1 };
        jaggedArray[1] = new int[] { 2, 2 };
        jaggedArray[2] = new int[] { 3, 3, 3, 3 };
        jaggedArray[3] = new int[] { 4, 4 };
        Console.WriteLine("Jagged Array:");
        foreach (int[] row in jaggedArray)
        {
            foreach (int value in row)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

    }
    private static void Main73(string[] args)
    {
        // Get number of rows and columns from the user
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[rows][];

        Random random = new Random();

        // Initialize the jagged array
        for (int i=0; i < rows; i++)
        {
            Console.Write($"Enter the number of columns for row {i + 1}: ");
            int cols = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[cols];
            // Fill the row with random numbers or user input
            for (int j = 0; j < cols; j++)
            {
                jaggedArray[i][j] = random.Next(1, 100); // Random number between 1 and 99
            }

        }
        // Print the jagged array
        Console.WriteLine("\nJagged Array:");
        PrintJaggedArray(jaggedArray);
        Console.WriteLine();
        //print largest number
        PrintLargestNumbers(jaggedArray);
        Console.WriteLine();
        //SortAtoZ
        Console.WriteLine("\nSorted Array:");
        SortAtoZ(jaggedArray);
        PrintJaggedArray(jaggedArray);
        Console.WriteLine();
        //Print all prime numbers
        Console.WriteLine("\nPrime numbers: ");
        PrintPrimes(jaggedArray);
        Console.WriteLine();
        //Search and print all positions of a number
        Console.Write("\nEnter a number to search for: ");
        int num = int.Parse(Console.ReadLine());
        SearchNumber(jaggedArray, num);
        Console.WriteLine();
    }
    static void PrintJaggedArray(int[][] jaggedArray)
    {
        foreach (int[]row in jaggedArray)
        {
            foreach (int value in row)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
    static void PrintLargestNumbers(int[][] jaggedArray)
    {
        int globalMax = int.MinValue;

        Console.WriteLine("\nLargest number in each row:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int rowMax = int.MinValue;
            foreach (int value in jaggedArray[i])
            {
                if (value > rowMax) rowMax = value;
                if (value > globalMax) globalMax = value;
            }
            Console.WriteLine($"Row {i + 1}: {rowMax}");
        }

        Console.WriteLine($"\nLargest number in the entire array: {globalMax}");
    }
    static void SortAtoZ(int[][] jaggedArray)
    {
        foreach (int[] row in jaggedArray)
        {
            for (int i =0; i < row.Length; i++ )
            {
                for (int j =0; j <i; j ++)
                {
                    if (row[i] < row[j])
                    {
                        int m = row[i];
                        row[i] = row[j];
                        row[j] = m;
                    }
                }
            }
        }
    }
    static void PrintPrimes(int[][] jaggedArray)
    {
        foreach (int[] row in jaggedArray)
        {
            foreach (int value in row)
            {
                if (IsPrime(value))
                    Console.Write(value + " ");
            }
        }
        Console.WriteLine();
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    static void SearchNumber(int[][] jaggedArray, int num)
    {
        bool Find = false;
        for ( int i = 0; i < jaggedArray.Length; ++i )
        {
            for (int j = 0; j < jaggedArray[i].Length; ++j )
            {
                if (jaggedArray[i][j] == num)
                {
                    Console.WriteLine($"The number {num} is found at row {i+1} col {j+1} ");
                    Find = true;
                }
            }
        }
        if (!Find)
        {
            Console.WriteLine($"The number {num} is not found in the array");
        }    
    }
}

