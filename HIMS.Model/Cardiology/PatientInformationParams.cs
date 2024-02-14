using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class PatientInformationParams
    {
        public SavePatientInformation SavePatientInformation { get; set; }
        public UpdatePatientInformation UpdatePatientInformation { get; set; }

    }

    public class SavePatientInformation
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public long RefferedDr { get; set; }
        public long CreatedBy { get; set; }

    }

    public class UpdatePatientInformation
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public long RefferedDr { get; set; }
        public long UpdatedBy { get; set; }
        public string Operation { get; set; }
    }
}
