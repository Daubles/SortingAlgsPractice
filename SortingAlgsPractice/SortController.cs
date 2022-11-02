using System.Diagnostics;
using Microsoft.Extensions.Logging;
using SortingAlgsPractice.Sorters;

namespace SortingAlgsPractice;

public class SortController
{
    private readonly ILogger<SortController> _logger;

    public SortController(ILogger<SortController> logger)
    {
        _logger = logger;
    }
    public void Start()
    {
        _logger.LogDebug("Program started");
        int[] numArray = CreateArray(ArraySizeSelection());
        Console.WriteLine("Here is your unsorted array:");
        DisplayArray(numArray);
        DisplayMenu();
        int menuSelection = Convert.ToInt16(Console.ReadLine());
        Stopwatch timer = new Stopwatch();
        timer.Start();                  
        RunMenu(menuSelection, numArray);
        timer.Stop();
        _logger.LogDebug("This array was sorted in: {0:mm\\:ss\\.fff}", timer.Elapsed);
    }
    
    
    //Creates array of random numbers
        private static int[] CreateArray(int n)
        {
            const int min = 0;
            const int max = 100;
            
            
            int[] numArray = new int[n];
            Random randNum = new Random();

            //Inserting numbers into array
            for (int i = 0; i < n; i++)
            {
                numArray[i] = randNum.Next(min, max);
            }
            return numArray;
        }

        private int ArraySizeSelection()
        {
            int arraySizeInput = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number N:");
                    arraySizeInput = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    _logger.LogDebug(e.StackTrace);
                    Console.WriteLine("You have inputted an invalid number, please try again:");
                    
                }

            }
            
            return arraySizeInput;
        }
        
        private static void DisplayArray(int[] numArray)
        {
            foreach (int i in numArray)
            {
                Console.Write("{0} ", i);
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\nSelect an option below to sort your array: ");
            Console.WriteLine("(1) Bubble Sort");
            Console.WriteLine("(2) Select sort");
            Console.WriteLine("(3) Insert Sort");
            Console.WriteLine("(4) Merge Sort");
        }

        private static void RunMenu(int menuSelection, int[] numArray)
        {
            switch (menuSelection)
            {
                case 1:
                    ISorter bubbleSort = new BubbleSort();
                    bubbleSort.Sort(numArray);
                    Console.WriteLine("Your array has been sorted below using bubble sort: ");
                    DisplayArray(numArray);
                    break;
                case 2:
                    ISorter selectSort = new SelectSort();
                    selectSort.Sort(numArray);
                    Console.WriteLine("Your array has been sorted below using select sort: ");
                    DisplayArray(numArray);
                    break;
                case 3:
                    ISorter insertSort = new InsertSort();
                    insertSort.Sort(numArray);
                    Console.WriteLine("Your array has been sorted below using an insert sort: ");
                    DisplayArray(numArray);
                    break;
                case 4:
                    ISorter mergeSort = new MergeSort();
                    mergeSort.Sort(numArray);
                    Console.WriteLine("Your array has been sorted below using select sort: ");
                    DisplayArray(numArray);
                    break;
                default:
                    Console.WriteLine("Please select a valid input.");
                    break;
            }
            
        }
}