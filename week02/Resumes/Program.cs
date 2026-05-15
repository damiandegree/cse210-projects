using System;

class Program
{
    static void Main(string[] args)
    {
 Job job1 = new Job();
        job1._jobTitle = "Logistic Operator";
        job1._company = "La Virginia S.A";
        job1._startYear = 2026;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Production Operator";
        job2._company = "Cerro Negro S.A";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Job job3 = new Job();
        job3._jobTitle ="Production and Logistic Operator";
        job3._company = "Coca Cola Andina S.A";
        job3._startYear = 2018;
        job3._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Matias Martinez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();    }
}