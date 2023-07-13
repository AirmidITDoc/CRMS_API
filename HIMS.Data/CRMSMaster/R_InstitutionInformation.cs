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
    public class R_InstitutionInformation : GenericRepository, I_InstitutionInformation
    {
        public R_InstitutionInformation(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
        public string InsertInstitutionInformation(InstitutionInformationParams _institutionInformationParams)
        {
            //  throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@InstitutionId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _institutionInformationParams.InsertInstitutionInformation.ToDictionary();
            disc3.Remove("InstitutionId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_M_InstitutionInformation_1", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateInstitutionInformation(InstitutionInformationParams _institutionInformationParams)
        {
            //throw new NotImplementedException();

            var disc3 = _institutionInformationParams.UpdateInstitutionInformation.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("Update_M_InstitutionInformation_1", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
