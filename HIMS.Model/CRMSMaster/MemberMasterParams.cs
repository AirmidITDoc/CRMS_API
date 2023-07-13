using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSMaster
{
    public class MemberMasterParams
    {
        public InsertMemberMaster InsertMemberMaster { get; set; }
        public UpdateMemberMaster UpdateMemberMaster { get; set; }
    }
	public class InsertMemberMaster
	{

		public int MemberId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Member_Address { get; set; }
		public int CityId { get; set; }
		public string PinCode { get; set; }
		public string MobileNo { get; set; }
		public string EmailId { get; set; }
		public int StudyAmount { get; set; }
		public int CreatedBy { get; set; }
	}

	public class UpdateMemberMaster
	{
		public string Operation { get; set; }
		public int MemberId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Member_Address { get; set; }
		public int CityId { get; set; }
		public string PinCode { get; set; }
		public string MobileNo { get; set; }
		public string EmailId { get; set; }
		public int StudyAmount { get; set; }
		public int UpdatedBy { get; set; }
	}
}
