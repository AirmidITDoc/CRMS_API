using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HIMS.Data;
using HIMS.Data.Master;

using HIMS.Model;
using HIMS.Model.Master;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HIMS.API.Controllers.Master
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterController : ControllerBase
    {

        public readonly I_MenuMaster _MenuMaster;
        public readonly I_MenuMasterDetails _MenuMasterDetails;
        public readonly I_MenuMasterDetails_Details _MenuMasterDetails_Details;

        public MasterController(I_MenuMaster menuMaster,
            
            I_MenuMasterDetails menuMasterDetails,I_MenuMasterDetails_Details menuMasterDetails_Details
            )
        {
           
            this._MenuMaster = menuMaster;
            this._MenuMasterDetails = menuMasterDetails;
            this._MenuMasterDetails_Details = menuMasterDetails_Details;
           
        }

        /* [HttpPost("ServiceSave")]
          public IActionResult ServiceSave(ServiceMasterParams  serviceMasterParams)
          {
              var ServiceSave = _ServiceMasterResp.Save(serviceMasterParams);
              return Ok(ServiceSave);
          }

          [HttpPost("ServiceUpdate")]
          public IActionResult ServiceUpdate(ServiceMasterParams serviceMasterParams)
          {
              var ServiceSave = _ServiceMasterResp.Update(serviceMasterParams);
              return Ok(ServiceSave);
          }

          [HttpPost("DoctorSave")]
          public IActionResult DoctorSave(DoctorMasterParams1 DoctorMasterParams1)
          {
              var ServiceSave = _DoctorMasterResp.Save(DoctorMasterParams1);
              return Ok(ServiceSave);
          }

          [HttpPost("DoctorUpdate")]
          public IActionResult DoctorUpdate(DoctorMasterParams1 DoctorMasterParams1)
          {
              var ServiceSave = _DoctorMasterResp.Update(DoctorMasterParams1);
              return Ok(ServiceSave);
          }

        // MenuMaster Master Insert & Update
        [HttpPost("MenuMasterSave")]
        public IActionResult MenuMasterSave(MenuMasterParamsHome menuMasterParams)
        {
            var menuMaster = _MenuMaster.Save(menuMasterParams);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("MenuMasterUpdate")]
        public IActionResult MenuMasterUpdate(MenuMasterParamsHome menuMasterParams)
        {
            var menuMaster = _MenuMaster.Update(menuMasterParams);
            return Ok(menuMaster);
        }*/
     
      

    }
}
