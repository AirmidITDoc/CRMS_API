using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
  public  class PrefixMasterParam
    {
        public PrefixMasterInsert PrefixMasterInsert { get; set; }
        public PrefixMasterUpdate PrefixMasterUpdate { get; set; }

    }

    public class PrefixMasterInsert
    {
        public String PrefixName { get; set; }
        public int SexID { get; set; }
        public int AddedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class PrefixMasterUpdate
    {

        public int PrefixID { get; set; }
        public String PrefixName { get; set; }
        public int SexID { get; set; }
        public bool IsDeleted { get; set; }
        public int UpdatedBy { get; set; }
    }
}

