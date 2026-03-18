using System;

namespace GradeCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int examAssignments = 5;

            int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = { 90, 95, 87, 88, 96, 96 };
            int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
            int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };

            string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

            int[] studentScores = new int[10];
            string currentStudentLetterGrade = "";

            Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;
                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;
                else if (currentStudent == "Emma")
                    studentScores = emmaScores;
                else if (currentStudent == "Logan")
                    studentScores = loganScores;
                else if (currentStudent == "Becky")
                    studentScores = beckyScores;
                else if (currentStudent == "Chris")
                    studentScores = chrisScores;
                else if (currentStudent == "Eric")
                    studentScores = ericScores;
                else if (currentStudent == "Gregor")
                    studentScores = gregorScores;
                else
                    Console.WriteLine("Error: Student not found");

                int examScoreSum = 0;
                int extraCreditSum = 0;
                int gradedAssignments = 0;

                foreach (int score in studentScores)
                {
                    gradedAssignments++;

                    if (gradedAssignments <= examAssignments)
                        examScoreSum += score;
                    else
                        extraCreditSum += score;
                }

                decimal examScore = (decimal)examScoreSum / examAssignments;

                decimal extraCreditPoints = ((decimal)extraCreditSum * 0.1m) / examAssignments;

                decimal overallGrade = ((decimal)examScoreSum + (extraCreditSum * 0.1m)) / examAssignments;

                // Grade calculation
                if (overallGrade >= 97) currentStudentLetterGrade = "A+";
                else if (overallGrade >= 93) currentStudentLetterGrade = "A";
                else if (overallGrade >= 90) currentStudentLetterGrade = "A-";
                else if (overallGrade >= 87) currentStudentLetterGrade = "B+";
                else if (overallGrade >= 83) currentStudentLetterGrade = "B";
                else if (overallGrade >= 80) currentStudentLetterGrade = "B-";
                else if (overallGrade >= 77) currentStudentLetterGrade = "C+";
                else if (overallGrade >= 73) currentStudentLetterGrade = "C";
                else if (overallGrade >= 70) currentStudentLetterGrade = "C-";
                else if (overallGrade >= 67) currentStudentLetterGrade = "D+";
                else if (overallGrade >= 63) currentStudentLetterGrade = "D";
                else if (overallGrade >= 60) currentStudentLetterGrade = "D-";
                else currentStudentLetterGrade = "F";

                Console.WriteLine($"{currentStudent}\t\t{examScore:F1}\t\t{overallGrade:F2}\t{currentStudentLetterGrade}\t{extraCreditSum} ({extraCreditPoints:F2} pts)");
            }

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}