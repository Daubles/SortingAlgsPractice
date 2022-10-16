namespace SortingAlgsPractice.UnitTests;

public class SortingAlgsPracticeTests
{
    [Test]
    public void BubbleSort_Sorts_Unsorted_Array()
    {
        //Arrange
        var numArray = new int[] {5, 94, 1, 1, 67};
        var bubbleSort = new BubbleSort();
        
        //Act
        bubbleSort.RunBubbleSort(numArray);
        
        //Assert
        Assert.That(numArray[0], Is.EqualTo(1));
        Assert.That(numArray[1], Is.EqualTo(1));
        Assert.That(numArray[2], Is.EqualTo(5));
        Assert.That(numArray[3], Is.EqualTo(67));
        Assert.That(numArray[4], Is.EqualTo(94));
    }

    [Test]
    public void InsertSort_Sorts_Unsorted_Array()
    {
        //Arrange
        var numArray = new int[] {5, 94, 1, 1, 67};
        var bubbleSort = new InsertSort();
        
        //Act
        bubbleSort.RunInsertSort(numArray);
        
        //Assert
        Assert.That(numArray[0], Is.EqualTo(1));
        Assert.That(numArray[1], Is.EqualTo(1));
        Assert.That(numArray[2], Is.EqualTo(5));
        Assert.That(numArray[3], Is.EqualTo(67));
        Assert.That(numArray[4], Is.EqualTo(94));
    }
    
    [Test]
    public void MergeSort_Sorts_Unsorted_Array()
    {
        //Arrange
        var numArray = new int[] {5, 94, 1, 1, 67};
        var mergeSort = new MergeSort();
        
        //Act
        mergeSort.RunMergeSort(numArray);
        
        //Assert
        Assert.That(numArray[0], Is.EqualTo(1));
        Assert.That(numArray[1], Is.EqualTo(1));
        Assert.That(numArray[2], Is.EqualTo(5));
        Assert.That(numArray[3], Is.EqualTo(67));
        Assert.That(numArray[4], Is.EqualTo(94));
    }
    
    [Test]
    public void SelectSort_Sorts_Unsorted_Array()
    {
        //Arrange
        var numArray = new int[] {5, 94, 1, 1, 67};
        var selectSort = new SelectSort();
        
        //Act
        selectSort.RunSelectSort(numArray);
        
        //Assert
        Assert.That(numArray[0], Is.EqualTo(1));
        Assert.That(numArray[1], Is.EqualTo(1));
        Assert.That(numArray[2], Is.EqualTo(5));
        Assert.That(numArray[3], Is.EqualTo(67));
        Assert.That(numArray[4], Is.EqualTo(94));
    }
}