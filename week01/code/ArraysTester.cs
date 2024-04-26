public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start

        // Instructions for how to implement MultiplesOf function:
        // The first thing we need to do is create an array where we will store the multiples when they are calculated.
        // The next step would be, calculating the multiples for the number given. A for loop should loop through the varying lengths well.
        // In each step of the for loop, we will want to multiply the given number by the index in the multiple. This will give us our multiple stored in the array.
        // To finish off, we will need to print the array to show the user the multiples of the numbers.

        // establish array
        double[] multiples = new double[length];
        // for loop to loop through and create & store multiples
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1); // calculates multiples
        }

        return multiples; // retrun the array
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start

        // What we want to start with here is evaluating the amount to ensure we have a distance to move the list.
        // Then we want to identify the amount we have to rotate the data by taking the amount away from our count.
        // We then need to use in this case, GetRange to select the amount of elements from the data list that we will move to the front as the rotational movement. 
        // RemoveRange is how we will extract them once selected
        // Finally, we will insert the selected elements using InsertRange and put them at the beginning of the list so the rest moves to the end. 
        if (amount <= 0 || data.Count == 0)
        {
            return; // No need to rotate
        }

        // Calculate rotation amount
        int effectiveAmount = amount % data.Count;

        // Extract the elements to be rotated
        List<int> rotatedElements = data.GetRange(data.Count - effectiveAmount, effectiveAmount);

        // Rotate the list
        data.RemoveRange(data.Count - effectiveAmount, effectiveAmount);
        data.InsertRange(0, rotatedElements);


    }
}
