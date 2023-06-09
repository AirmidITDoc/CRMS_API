﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class GenderMasterParams
    {
        public GenderMasterInsert GenderMasterInsert { get; set; }
        public GenderMasterUpdate GenderMasterUpdate { get; set; }

    }

    public class GenderMasterInsert
    {
        public String GenderName { get; set; }
      //  public int AddedBy { get; set; }
        public bool IsActive { get; set; }
    }

    public class GenderMasterUpdate
    {
        public int GenderId { get; set; }
        public String GenderName { get; set; }
        public bool IsActive { get; set; }
      //  public int UpdatedBy { get; set; }
    }
}

