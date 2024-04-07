using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_Bill:GenericRepository,I_Bill
    {
        public R_Bill(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public String Insert(BillParam BillParam)
        {
            //throw new NotImplementedException();
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@BillNo",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var outputId2 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@BillDetailId",
                Value = 0,
                Direction = ParameterDirection.Output
            };


            var VarChargeID = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ChargeID",
                Value = 0,
                Direction = ParameterDirection.Output
            };


            var disc3 = BillParam.InsertBillupdatewithbillno.ToDictionary();
            disc3.Remove("BillNo");
            var BillNo = ExecNonQueryProcWithOutSaveChanges("insert_Bill_UpdateWithBillNo_1_New", disc3, outputId1);

            foreach (var a in BillParam.ChargesDetailInsert)
             {
                 var disc5 = a.ToDictionary();
                 disc5["BillNo"] = BillNo;
                 disc5.Remove("ChargeID");
                var ChargeID = ExecNonQueryProcWithOutSaveChanges("insert_IPAddCharges_1", disc5, VarChargeID);

                // Dill Detail Table Insert 
                Dictionary<string, Object> OPBillDet = new Dictionary<string, object>();
                OPBillDet.Add("BillNo", BillNo);
                OPBillDet.Add("ChargesID", ChargeID);
                ExecNonQueryProcWithOutSaveChanges("insert_BillDetails_1", OPBillDet);

            }

            _unitofWork.SaveChanges();
            return BillNo;

        }

      
    }
}
