using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
    public class DepartmentTypeParam
    {
        public DocDepartmentSave DocDepartmentSave { get; set; }
        public DocDepartmentUpdate DocDepartmentUpdate { get; set; }
    }

    public class DocDepartmentSave
    {

        public int DocDeptId { get; set; }
        public int DoctorId { get; set; }
        public int DepartmentId { get; set; }

        public int CreatedBy { get; set; }
    }

    public class DocDepartmentUpdate
    {
        public int DocDeptId { get; set; }
        public int DoctorId { get; set; }
        public int DepartmentId { get; set; }


        public int UpdatedBy { get; set; }

    }

}
