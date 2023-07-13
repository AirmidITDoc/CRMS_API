using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using HIMS.Common.Utility;
using HIMS.Model.CRMSMaster;

namespace HIMS.Data.CRMSMaster
{
    public class R_SponserInformation : GenericRepository, I_SponserInformation
    {
        public R_SponserInformation(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string InsertSponserInformation(SponserInformationParams _SponserInformationParams)
        {
            //  throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@SponserId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _SponserInformationParams.InsertSponserInformation.ToDictionary();
            disc3.Remove("SponserId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_M_SponserInformation_1", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateSponserInformation(SponserInformationParams _SponserInformationParams)
        {
            //throw new NotImplementedException();

            var disc3 = _SponserInformationParams.UpdateSponserInformation.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("Update_M_SponserInformation_1", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
