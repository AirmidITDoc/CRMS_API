using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class CardiacRiskFactorDetailsParams
    {
        public SaveCardiacRiskFactor SaveCardiacRiskFactor { get; set; }
        public UpdateCardiacRiskFactor UpdateCardiacRiskFactor { get; set; }
    }
    public class SaveCardiacRiskFactor
    {
        public long CrfId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public string Hypertension { get; set; }
        public string OnMedication { get; set; }
        public string DrugDetails { get; set; }
        public string CKD { get; set; }
        public string DialysisDependent { get; set; }
        public string T2DInsuline { get; set; }
        public string T2DOral { get; set; }
        public string Smoking { get; set; }
        public string TobaccoChew { get; set; }
        public long DyLDL { get; set; }
        public long DyTriGlyceride { get; set; }
        public long InflDiseases { get; set; }
        public string InflDiseasesOthers { get; set; }
        public float LTHba1c { get; set; }
        public float LTCreatinine { get; set; }
        public float LTHb { get; set; }
        public float LTeGFR { get; set; }
        public string LTIronDeficency { get; set; }
        public string LTVitB12Dif { get; set; }
        public string LTcRP { get; set; }
        public float LTCKMB { get; set; }
        public long CreatedBy { get; set; }
    }
    public class UpdateCardiacRiskFactor
    {
        public string Operation { get; set; }
        public long CrfId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public string Hypertension { get; set; }
        public string OnMedication { get; set; }
        public string DrugDetails { get; set; }
        public string CKD { get; set; }
        public string DialysisDependent { get; set; }
        public string T2DInsuline { get; set; }
        public string T2DOral { get; set; }
        public string Smoking { get; set; }
        public string TobaccoChew { get; set; }
        public long DyLDL { get; set; }
        public long DyTriGlyceride { get; set; }
        public long InflDiseases { get; set; }
        public string InflDiseasesOthers { get; set; }
        public float LTHba1c { get; set; }
        public float LTCreatinine { get; set; }
        public float LTHb { get; set; }
        public float LTeGFR { get; set; }
        public string LTIronDeficency { get; set; }
        public string LTVitB12Dif { get; set; }
        public string LTcRP { get; set; }
        public float LTCKMB { get; set; }
        public long UpdatedBy { get; set; }
    }

}
