using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
namespace HIMS.Data.Cardiology
{
    public interface I_ProcedureDetails
    {
        public String SaveProcedureDetails(ProcedureDetailsParams procedureDetailsParams);
        public bool UpdateProcedureDetails(ProcedureDetailsParams procedureDetailsParams);
    }
}
