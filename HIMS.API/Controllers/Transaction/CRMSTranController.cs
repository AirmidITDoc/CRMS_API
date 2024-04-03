using Microsoft.AspNetCore.Mvc;
using HIMS.Model.CRMSTransaction;
using HIMS.Data.CRMSTransaction;

namespace HIMS.API.Controllers.Transaction
{
    [ApiController]
    [Route("api/[controller]")]
    public class CRMSTranController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public readonly I_StudyInformation _StudyInformation;
        public readonly I_StudyUploadDocument _StudyUploadDocument;
        public readonly I_StudySchedule _StudySchedule;

        public readonly I_CommitteeMeeting _CommitteeMeeting;
        public readonly I_StudyService _StudyService;
        public readonly I_Billintegration _Billintegration;
        public CRMSTranController(I_StudyInformation studyInformation, I_StudyUploadDocument studyUploadDocument, I_StudySchedule studySchedule, I_CommitteeMeeting committeeMeeting,
            I_StudyService studyService, I_Billintegration billintegration)
        {
            _StudyInformation = studyInformation;
            _StudyUploadDocument = studyUploadDocument;
            _StudySchedule = studySchedule;
            _CommitteeMeeting = committeeMeeting;
            _StudyService = studyService;
            _Billintegration = billintegration;
        }

        [HttpPost("Save_StudyInformation")]
        public IActionResult Save_studyInformation(StudyInformationParams studyInformation)
        {
            var SSR = _StudyInformation.InsertStudyInformation(studyInformation);
            return Ok(SSR);
        }

        [HttpPost("Update_StudyInformation")]
        //[HttpPut("{id:int}")]
        public IActionResult Update_studyInformation(StudyInformationParams studyInformation)
        {
            var SSR = _StudyInformation.UpdateStudyInformation(studyInformation);
            return Ok(SSR);
        }

        [HttpPost("Save_StudyUploadDocument")]
        public IActionResult Save_StudyUploadDocument(StudyUploadDocumentParams studyUploadDocumentParams)
        {
            var SSR = _StudyUploadDocument.InsertStudyUploadDocument(studyUploadDocumentParams);
            return Ok(SSR);
        }

        [HttpPost("Update_StudyUploadDocument")]
        //[HttpPut("{id:int}")]
        public IActionResult Update_StudyUploadDocument(StudyUploadDocumentParams studyUploadDocumentParams)
        {
            var SSR = _StudyUploadDocument.UpdateStudyUploadDocument(studyUploadDocumentParams);
            return Ok(SSR);
        }

        [HttpPost("Save_InsertStudySchedule")]
        public IActionResult Save_InsertStudySchedule(StudyScheduleParams studyScheduleParams)
        {
            var SSR = _StudySchedule.InsertStudySchedule(studyScheduleParams);
            return Ok(SSR);
        }

        [HttpPost("Update_UpdateStudySchedule")]
        //[HttpPut("{id:int}")]
        public IActionResult Update_UpdateStudySchedule(StudyScheduleParams studyScheduleParams)
        {
            var SSR = _StudySchedule.UpdateStudySchedule(studyScheduleParams);
            return Ok(SSR);
        }

        [HttpPost("Update_UpdateStudyScheduleId")]
        public IActionResult Update_UpdateStudyScheduleId(StudyScheduleParams studyScheduleParams)
        {
            var SSR = _StudySchedule.UpdateStudyScheduleId(studyScheduleParams);
            return Ok(SSR);
        }

        [HttpPost("Save_InsertCommitteeMaster")]
        public IActionResult Save_InsertCommitteeMaster(CommitteeMeetingParams committeeMeetingParams)
        {
            var SSR = _CommitteeMeeting.InsertCommitteeMeeting(committeeMeetingParams);
            return Ok(SSR);
        }

        [HttpPost("Update_InsertCommitteeMaster")]
        public IActionResult Update_InsertCommitteeMaster(CommitteeMeetingParams committeeMeetingParams)
        {
            var SSR = _CommitteeMeeting.InsertCommitteeMeeting(committeeMeetingParams);
            return Ok(SSR);
        }

        [HttpPost("Save_InsertStudyService")]
        public IActionResult Save_InsertStudyService(StudyServiceParam StudyServiceParam)
        {
            var SSR = _StudyService.InsertStudyService(StudyServiceParam);
            return Ok(SSR);
        }

        [HttpPost("Update_UpdateStudyService")]
        public IActionResult Update_UpdateStudyService(StudyServiceParam StudyServiceParam)
        {
            var SSR = _StudyService.UpdateStudyService(StudyServiceParam);
            return Ok(SSR);
        }

        [HttpPost("Update_Bill_integration")]
        public IActionResult Update_Bill_integration(BillintegrationParams billintegrationParams)
        {
            var SSR = _Billintegration.Update_Bill_integration(billintegrationParams);
            return Ok(SSR); 
        }

        [HttpPost("update_AddCharges_integration")]
        public IActionResult update_AddCharges_integration(BillintegrationParams billintegrationParams)
        {
            var SSR = _Billintegration.update_AddCharges_integration(billintegrationParams);
            return Ok(SSR); 
        }
    }
}
