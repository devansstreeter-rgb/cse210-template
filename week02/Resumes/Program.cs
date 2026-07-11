using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "KenTaco Hut";
        job1._jobTitle = "Rethermalizer Tester";
        job1._startYear = 2001;
        job1._endYear = 2002;

        Job job2 = new Job();
        job2._company = "Frozen Fury";
        job2._jobTitle = "Soda Jerk";
        job2._startYear = 1999;
        job2._endYear = 2000;

        Resume myResume = new Resume();
        myResume._name = "Daniel Streeter";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}