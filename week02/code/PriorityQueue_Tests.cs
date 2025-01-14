using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities and verify the highest priority item is dequeued first
    // Expected Result: When dequeuing, should get "C" first (priority 3), then "B" (priority 2), then "A" (priority 1)
    // Defect(s) Found: 
    // 1. Dequeue method doesn't actually remove the item from the queue
    // 2. Dequeue loop condition is incorrect (Count - 1 misses last element)
    public void TestPriorityQueue_1()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        // Act & Assert
        Assert.AreEqual("C", priorityQueue.Dequeue(), "First dequeue should return highest priority item 'C'");
        Assert.AreEqual("B", priorityQueue.Dequeue(), "Second dequeue should return next highest priority item 'B'");
        Assert.AreEqual("A", priorityQueue.Dequeue(), "Third dequeue should return lowest priority item 'A'");
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority and verify they are dequeued in FIFO order.
    // Expected Result: When multiple items have same priority, the one added first should be dequeued first.
    // Defect(s) Found: 
    // 1. The Dequeue method uses >= in priority comparison which causes it to take the later item instead of the first one.
    // 2. Same defects as Test 1 (not removing items and incorrect loop count)
    public void TestPriorityQueue_2()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 2);

        // Act & Assert
        Assert.AreEqual("First", priorityQueue.Dequeue(), "Should return 'First' as it was added first with same priority");
        Assert.AreEqual("Second", priorityQueue.Dequeue(), "Should return 'Second' as it was added second with same priority");
        Assert.AreEqual("Third", priorityQueue.Dequeue(), "Should return 'Third' as it was added last with same priority");
    }

    // Add more test cases as needed below.
}