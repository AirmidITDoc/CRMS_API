using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class Doctortypeparam
    {
        public DoctortTypeMasterInsert DoctortTypeMasterInsert { get; set; }
        public DoctorTypeMasterUpdate DoctorTypeMasterUpdate { get; set; }

    }

    public class DoctortTypeMasterInsert
    {
        public String DoctorType { get; set; }
        public bool IsActive { get; set; }

    }

    public class DoctorTypeMasterUpdate
    {

        public int ID { get; set; }
        public String DoctorType { get; set; }
        public bool IsActive { get; set; }

    }
}

