using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class DoctorMasterparam
    {
        public DoctorMasterInsert DoctorMasterInsert { get; set; }
        public DoctorMasterUpdate DoctorMasterUpdate { get; set; }

       
       // public DeleteAssignDoctorToDepartment DeleteAssignDoctorToDepartment { get; set; }
        public List<DoctorDepartmentDet> AssignDoctorDepartmentDet { get; set; }

    }

    public class DoctorMasterInsert
    {

	
        public int DoctorId { get; set; }
           
        public long PrefixID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public string Age { get; set; }
        public long GenderId { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }

        public String Education { get; set; }
        public bool IsConsultant { get; set; }
        public bool IsRefDoc { get; set; }

        public int DoctorTypeId { get; set; }
        public bool IsActive { get; set; }
    
        public string AgeYear { get; set; }
        public string AgeMonth { get; set; }
        public string AgeDay { get; set; }
        public String PassportNo { get; set; }
        public String ESINO { get; set; }
        public String RegNo { get; set; }
        public DateTime RegDate { get; set; }
        public String MahRegNo { get; set; }
        public DateTime MahRegDate { get; set; }
        public String RefDocHospitalName { get; set; }

        public bool IsInHouseDoctor { get; set; }

        public bool IsOnCallDoctor { get; set; }
      
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }

    public class DoctorMasterUpdate
    {


        public int DoctorId { get; set; }

        public long PrefixID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public string Age { get; set; }
        public long GenderId { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }

        public String Education { get; set; }
        public bool IsConsultant { get; set; }
        public bool IsRefDoc { get; set; }
        public int DoctorTypeId { get; set; }

        public string AgeYear { get; set; }
        public string AgeMonth { get; set; }
        public string AgeDay { get; set; }
        public String PassportNo { get; set; }
        public String ESINO { get; set; }
        public String RegNo { get; set; }
        public DateTime RegDate { get; set; }
        public String MahRegNo { get; set; }
        public DateTime MahRegDate { get; set; }
        public String RefDocHospitalName { get; set; }

        public bool IsInHouseDoctor { get; set; }

        public bool IsOnCallDoctor { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }

    public class DoctorDepartmentDet
    {

        public long DoctorId { get; set; }
        public long DepartmentId { get; set; }
    }

    public class DeleteAssignDoctorToDepartment
    {
        public long DoctorId { get; set; }
    }

}

