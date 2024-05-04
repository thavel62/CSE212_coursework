public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: We will add an item with both data and priority to the back of queue
        // Expected Result: dequeue will return the item with the highest priority
        Console.WriteLine("Test 1");
        var priorityQueue1 = new PriorityQueue();
        priorityQueue1.Enqueue("Item 1", 2); // low
        priorityQueue1.Enqueue("Item 2", 5); // High
        priorityQueue1.Enqueue("Item 3", 3); // Medium
        Console.WriteLine(priorityQueue1.Dequeue()); 
        Console.WriteLine("");


        // Defect(s) Found: None we expect to see Item 2 becuase it is the highest
        // which should be dequeued and displayed

        Console.WriteLine("---------");

        // Test 2
        // Scenario: All items will have the same priority and dequeue the first item
        // Expected Result: Dequeue item 2 because priorities match and it should then take first in queue
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Item 1", 3); // High
        priorityQueue2.Enqueue("Item 2", 3); // High
        priorityQueue2.Enqueue("Item 3", 3); // High
        Console.WriteLine(priorityQueue2.Dequeue());
        Console.WriteLine("");

        // Defect(s) Found:  This test should result in Item 1 
        // because it is the closest to the front of the queue 
        // but we get Item 2

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Test with empty priority 
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 3");
        var priorityQueue3 = new PriorityQueue();
        try
        {
            Console.WriteLine(priorityQueue3.Dequeue());
        }
        catch (Exception ex)   
        {  
            Console.WriteLine(ex.ToString()); //suggest by vscode
        }

    }
}