using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
namespace HIMS.Data.Cardiology
{
    public interface I_CardiacRiskFactor
    {
        public String SaveCardiacRiskFactor(CardiacRiskFactorDetailsParams cardiacRiskFactorDetailsParams);
        public bool UpdateCardiacRiskFactor(CardiacRiskFactorDetailsParams cardiacRiskFactorDetailsParams);
    }
}
