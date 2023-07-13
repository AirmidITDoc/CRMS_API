using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSMaster;
using HIMS.Data.CRMSMaster;
using System.Data.SqlClient;
using System.Data;
using HIMS.Common.Utility;

namespace HIMS.Data.CRMSMaster
{
    public class R_CommitteeMaster : GenericRepository, I_CommitteeMaster
    {
        public R_CommitteeMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public String InsertCommitteeMaster(CommitteeMasterParams committeeMasterParams)
        {
            //throw new NotImplementedException();
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@CommitteeId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = committeeMasterParams.InsertCommitteeMaster.ToDictionary();
            disc3.Remove("CommitteeId");
            var CommitteeId = ExecNonQueryProcWithOutSaveChanges("insert_CommitteeMaster", disc3, outputId1);

            foreach (var a in committeeMasterParams.InsertCommitteeMemberDetails)
            {
                // Dill Detail Table Insert 
                Dictionary<string, Object> CommitteeMemDet = new Dictionary<string, object>();
                CommitteeMemDet.Add("CommitteeId", CommitteeId);
                CommitteeMemDet.Add("MemberId", a.MemberId );
                CommitteeMemDet.Add("CreatedBy", a.CreatedBy);
                ExecNonQueryProcWithOutSaveChanges("insert_CommitteeMemberDetails", CommitteeMemDet);

            }

            _unitofWork.SaveChanges();
            return CommitteeId;

        }
    }
}
