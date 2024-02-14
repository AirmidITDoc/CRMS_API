using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
using HIMS.Data.Cardiology;
using System.Data.SqlClient;
using System.Data;
using HIMS.Common.Utility;

namespace HIMS.Data.Cardiology
{
    public class R_CardiacRiskFactor : GenericRepository, I_CardiacRiskFactor
    {
        public R_CardiacRiskFactor(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string SaveCardiacRiskFactor(CardiacRiskFactorDetailsParams _cardiacRiskFactorDetailsParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@CrfId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _cardiacRiskFactorDetailsParams.SaveCardiacRiskFactor.ToDictionary();
            disc3.Remove("CrfId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_CardiacRiskFactorDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateCardiacRiskFactor(CardiacRiskFactorDetailsParams _cardiacRiskFactorDetailsParams)
        {
            var disc3 = _cardiacRiskFactorDetailsParams.UpdateCardiacRiskFactor.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_CardiacRiskFactorDetails", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
