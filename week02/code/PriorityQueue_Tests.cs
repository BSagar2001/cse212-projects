using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    // Scenario: Add three items with different priorities.
    // Expected Result: The item with the highest priority is removed first.
    // Defect(s) Found: The last item in the queue was not checked when searching for the highest priority, and the dequeued item was not removed from the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

priorityQueue.Enqueue("A", 1);
priorityQueue.Enqueue("B", 5);
priorityQueue.Enqueue("C", 3);

Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    // Scenario: Two items have the same highest priority.
    // Expected Result: The first item added is removed first (FIFO).
    // Defect(s) Found: When two items had the same priority, the queue removed the last one instead of the first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

priorityQueue.Enqueue("A", 5);
priorityQueue.Enqueue("B", 5);

Assert.AreEqual("A", priorityQueue.Dequeue());
Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
// Scenario: Dequeue from an empty queue.
// Expected Result: InvalidOperationException with the correct message.
// Defect(s) Found: No defects found. The correct exception and message were thrown.
public void TestPriorityQueue_3()
{
    var priorityQueue = new PriorityQueue();

    var ex = Assert.ThrowsException<InvalidOperationException>(() =>
    {
        priorityQueue.Dequeue();
    });

    Assert.AreEqual("The queue is empty.", ex.Message);
}
}