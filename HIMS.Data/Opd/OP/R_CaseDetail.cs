using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_CaseDetail :GenericRepository,I_CaseDetail
    {
        public R_CaseDetail(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Insert(CaseDetail CaseDetail)
        {
            //  throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@CaseId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = CaseDetail.InsertCaseDetail.ToDictionary();
            disc3.Remove("CaseId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_CaseDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool Update(CaseDetail CaseDetail)
        {
            //throw new NotImplementedException();


            var disc3 = CaseDetail.UpdateCaseDetail.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("Update_Casedetail", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
