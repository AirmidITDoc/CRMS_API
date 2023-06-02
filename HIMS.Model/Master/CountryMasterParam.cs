using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class CountryMasterParam
    {
        public CountryMasterInsert CountryMasterInsert { get; set; }
        public CountryMasterUpdate CountryMasterUpdate { get; set; }

    }

    public class CountryMasterInsert
    {
        public String CountryName_1 { get; set; }
        public int CreatedBy { get; set; }
        

    }

    public class CountryMasterUpdate
    {

        public int CountryId { get; set; }
        public String CountryName { get; set; }
         public int UpdatedBy { get; set; }
    }
}

