using System;
using PriorityQueue_DS;
public class Program
{
    public static void Main()
    {
        PriorityQueue queue = new PriorityQueue();

        queue.AddPatient("Kirby", 4);
        queue.AddPatient("John", 2);

        Patient nextPatient = queue.GetNextPatient();
        Console.WriteLine($"{nextPatient.Name} with illness level {nextPatient.IllnessLevel} should be treated next.");
    }
}