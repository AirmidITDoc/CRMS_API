using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_Registration :GenericRepository,I_Registration
    {
        public R_Registration(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public String Insert(RegistrationParam RegistrationParam)
        {
            //  throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@RegId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            //Add registration
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@VisitId",
                Value = 0,
                Direction = ParameterDirection.Output
            };


            var dic = RegistrationParam.RegistrationSave.ToDictionary();
            dic.Remove("RegId");
            var RegID = ExecNonQueryProcWithOutSaveChanges("insert_Registration_1", dic, outputId);

            RegistrationParam.VisitSave.RegID = Convert.ToInt64(RegID);
            var dic1 = RegistrationParam.VisitSave.ToDictionary();
            dic1.Remove("VisitId");
            var VisitID = ExecNonQueryProcWithOutSaveChanges("insert_VisitDetails", dic1, outputId1);

            _unitofWork.SaveChanges();

            return (VisitID);
        }

        public bool Update(RegistrationParam RegistrationParam)
        {
                      

            //throw new NotImplementedException();
            var disc1 = RegistrationParam.RegistrationUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_Registration_1", disc1);

     
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
