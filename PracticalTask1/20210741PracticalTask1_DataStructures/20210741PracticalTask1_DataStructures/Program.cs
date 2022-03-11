using System;
using System.Collections.Generic;
using System.IO;

namespace HospitalRecords_20210741
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Programme... Obtaining records...");

            //Build List<Patient> patientRecords from File
            Computer.ObtainRecords();

            Computer.Menu();
        }
        

    }

}
