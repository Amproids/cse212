public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Create empty integer array, witht the size of length
        // Create a for loop to iterate {length} number of times
        // multiply the number by the iteration + 1 and put into array
        //after the loop return the array

        var multiplesArray = new double[length];
        for (int i = 0; i < length; i++) {
            multiplesArray[i] = number * (i + 1);
        }
        return multiplesArray;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // create empty array, for final list
        // if the amount rotated is larger than the array, we can just mod the amount by the length of the array
        // in two for loops, add in the values from the initial array
        // first, add ammount number of values, starting at list length - amount - 1 and for ammount number of iterations
        // second add list length - ammount number of values, starting at 0 and iterating to length - ammount - 1
        // return final list array

        int dataLength = data.Count;
        amount = amount % dataLength;
        var rotatedList = new List<int>();
        for (int i = dataLength - amount; i < dataLength; i++) {
            rotatedList.Add(data[i]);
        }
        for (int i = 0; i < dataLength - amount; i++) {
            rotatedList.Add(data[i]);
        }
        data.Clear();
        data.AddRange(rotatedList);
    }
}
