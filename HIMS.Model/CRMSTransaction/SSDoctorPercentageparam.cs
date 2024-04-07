using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSTransaction
{
			 public class SSDoctorPercentageparam
			 {
			public InsertDoctorPercentage InsertDoctorPercentage { get; set; }
			public UpdateDoctorPercentage UpdateDoctorPercentage { get; set; }
		}

		public class InsertDoctorPercentage
	{

	
			public int StudyId { get; set; }
			public int ServiceId { get; set; }
			public float Percentage { get; set; }
			public string DocType { get; set; }
			public int IsActive { get; set; }
			public int CreatedBy { get; set; }
			public DateTime CreatedOn { get; set; }
			public int UpdatedBy { get; set; }
			public DateTime UpdatedOn { get; set; }

	}

		public class UpdateDoctorPercentage
	{

		public int StudyId { get; set; }
		public int ServiceId { get; set; }
		public float Percentage { get; set; }
		public string DocType { get; set; }
		public int IsActive { get; set; }
		public int UpdatedBy { get; set; }
		public DateTime UpdatedOn { get; set; }
	}


	}
