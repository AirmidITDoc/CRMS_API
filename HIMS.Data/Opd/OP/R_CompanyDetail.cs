using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_CompanyDetail:GenericRepository,I_CompanyDetail
    {

        public R_CompanyDetail(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Save(CompanyDetail CompanyDetail)
        {
            // throw new NotImplementedException();

            var CompanyId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@CompanyId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc1 = CompanyDetail.CompanyInsert.ToDictionary();
            disc1.Remove("CompanyId");
            var Id = ExecNonQueryProcWithOutSaveChanges("insert_CompanyDetails", disc1, CompanyId1);

            //commit transaction
            _unitofWork.SaveChanges();
            return Id;
        }

        public bool Update(CompanyDetail CompanyDetail)
        {
            // throw new NotImplementedException();

            var disc1 = CompanyDetail.CompanyUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Update_CompanyDetails", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
