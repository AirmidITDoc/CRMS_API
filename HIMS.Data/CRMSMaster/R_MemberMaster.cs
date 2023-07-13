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
    public class R_MemberMaster : GenericRepository, I_MemberMaster
    {
        public R_MemberMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string InsertMemberMaster(MemberMasterParams _memberMasterParams)
        {
            //  throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@MemberId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _memberMasterParams.InsertMemberMaster.ToDictionary();
            disc3.Remove("MemberId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_MemberMaster", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateMemberMaster(MemberMasterParams _memberMasterParams)
        {
            //throw new NotImplementedException();

            var disc3 = _memberMasterParams.UpdateMemberMaster.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("Update_MemberMaster", disc3);

            _unitofWork.SaveChanges();
            return true;
        }

    }
}
