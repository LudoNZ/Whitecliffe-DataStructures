using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HospitalRecords_20210741
{
    class Computer
    {
        static List<Patient> patientRecords = new List<Patient>();

        public static void ObtainRecords()
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
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine($"Press 'S' for Search, Press 'E' for Exit");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.S)
            {
                Console.WriteLine("\nEnter Patient ID to search: ");
                string search = Console.ReadLine().ToUpper();

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
            Console.WriteLine($"....Searching {patientId}");

            Patient patient = patientRecords.Find(item => item.PatientId == patientId);

            if(patient != null)
            {
                Console.WriteLine($"Search succesfull, Found: {patient.Name}");

                Console.WriteLine(patient.ToString());

                AskRemove(patient);
            }


            else
            {
                Console.WriteLine($"{patientId}\n" +
                                    $" The search found no matching patient");
            }
        }

        static void AskRemove(Patient patient)
        {
            Console.WriteLine("Would you like to remove the patients record(s)?\n" +
                                "Y or N?");

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Y)
            {
                string patientName = patient.Name;

                patientRecords.Remove(patient);

                Console.WriteLine($"\nRecords for patient {patientName} removed successfully");
            }
        }

        static void PrintRecords()
        {
            Console.WriteLine("loopy");
            foreach (Patient patient in patientRecords)
            {
                Console.WriteLine(patient.ToString());
            }
        }
    }
}
