using HIMS.Common.Utility;
using HIMS.Model.CRMSTransaction;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HIMS.Data.CRMSTransaction
{
    public class R_StudySchedule : GenericRepository, I_StudySchedule
    {
        public R_StudySchedule(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
        public bool InsertStudySchedule(StudyScheduleParams _studyScheduleParams)
        {
            //throw new NotImplementedException();
           /* var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@StudyVisitId",
                Value = 0,
                Direction = ParameterDirection.Output
            };*/

            foreach (var a in _studyScheduleParams.InsertStudySchedule)
            {
                var disc5 = a.ToDictionary();
                disc5.Remove("StudyVisitId");
                var ChargeID = ExecNonQueryProcWithOutSaveChanges("insert_StudySchedule", disc5);
            }

            _unitofWork.SaveChanges();
            return true;
        }

        public bool UpdateStudySchedule(StudyScheduleParams _studyScheduleParams)
        {
            //throw new NotImplementedException();

            var disc3 = _studyScheduleParams.UpdateStudySchedule.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("Update_StudySchedule", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
