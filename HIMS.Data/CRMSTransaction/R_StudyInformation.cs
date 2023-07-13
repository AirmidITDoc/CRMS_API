using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSTransaction;
using HIMS.Common.Utility;
using System.Data.SqlClient;
using System.Data;

namespace HIMS.Data.CRMSTransaction
{
    public class R_StudyInformation : GenericRepository, I_StudyInformation
    {
        public R_StudyInformation(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
        public string InsertStudyInformation(StudyInformationParams _StudyInformation)
        {
            //  throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@StudyId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _StudyInformation.InsertStudyInformation.ToDictionary();
            disc3.Remove("StudyId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_StudyInformation", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateStudyInformation(StudyInformationParams _StudyInformation)
        {
            //throw new NotImplementedException();

            var disc3 = _StudyInformation.UpdateStudyInformation.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("Update_StudyInformation", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
