using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSTransaction;

namespace HIMS.Data.CRMSTransaction
{
    public interface I_Billintegration
    {
        public bool Update_Bill_integration(BillintegrationParams billintegrationParams);
        public bool update_AddCharges_integration(BillintegrationParams billintegrationParams);
    }
}
