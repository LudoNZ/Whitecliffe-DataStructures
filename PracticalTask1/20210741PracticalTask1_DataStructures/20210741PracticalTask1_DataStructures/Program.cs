using System;
using System.Collections.Generic;
using System.IO;

namespace HospitalRecords_20210741
{
    class Program
    {

        static List<Patient> patientRecords = new List<Patient>();

        static void Main(string[] args)
        {
            Console.WriteLine("Starting Programme... Obtaining records...");

            ObtainRecords();

            Console.WriteLine("Programme finished");
            Console.ReadLine();
        }

        //Build List<Patient> patientRecords
        static void ObtainRecords()
        {
            //Use path to the ListOfPatients.txt here
            string path = @"C:\Users\ludob\Desktop\Whitecliffe-DataStructures\PracticalTask1\ListOfPatients.txt";

            //an array to store info on one patient
            string[] oneRecord;

            //an array to store info on one patient
            Patient patient;

            //Read file using streamreader. (reads Line by Liome)
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    int counter = 0;

                    //to store each line of the file
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        oneRecord = ln.Split(',');
                        patient = new Patient(oneRecord[0], oneRecord[1], oneRecord[2], oneRecord[3]);

                        //YOUR CODE 
                        //adding patient to the list
                        patientRecords.Add(patient);

                        counter++;
                    }

                    //close ListOfPatients.txt File 
                    file.Close();

                    Console.WriteLine($"**Patient records have been recorded successfully**\n   " +
                        $"{counter} Patients in database");

                    Menu();
                        

                }
            }
        }

        static void Menu()
        {
            Console.WriteLine($"Press 'S' for search, Press 'E' for exit");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.S)
            {
                Console.WriteLine("Enter Patient ID to search: ");
                string search = Console.ReadLine();

                SearchRecords(search);

                Menu();
            }
            else if (key.Key == ConsoleKey.E)
            {
                Console.WriteLine("E pressed. Quitting App....");
                //Application.Exit();
            }

        }

        static void SearchRecords(string patientId)
        {
            //Patient patient = patientRecords.Contains("NNK254");
            //patientId = patientRecords.FindIndex(e => e."NNK254");
            Console.WriteLine($"Searching{patientId}");

            Patient myItem = patientRecords.Find(item => item.PatientId == patientId);

            Console.WriteLine(ref myItem.Name);
        }

        static void PrintRecords()
        {
            Console.WriteLine("loopy");
            foreach (Patient pat in patientRecords)
            {
                Console.WriteLine(pat.ToString());
            }
        }

    }

    class Patient
    {
        public string PatientId, Name, CheckInDate, AssignedMedicalPersonnel;

        public Patient(string patientId, string name, string checkInDate, string assignedMedicalPersonnel)
        {
            this.PatientId = patientId;
            this.Name = name;
            this.CheckInDate = checkInDate;
            this.AssignedMedicalPersonnel = assignedMedicalPersonnel;
        }

        public override string ToString()
        {
            return $"Patient ID: {this.PatientId}\n " +
                                $"Name: {this.Name}\n" +
                                $"Check In Date: {this.CheckInDate}\n" +
                                $"Assigned Medical Personnel: {this.AssignedMedicalPersonnel}";
        }

    }

}
