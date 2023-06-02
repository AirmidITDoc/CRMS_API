using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class AreaMasterParam
    {
        public AreaMasterInsert AreaMasterInsert { get; set; }
        public AreaMasterUpdate AreaMasterUpdate { get; set; }

    }

    public class AreaMasterInsert
    {
        public String AreaName { get; set; }
        public int CreatedBy { get; set; }


    }

    public class AreaMasterUpdate
    {

        public int AreaId { get; set; }
        public String AreaName { get; set; }
       
        public int UpdatedBy { get; set; }
    }
}

