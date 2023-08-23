﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class PrefixMasterParams
    {
        public PrefixMasterInsert PrefixMasterInsert { get; set; }
        public PrefixMasterUpdate PrefixMasterUpdate { get; set; }

    }

    public class PrefixMasterInsert
    {
        public String PrefixName { get; set; }
        public int SexID { get; set; }
         public bool IsActive { get; set; }
    }

    public class PrefixMasterUpdate
    {

        public int PrefixID { get; set; }
        public String PrefixName { get; set; }
        public int SexID { get; set; }
        public bool IsActive { get; set; }
      //  public int UpdatedBy { get; set; }
    }
}

