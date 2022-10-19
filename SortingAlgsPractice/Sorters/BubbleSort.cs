namespace SortingAlgsPractice.Sorters;

public class BubbleSort : ISorter
{
    private void Swap(int[] numArray, int x, int y)
    {
        (numArray[x], numArray[y]) = (numArray[y], numArray[x]);
    }

    //Loops through array comparing to sequential numbers and swapping where condition is met
    public void Sort(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = 1; j < inputArray.Length - i; j++)
            {
                if (inputArray[j] < inputArray[j - 1])
                {
                    Swap(inputArray, j, j-1);
                }
            }
        }
    }
 

}