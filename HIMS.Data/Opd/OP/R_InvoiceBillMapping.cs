using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Opd.OP
{
    public class R_InvoiceBillMapping : GenericRepository, I_InvoiceBillMapping
    {

        public R_InvoiceBillMapping(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
        public string Insert(InvoiceDetailParam InvoiceDetailParam)
        {
            //  throw new NotImplementedException();

            var InvoiceId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@InvoiceId",
                Value = 0,
                Direction = ParameterDirection.Output
            };


            var disc3 = InvoiceDetailParam.InsertInvoiceDetail.ToDictionary();
            disc3.Remove("InvoiceId");
            var InvoiceId = ExecNonQueryProcWithOutSaveChanges("insert_InvoiceDetails", disc3, InvoiceId1);

            foreach (var a in InvoiceDetailParam.InsertInvoiceBillDetail) {
                var disc5 = a.ToDictionary();
                disc5["InvoiceId"] = InvoiceId;
                ExecNonQueryProcWithOutSaveChanges("insert_InvoiceBillDetails", disc5);
            }

            foreach (var a in InvoiceDetailParam.UpdatebillInvoice)
            {
                var disc5 = a.ToDictionary();
                disc5["InvoiceId"] = InvoiceId;
                ExecNonQueryProcWithOutSaveChanges("Upt_Bill_IsInvoice_1", disc5);
            }


            _unitofWork.SaveChanges();
            return InvoiceId;
        }

        public bool Update(InvoiceDetailParam InvoiceDetailParam)
        {
            // throw new NotImplementedException();


            var disc5 = InvoiceDetailParam.UpdateInvoiceDetail.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Update_InvoiceDetails", disc5);

            foreach (var a in InvoiceDetailParam.UpdateInvoiceBillDetail)
            {
                var disc6 = a.ToDictionary();
                disc6["InvoiceId"] = InvoiceDetailParam.UpdateInvoiceDetail.InvoiceId;
                ExecNonQueryProcWithOutSaveChanges("Update_InvoiceBillMapping", disc6);
            }
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
