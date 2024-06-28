using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSTransaction
{
    public class BillintegrationParams
    {
        public Update_Bill_integration Update_Bill_integration { get; set; }
        public update_AddCharges_integration update_AddCharges_integration { get; set; }

        public update_ServiceExclude update_ServiceExclude { get; set; }
    }

    public class Update_Bill_integration
    {
        public int BillId { get; set; }
        public int IndBillId { get; set; }
        public string IndBillNo { get; set; }
        public DateTime IndBillDate { get; set; }
        public float IndBillAmount { get; set; }
    }

    public class update_AddCharges_integration
    {
        public int ChargesId { get; set; }
        public int IndBillId { get; set; }
        public int IndChargeId { get; set; }
        public int IndServiceId { get; set; }
        public string IndServiceName { get; set; }
        public float IndServiceAmount { get; set; }
    }

    public class update_ServiceExclude
    {
        public int ChargesId { get; set; }

        public int BillNo { get; set; }


    }
}

