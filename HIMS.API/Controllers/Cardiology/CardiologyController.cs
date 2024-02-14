using Microsoft.AspNetCore.Mvc;
using HIMS.Model.Cardiology;
using HIMS.Data.Cardiology;

namespace HIMS.API.Controllers.Cardiology
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardiologyController : Controller
    {
       
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public readonly I_PatientInformation _PatientInformation;
        public readonly I_PatientPastHistory _PatientPastHistory;
        public readonly I_CardiacRiskFactor _CardiacRiskFactor;
        public readonly I_IdcadPatientDetails _IdcadPatientDetails;
        public readonly I_ScsPatientDetails _ScsPatientDetails;
        public readonly I_AcsPatientDetails _AcsPatientDetails;
        public readonly I_ProcedureDetails _ProcedureDetails;
        public readonly I_LesionDetails _LesionDetails;

        public CardiologyController(I_PatientInformation patientInformation, 
            I_PatientPastHistory patientPastHistory, I_CardiacRiskFactor cardiacRiskFactor,
            I_IdcadPatientDetails idcadPatientDetails, I_ScsPatientDetails scsPatientDetails,
            I_AcsPatientDetails acsPatientDetails, I_ProcedureDetails procedureDetails, I_LesionDetails lesionDetails)
        {
            _PatientInformation = patientInformation;
            _PatientPastHistory = patientPastHistory;
            _CardiacRiskFactor = cardiacRiskFactor;
            _IdcadPatientDetails = idcadPatientDetails;
            _ScsPatientDetails = scsPatientDetails;
            _AcsPatientDetails = acsPatientDetails;
            _ProcedureDetails = procedureDetails;
            _LesionDetails = lesionDetails;
        }

        [HttpPost("SavePatientInformation")]
        public IActionResult SavePatientInformation(PatientInformationParams patientInformationParams)
        {
            var SSR = _PatientInformation.SavePatientInformation(patientInformationParams);
            return Ok(SSR);
        }

        [HttpPost("UpdatePatientInformation")]
        public IActionResult UpdatePatientInformation(PatientInformationParams patientInformationParams)
        {
            var SSR = _PatientInformation.UpdatePatientInformation(patientInformationParams);
            return Ok(SSR);
        }
        
        [HttpPost("SavePatientPastHistory")]
        public IActionResult SavePatientPastHistory(PatientPastHistoryParams patientPastHistoryParams)
        {
            var SSR = _PatientPastHistory.SavePatientPastHistory(patientPastHistoryParams);
            return Ok(SSR);
        }

        [HttpPost("UpdatePatientPastHistory")]
        public IActionResult UpdatePatientPastHistory(PatientPastHistoryParams patientPastHistoryParams)
        {
            var SSR = _PatientPastHistory.UpdatePatientPastHistory(patientPastHistoryParams);
            return Ok(SSR);
        }

        [HttpPost("SavePatient2DEchoDetails")]
        public IActionResult SavePatient2DEchoDetails(PatientPastHistoryParams patientPastHistoryParams)
        {
            var SSR = _PatientPastHistory.SavePatient2DEchoDetails(patientPastHistoryParams);
            return Ok(SSR);
        }

        [HttpPost("SaveCardiacRiskFactor")]
        public IActionResult SaveCardiacRiskFactor(CardiacRiskFactorDetailsParams cardiacRiskFactorDetailsParams)
        {
            var SSR = _CardiacRiskFactor.SaveCardiacRiskFactor(cardiacRiskFactorDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("UpdateCardiacRiskFactor")]
        public IActionResult UpdateCardiacRiskFactor(CardiacRiskFactorDetailsParams cardiacRiskFactorDetailsParams)
        {
            var SSR = _CardiacRiskFactor.UpdateCardiacRiskFactor(cardiacRiskFactorDetailsParams);
            return Ok(SSR);
        }
        [HttpPost("SaveIdcadPatientDetails")]
        public IActionResult SaveIdcadPatientDetails(IdcadPatientDetailsParams idcadPatientDetailsParams)
        {
            var SSR = _IdcadPatientDetails.SaveIdcadPatientDetails(idcadPatientDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("UpdateIdcadPatientDetails")]
        public IActionResult UpdateIdcadPatientDetails(IdcadPatientDetailsParams idcadPatientDetailsParams)
        {
            var SSR = _IdcadPatientDetails.UpdateIdcadPatientDetails(idcadPatientDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("SaveScsPatientDetails")]
        public IActionResult SaveScsPatientDetails(ScsPatientDetailsParams scsPatientDetailsParams)
        {
            var SSR = _ScsPatientDetails.SaveScsPatientDetails(scsPatientDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("UpdateScsPatientDetails")]
        public IActionResult UpdateScsPatientDetails(ScsPatientDetailsParams scsPatientDetailsParams)
        {
            var SSR = _ScsPatientDetails.UpdateScsPatientDetails(scsPatientDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("SaveAcsPatientDetails")]
        public IActionResult SaveAcsPatientDetails(AcsPatientDetailsParams acsPatientDetailsParams)
        {
            var SSR = _AcsPatientDetails.SaveAcsPatientDetails(acsPatientDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("UpdateAcsPatientDetails")]
        public IActionResult UpdateAcsPatientDetails(AcsPatientDetailsParams acsPatientDetailsParams)
        {
            var SSR = _AcsPatientDetails.UpdateAcsPatientDetails(acsPatientDetailsParams);
            return Ok(SSR);
        }
        [HttpPost("SaveProcedureDetails")]
        public IActionResult SaveProcedureDetails(ProcedureDetailsParams procedureDetailsParams)
        {
            var SSR = _ProcedureDetails.SaveProcedureDetails(procedureDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("UpdateProcedureDetails")]
        public IActionResult UpdateProcedureDetails(ProcedureDetailsParams procedureDetailsParams)
        {
            var SSR = _ProcedureDetails.UpdateProcedureDetails(procedureDetailsParams);
            return Ok(SSR);
        }
        [HttpPost("SaveLesionDetails")]
        public IActionResult SaveLesionDetails(LesionDetailsParams lesionDetailsParams)
        {
            var SSR = _LesionDetails.SaveLesionDetails(lesionDetailsParams);
            return Ok(SSR);
        }

        [HttpPost("UpdateLesionDetails")]
        public IActionResult UpdateLesionDetails(LesionDetailsParams lesionDetailsParams)
        {
            var SSR = _LesionDetails.UpdateLesionDetails(lesionDetailsParams);
            return Ok(SSR);
        }
    }
}
