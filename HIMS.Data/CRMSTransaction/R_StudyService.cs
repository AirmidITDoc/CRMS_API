using HIMS.Common.Utility;
using HIMS.Model.CRMSTransaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.CRMSTransaction
{
   public class R_StudyService:GenericRepository,I_StudyService
    {
        public R_StudyService(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool InsertStudyService(StudyServiceParam StudyServiceParam)
        {
            // throw new NotImplementedException();

          /*   var outputId1 = new SqlParameter
           {
               SqlDbType = SqlDbType.BigInt,
               ParameterName = "@StudyServicesId",
               Value = 0,
               Direction = ParameterDirection.Output
           };
          */
            foreach (var a in StudyServiceParam.InsertStudyservice)
            {
               
                var outputId1 = new SqlParameter
                {
                    SqlDbType = SqlDbType.BigInt,
                    ParameterName = "@StudyServicesId",
                    Value = 0,
                    Direction = ParameterDirection.Output
                };

                var disc5 = a.ToDictionary();
                disc5.Remove("StudyServicesId");
                var ID = ExecNonQueryProcWithOutSaveChanges("insert_T_StudyServices", disc5,outputId1);
            }

            _unitofWork.SaveChanges();
            return true;
        }

        public bool UpdateStudyService(StudyServiceParam StudyServiceParam)
        {
            //throw new NotImplementedException();

            var disc3 = StudyServiceParam.DeleteStudyService.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Delete_StudyService", disc3);

            foreach (var a in StudyServiceParam.UpdateStudyservice)
            {
                var disc5 = a.ToDictionary();
                var ID = ExecNonQueryProcWithOutSaveChanges("update_T_StudyServices", disc5);
            }

            _unitofWork.SaveChanges();
            return true;


        }

        public bool UpdateStudyServiceId(StudyServiceParam StudyServiceParam)
        {

            var disc5 = StudyServiceParam.UpdateStudyserviceId.ToDictionary();
            var ChargeID = ExecNonQueryProcWithOutSaveChanges("update_T_StudyServices", disc5);
            _unitofWork.SaveChanges();
            return true;


        }
    }
}
