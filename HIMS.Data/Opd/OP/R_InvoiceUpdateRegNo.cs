using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_InvoiceUpdateRegNo :GenericRepository,I_InvoiceUpdateRegNo
    {
        public R_InvoiceUpdateRegNo(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Update(InvoiceUpdateRegNoParam InvoiceUpdateRegNoParam)
        {
            // throw new NotImplementedException();
            var disc6 = InvoiceUpdateRegNoParam.UpdateRegno.ToDictionary();
            
            ExecNonQueryProcWithOutSaveChanges("Upt_Reg_RegNo_1", disc6);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
