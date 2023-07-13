using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSTransaction;
using HIMS.Data.CRMSTransaction;
using System.Data.SqlClient;
using System.Data;
using HIMS.Common.Utility;

namespace HIMS.Data.CRMSTransaction
{
    public class R_CommitteeMeeting : GenericRepository, I_CommitteeMeeting
    {
        public R_CommitteeMeeting(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public String InsertCommitteeMeeting(CommitteeMeetingParams committeeMeetingParams)
        {
            //throw new NotImplementedException();
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@CommitteeMeetingId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = committeeMeetingParams.InsertCommitteeMeeting.ToDictionary();
            disc3.Remove("CommitteeMeetingId");
            var CommitteeMeetingId = ExecNonQueryProcWithOutSaveChanges("insert_T_CommitteeMeeting", disc3, outputId1);

            foreach (var a in committeeMeetingParams.InsertCommitteeMeetingMemberDet)
            {
                var disc5 = a.ToDictionary();
                disc5["CommitteeMeetingId"] = CommitteeMeetingId;
                ExecNonQueryProcWithOutSaveChanges("insert_T_CommitteeMeetingMemberDet", disc5);
            }

            _unitofWork.SaveChanges();
            return CommitteeMeetingId;

        }
    }
}
