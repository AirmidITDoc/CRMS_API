using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSTransaction;
using HIMS.Data.CRMSTransaction;
using System.Data.SqlClient;
using System.Data;
using HIMS.Common.Utility;
namespace HIMS.Data.CRMSTransaction
{
    public class R_Billintegration : GenericRepository, I_Billintegration
    {
        public R_Billintegration(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
        public bool Update_Bill_integration(BillintegrationParams billintegrationParams)
        {
            var disc3 = billintegrationParams.Update_Bill_integration.ToDictionary();
            var CommitteeMeetingId = ExecNonQueryProcWithOutSaveChanges("Update_Bill_integration_1", disc3);

            _unitofWork.SaveChanges();
            return true;

        }

        public bool update_AddCharges_integration(BillintegrationParams billintegrationParams)
        {
            var disc3 = billintegrationParams.update_AddCharges_integration.ToDictionary();
            var CommitteeMeetingId = ExecNonQueryProcWithOutSaveChanges("update_AddCharges_integration_1", disc3);

            _unitofWork.SaveChanges();
            return true;

        }

        public bool Update_SeviceExlude(BillintegrationParams billintegrationParams)
        {
            // throw new NotImplementedException();
            var disc3 = billintegrationParams.update_ServiceExclude.ToDictionary();
            var Id = ExecNonQueryProcWithOutSaveChanges("Update_ServieExclude", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
