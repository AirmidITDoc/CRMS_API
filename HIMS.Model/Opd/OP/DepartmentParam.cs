using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
   public class DepartmentParam
    {
        public DepartmentSave DepartmentSave { get; set; }
        public DepartmentUpdate DepartmentUpdate { get; set; }
    }

    public class DepartmentSave
    {

      
        public String DepartmentName { get; set; }
        
        public int CreatedBy { get; set; }
        


    }

    public class DepartmentUpdate
    {
        public int DepartmentId { get; set; }
        public String DepartmentName { get; set; }
                public int UpdatedBy { get; set; }

    }
}