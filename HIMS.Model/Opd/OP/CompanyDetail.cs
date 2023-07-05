using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
   public class CompanyDetail
    {
        public CompanyInsert CompanyInsert { get; set; }
        public CompanyUpdate CompanyUpdate { get; set; }

    }

    public class CompanyInsert
    {

     
        public int CompanyId { get; set; }
        public String CompanyName { get; set; }
        public String Address { get; set; }
        public int PinCode { get; set; }
        public int ContactNo { get; set; }
        public String State { get; set; }
        public String StateCode { get; set; }
        public String GSTIN { get; set; }
        public String SAC { get; set; }
        public String PAN { get; set; }
        public String PlaceOfSupply { get; set; }
        public int CreatedBy { get; set; }
      

    }

    public class CompanyUpdate
    {

        public int CompanyId { get; set; }
        public String CompanyName { get; set; }
        public String Address { get; set; }
        public int PinCode { get; set; }
        public int ContactNo { get; set; }
        public String State { get; set; }
        public String StateCode { get; set; }
        public String GSTIN { get; set; }
        public String SAC { get; set; }
        public String PAN { get; set; }
        public String PlaceOfSupply { get; set; }
        public int UpdatedBy { get; set; }

        public bool IsActive { get; set; }
    }
}
