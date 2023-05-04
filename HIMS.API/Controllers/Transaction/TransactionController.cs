using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HIMS.Data.Transaction;
using HIMS.Model.Transaction;


namespace HIMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
       
        public readonly I_IssueTracking_Sw _IssueTracking_Sw;
        public readonly I_ProjectInformation _ProjectInformation;
        public readonly I_Sw_Bill_info _Sw_Bill_Info;

        public TransactionController(
                         I_IssueTracking_Sw issueTracking_Sw,
                         I_ProjectInformation projectInformation,
                         I_Sw_Bill_info sw_Bill_Info
                         )
        {
          
            this._IssueTracking_Sw = issueTracking_Sw;
            this._ProjectInformation = projectInformation;
            this._Sw_Bill_Info = sw_Bill_Info;
        }



        [HttpPost("IssueTracking_SwSave")]
            
        public IActionResult IssueTracking_SwSave(IssueTracking_SwParams IssueTracking_SwParams)
        {
            var issu = _IssueTracking_Sw.Save(IssueTracking_SwParams);

            return Ok(issu);
        }
        [HttpPost("IssueTracking_SwUpdate")]

        public IActionResult IssueTracking_SwUpdate(IssueTracking_SwParams IssueTracking_SwParams)
        {
            var issu = _IssueTracking_Sw.Update(IssueTracking_SwParams);

            return Ok(issu);
        }

        //ProjectInformation Save And Update
        [HttpPost("ProjectInformationSave")]

        public IActionResult ProjectInformationSave(ProjectInformationParams ProjectInformationParams)
        {
            var pinfo = _ProjectInformation.Save(ProjectInformationParams);

            return Ok(pinfo);
        }
        [HttpPost("ProjectInformationUpdate")]

        public IActionResult ProjectInformationUpdate(ProjectInformationParams ProjectInformationParams)
        {
            var pinfo = _ProjectInformation.Update(ProjectInformationParams);

            return Ok(pinfo);
        }


        //I_Sw_Bill_info Save And Update
        [HttpPost("I_Sw_Bill_infoSave")]

        public IActionResult I_Sw_Bill_infoSave(Sw_Bill_infoParams Sw_Bill_infoParams)
        {
            var pinfo = _Sw_Bill_Info.Save(Sw_Bill_infoParams);

            return Ok(pinfo);
        }
        [HttpPost("I_Sw_Bill_infoUpdate")]
        public IActionResult I_Sw_Bill_infoUpdate(Sw_Bill_infoParams Sw_Bill_infoParams)
        {
            var pinfo = _Sw_Bill_Info.Update(Sw_Bill_infoParams);

            return Ok(pinfo);
        }
    }
    } 