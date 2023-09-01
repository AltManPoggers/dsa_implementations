//Methods: enque, dequeue
using System;
using System.Collections.Generic;


namespace PriorityQueue_DS
{
  public class Patient
  {
    public string Name { get; set; }
    public int IllnessLevel { get; set; }

    public Patient(string name, int illnessLevel)
    {
      this.Name = name;
      this.IllnessLevel = illnessLevel;
    }
  }

  public class HospitalQueue
  {
    private System.Collections.Generic.PriorityQueue<Patient, int> patientsPriorityQueue;

    public HospitalQueue()
    {
      patientsPriorityQueue = new System.Collections.Generic.PriorityQueue<Patient, int>();
      Console.WriteLine("PriorityQueue initialized");
    }

    public void AddPatient(string name, int illnessLevel)
    {
      patientsPriorityQueue.Enqueue(new Patient(name, illnessLevel), illnessLevel);
    }

    public Patient GetNextPatient()
    {
      var patient = patientsPriorityQueue.Dequeue();
      return patient;
    }
  }
}