using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSMaster
{
    public class InstitutionInformationParams
    {
        public InsertInstitutionInformation InsertInstitutionInformation { get; set; }
        public UpdateInstitutionInformation UpdateInstitutionInformation { get; set; }
    }
	public class InsertInstitutionInformation
	{
		public int InstitutionId { get; set; }
		public string InstitutionName { get; set; }
		public string Address { get; set; }
		public string ContactNo { get; set; }
		public string PinCode { get; set; }
		public string State { get; set; }
		public string StateCode { get; set; }
		public string GSTIN { get; set; }
		public string SAC { get; set; }
		public string PAN { get; set; }
		public string PlaceOfSupply { get; set; }
		public string EmailId { get; set; }
		public int CreatedBy { get; set; }
	}

	public class UpdateInstitutionInformation
	{
		public string Operation { get; set; }
		public int InstitutionId { get; set; }
		public string InstitutionName { get; set; }
		public string Address { get; set; }
		public string ContactNo { get; set; }
		public string PinCode { get; set; }
		public string State { get; set; }
		public string StateCode { get; set; }
		public string GSTIN { get; set; }
		public string SAC { get; set; }
		public string PAN { get; set; }
		public string PlaceOfSupply { get; set; }
		public string EmailId { get; set; }
		public int UpdatedBy { get; set; }
	}
}
