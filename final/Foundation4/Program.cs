using System;
using System.Collections.Generic;

namespace ExerciseTrackingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            // create some activities
            RunningActivity runningActivity = new RunningActivity(new DateTime(2022, 11, 03), 30, 3.0);
            CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2022, 11, 03), 30, 20);
            SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2022, 11, 03), 30, 10);

            // add the activities to the list
            activities.Add(runningActivity);
            activities.Add(cyclingActivity);
            activities.Add(swimmingActivity);

            // display the summary of each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}