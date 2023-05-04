using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HIMS.Data.Opd;
using HIMS.Model.Opd;
using HIMS.Model.Transaction;
using HIMS.Data.Opd.OP;
using HIMS.Model.Opd.OP;


namespace HIMS.API.Controllers.Transaction
{

    [ApiController]
    [Route("api/[controller]")]
    public class OutPatientController : Controller
    {
        /* public IActionResult Index()
         {
             return View();
         }*/

    
        public readonly I_SS_RoleTemplateMaster i_SS_RoleTemplate;
        
        public readonly I_DynamicExecuteSchedule _DynamicExecuteSchedule;
        public readonly I_Configsetting _Configsetting;

        


        public OutPatientController(
         
            //I_Dashboard Dashboard,
           I_DynamicExecuteSchedule dynamicExecuteSchedule,
           I_Configsetting configsetting
            )
       {
             
       
         //   this.i_SS_RoleTemplate = roleTemplateMaster;
            this._DynamicExecuteSchedule = dynamicExecuteSchedule;
            this._Configsetting = configsetting;
            
        }

        //SS_RoleTemplateMaster
        [HttpPost("OP_SS_RoleTemplateMasterSave")]
        public IActionResult OP_SS_RoleTemplateMasterSave(SS_RoleTemplateMasterParams SS_RoleTemplateMasterParams)
        {
            var SSR = i_SS_RoleTemplate.Save(SS_RoleTemplateMasterParams);
            return Ok(SSR);
        }

        [HttpPost("OP_SS_RoleTemplateMasterUpdate")]
        public IActionResult OP_SS_RoleTemplateMasterUpdate(SS_RoleTemplateMasterParams SS_RoleTemplateMasterParams)
        {
            var SSR = i_SS_RoleTemplate.Update(SS_RoleTemplateMasterParams);
            return Ok(SSR);
        }
     

        //EmainConfiguration
        [HttpPost("InsertDynamicExecuteSchedule")]
        public IActionResult InsertDynamicExecuteSchedule(DynamicExecuteScheduleparam DynamicExecuteScheduleparam)
        {
            var SSR = _DynamicExecuteSchedule.Insert(DynamicExecuteScheduleparam);
            return Ok(SSR);
        }
        //EmainConfiguration
        [HttpPost("UpdateDynamicExecuteSchedule")]
        public IActionResult UpdateDynamicExecuteSchedule(DynamicExecuteScheduleparam DynamicExecuteScheduleparam)
        {
            var SSR = _DynamicExecuteSchedule.Update(DynamicExecuteScheduleparam);
            return Ok(SSR);
        }

        //ConfigurationSetting
        [HttpPut("UpdateConfigSetting")]
        public IActionResult UpdateConfigSetting(ConfigSettingparam ConfigSettingparam)
        {
            var SSR = _Configsetting.Update(ConfigSettingparam);
            return Ok(SSR);
        }

       

    }

}
