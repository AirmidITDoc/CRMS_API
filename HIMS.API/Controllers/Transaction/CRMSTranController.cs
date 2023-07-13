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

        public CRMSTranController(I_StudyInformation studyInformation, I_StudyUploadDocument studyUploadDocument, I_StudySchedule studySchedule, I_CommitteeMeeting committeeMeeting)
        {
            _StudyInformation = studyInformation;
            _StudyUploadDocument = studyUploadDocument;
            _StudySchedule = studySchedule;
            _CommitteeMeeting = committeeMeeting;
        }

        [HttpPost("Save_StudyInformation")]
        public IActionResult Save_studyInformation(StudyInformationParams studyInformation)
        {
            var SSR = _StudyInformation.InsertStudyInformation(studyInformation);
            return Ok(SSR);
        }

        [HttpPut("Update_StudyInformation")]
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

        [HttpPut("Update_StudyUploadDocument")]
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

        [HttpPut("Update_UpdateStudySchedule")]
        //[HttpPut("{id:int}")]
        public IActionResult Update_UpdateStudySchedule(StudyScheduleParams studyScheduleParams)
        {
            var SSR = _StudySchedule.UpdateStudySchedule(studyScheduleParams);
            return Ok(SSR);
        }

        [HttpPost("Save_InsertCommitteeMaster")]
        public IActionResult Save_InsertCommitteeMaster(CommitteeMeetingParams committeeMeetingParams)
        {
            var SSR = _CommitteeMeeting.InsertCommitteeMeeting(committeeMeetingParams);
            return Ok(SSR);
        }
    }
}
