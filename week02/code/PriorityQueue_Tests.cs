using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities and remove them all.
    // Expected Result: Items should be dequeued in order of highest priority: C (5), A (3), B (1)
    // Defect(s) Found: Dequeue didn't remove from the list and did not check last element. 
    public void TestPriorityQueue_1()
    {
       var pq = new PriorityQueue();
        pq.Enqueue("A", 3);
        pq.Enqueue("B", 1);
        pq.Enqueue("C", 5);

        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with same priority and test FIFO order.
    // Expected Result: First item added with same priority dequeued first.
    // Defect(s) Found: Used >= instead of >, breaking FIFO rule 
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 2);
        pq.Enqueue("Y", 2);
        pq.Enqueue("Z", 2);

        Assert.AreEqual("X", pq.Dequeue());
        Assert.AreEqual("Y", pq.Dequeue());
        Assert.AreEqual("Z", pq.Dequeue());
    }

     [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: Exception was thrown correctly.
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}