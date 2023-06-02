using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
  public  class ReliginMasterParam
    {
        public ReligionMasterInsert ReligionMasterInsert { get; set; }
        public ReligionMasterUpdate ReligionMasterUpdate { get; set; }

    }

    public class ReligionMasterInsert
    {
        public String ReligionName { get; set; }
        public int CreatedBy { get; set; }
     

    }

    public class ReligionMasterUpdate
    {

        public int ReligionID { get; set; }
        public String ReligionName { get; set; }
      
        public int UpdatedBy { get; set; }
    }
}

