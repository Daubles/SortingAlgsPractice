namespace SortingAlgsPractice.Sorters;

public class SelectSort : ISorter
{
    private static void Swap(int[] numArray, int x, int y)
    {
        (numArray[x], numArray[y]) = (numArray[y], numArray[x]);
    }

    //Swap method that loops through array and swaps with smallest remaining number
    public void Sort(int[] inputArray)
    {
        int i = 0;
        int n = inputArray.Length - 1;
        while (i < n)
        {
            int j = LocationOfSmallest(inputArray, i, n);
            Swap(inputArray, i, j);
            i++;
        }
    }

    //Loops through array to find the smallest variable
    private static int LocationOfSmallest(int[] a, int startPoint, int endPoint)
    {
        int i = startPoint;
        int j = i;
        while (i <= endPoint)
        {
            if (a[i] < a[j])
            {
                j = i;
            }
            i++;
        }
        return j;
    }
}