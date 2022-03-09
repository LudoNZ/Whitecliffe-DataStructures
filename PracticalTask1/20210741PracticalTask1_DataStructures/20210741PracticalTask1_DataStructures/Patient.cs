using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalRecords_20210741
{
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
            return $"  Patient ID: {this.PatientId}\n" +
                                $"  Name: {this.Name}\n" +
                                $"  Check In Date: {this.CheckInDate}\n" +
                                $"  Assigned Medical Personnel: {this.AssignedMedicalPersonnel}";
        }

    }
}
