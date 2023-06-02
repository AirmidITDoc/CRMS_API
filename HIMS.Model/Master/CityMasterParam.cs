using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class CityMasterParam
    {
        public CityMasterInsert CityMasterInsert { get; set; }
        public CityMasterUpdate CityMasterUpdate { get; set; }

    }

    public class CityMasterInsert
    {
        public String CityName { get; set; }
        public int StateId { get; set; }
        public int CreatedBy { get; set; }
        

    }

    public class CityMasterUpdate
    {

        public int CityId { get; set; }
        public String CityName { get; set; }
        public int StateId { get; set; }
        public int UpdatedBy { get; set; }
    }
}

