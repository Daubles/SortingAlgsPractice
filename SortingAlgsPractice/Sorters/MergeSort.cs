namespace SortingAlgsPractice.Sorters;

public class MergeSort : ISorter
{
    public void Sort(int[] inputArray)
    {
        int arrayLength = inputArray.Length;
        //Condition to break recursion once input array has been split into multiple arrays of 1
        if (arrayLength < 2)
        {
            return;
        }

        int midIndex = arrayLength / 2;
        int[] leftHalf = new int[midIndex];
        int[] rightHalf = new int[arrayLength - midIndex];

        for (int i = 0; i < midIndex; i++)
        {
            leftHalf[i] = inputArray[i];
        }

        for (int i = midIndex; i < arrayLength; i++)
        {
            rightHalf[i - midIndex] = inputArray[i];
        }
        
        Sort(leftHalf);
        Sort(rightHalf);
        
        Merge(inputArray, leftHalf, rightHalf);
    }

    /*Loops through both left and right side array comparing first index of each and places lower one
     into input array*/
    private static void Merge(int[] inputArray, int[] leftHalf, int[] rightHalf)
    {
        int leftSize = leftHalf.Length;
        int rightSize = rightHalf.Length;

        int i = 0, j = 0, k = 0;

        while (i < leftSize && j < rightSize)
        {
            if (leftHalf[i] <= rightHalf[j])
            {
                inputArray[k] = leftHalf[i];
                i++;
            }
            else
            {
                inputArray[k] = rightHalf[j];
                j++;
            }

            k++;
        }

        /*Places remaining variables from left or right into array after the first side has finished
        it's loop*/
        while (i < leftSize)
        {
            inputArray[k] = leftHalf[i];
            i++;
            k++;
        }

        while (j < rightSize)
        {
            inputArray[k] = rightHalf[j];
            j++;
            k++;
        }
    }
}