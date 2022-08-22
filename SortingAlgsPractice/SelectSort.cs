namespace SortingAlgsPractice;

public class SelectSort
{
    private static void Swap(int[] numArray, int x, int y)
    {
        (numArray[x], numArray[y]) = (numArray[y], numArray[x]);
    }

    //Swap method that loops through array and swaps with smallest remaining number
    public static int[] RunSelectSort(int[] numArray)
    {
        int i = 0;
        int n = numArray.Length - 1;
        while (i < n)
        {
            int j = LocationOfSmallest(numArray, i, n);
            Swap(numArray, i, j);
            i++;
        }

        return numArray;
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