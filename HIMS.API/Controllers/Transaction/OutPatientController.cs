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
        public readonly I_Department _Department;
        public readonly I_DepartmentType _DepartmentType;
        public readonly I_Registration _Registration;
        public readonly I_Bill _Bill;
        public readonly I_CaseDetail _Case_Detail;


        public OutPatientController(
         
            //I_Dashboard Dashboard,
           I_DynamicExecuteSchedule dynamicExecuteSchedule,
           I_Configsetting configsetting,I_Department department,I_DepartmentType departmentType,I_Registration registration,I_Bill bill, I_CaseDetail caseDetail
            )
       {
             
       
         //   this.i_SS_RoleTemplate = roleTemplateMaster;
            this._DynamicExecuteSchedule = dynamicExecuteSchedule;
            this._Configsetting = configsetting;
            this._Department = department;
            this._DepartmentType = departmentType;
            this._Registration = registration;
            this._Bill = bill;
            this._Case_Detail = caseDetail;
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


        //Department
        [HttpPut("DepartmentInsert")]
        public IActionResult DepartmentInsert(DepartmentParam DepartmentParam)
        {
            var Id = _Department.Insert(DepartmentParam);
            return Ok(Id);
        }


        //
        [HttpPut("DepartmentUpdate")]
        public IActionResult UpdateConfigSetting(DepartmentParam DepartmentParam)
        {
            var SSR = _Department.Update(DepartmentParam);
            return Ok(SSR);
        }


        //DocDepatType
        [HttpPut("DocDeparttmentTypeInsert")]
        public IActionResult DocDeparttmentTypeInsert(DepartmentTypeParam DepartmentTypeParam)
        {
            var SSR = _DepartmentType.Insert(DepartmentTypeParam);
            return Ok(SSR);
        }


        //
        [HttpPut("DocDeparttmentTypeUpdate")]
        public IActionResult DocDeparttmentTypeUpdate(DepartmentTypeParam DepartmentTypeParam)
        {
            var SSR = _DepartmentType.Update(DepartmentTypeParam);
            return Ok(SSR);
        }


        //Registration
        [HttpPut("RegistrationInsert")]
        public IActionResult Registration(RegistrationParam RegistrationParam)
        {
            var SSR = _Registration.Insert(RegistrationParam);
            return Ok(SSR);
        }


        //
        [HttpPut("RegistrationUpdate")]
        public IActionResult RegistrationUpdate(RegistrationParam RegistrationParam)
        {
            var SSR = _Registration.Update(RegistrationParam);
            return Ok(SSR);
        }

        //Bill
        [HttpPut("BillInsert")]
        public IActionResult BillInsert(BillParam BillParam)
        {
            var SSR = _Bill.Insert(BillParam);
            return Ok(SSR);
        }


        // CaseDetail Master Insert & Update
        [HttpPost("CaseDetailSave")]
        public IActionResult CaseDetailSave(CaseDetail CaseDetail)
        {
            var menuMaster = _Case_Detail.Insert(CaseDetail);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

    }

}
