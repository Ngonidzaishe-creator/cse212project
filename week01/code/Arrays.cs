using System.Collections.Generic;

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
        // Plan:
        // 1. Allocate an array of the requested length.
        // 2. For each index i (0..length-1) set element to number * (i+1).
        // 3. Return the filled array.

        double[] multiples = new double[length];   // Step 1

        for (int i = 0; i < length; i++)           // Step 2
        {
            multiples[i] = number * (i + 1);       // Step 3
        }

        return multiples;                          // Step 4
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
        // Plan:
        // 1. Handle null or empty list.
        // 2. Normalize amount to data.Count.
        // 3. Use the three-step reverse method to rotate in-place:
        //    reverse entire list, reverse first k elements, reverse remaining elements.

        if (data == null || data.Count == 0)
            return;

        int k = amount % data.Count;
        if (k == 0)
            return;

        data.Reverse();
        data.Reverse(0, k);
        data.Reverse(k, data.Count - k);
    }
}
