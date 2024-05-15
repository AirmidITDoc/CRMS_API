using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_Payment:GenericRepository,I_Payment
    {
        public R_Payment(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool PatientServicePayUpdate(PaymentParam PaymentParam)
        {
            // throw new NotImplementedException();

            var disc1 = PaymentParam.PatientServicepayupdate.ToDictionary();
            
            ExecNonQueryProcWithOutSaveChanges("update_paymentforPatientService", disc1);

            _unitofWork.SaveChanges();
            return true;
        }

        public bool Save(PaymentParam PaymentParam)
        {
            //throw new NotImplementedException();


            var outputId3 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@PaymentId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc7 = PaymentParam.OPInsertPayment.ToDictionary();
            disc7.Remove("PaymentId");
            //disc7["BillNo"] = (int)Convert.ToInt64(BillNo);
            ExecNonQueryProcWithOutSaveChanges("insert_Payment_New_1", disc7, outputId3);

            _unitofWork.SaveChanges();
            return true;
        }

       
    }
}
