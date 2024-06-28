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
using HIMS.Data.Master;
using HIMS.Model.Master;

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
        public readonly I_ClassMaster _ClassMaster;
        public readonly I_ConcessionReasion _ConcessionReasion;
        public readonly I_ServiceMaster _ServiceMaster;
        public readonly I_Payment _Payment;
        public readonly I_VisitMaster _VisitMaster;
        public readonly I_CompanyDetail _CompanyDetail;
        public readonly I_InvoiceBillMapping _InvoiceBillMapping;
        public readonly I_InvoiceUpdateRegNo _InvoiceUpdateRegNo;
        public OutPatientController(
         
            //I_Dashboard Dashboard,
           I_DynamicExecuteSchedule dynamicExecuteSchedule,
           I_Configsetting configsetting,I_Department department,I_DepartmentType departmentType,I_Registration registration,I_Bill bill, I_CaseDetail caseDetail
         ,I_ClassMaster classMaster,I_ConcessionReasion concessionReasion, I_ServiceMaster serviceMaster,I_Payment payment,I_VisitMaster visitMaster,
           I_CompanyDetail companyDetail,I_InvoiceBillMapping invoiceBillMapping,I_InvoiceUpdateRegNo invoiceUpdateRegNo
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
            this._ClassMaster = classMaster;
            this._ConcessionReasion = concessionReasion;
            this._ServiceMaster = serviceMaster;
            this._Payment = payment;
            this._VisitMaster = visitMaster;

            this._CompanyDetail = companyDetail;
            this._InvoiceBillMapping = invoiceBillMapping;
            this._InvoiceUpdateRegNo = invoiceUpdateRegNo;
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
        [HttpPost("DepartmentInsert")]
        public IActionResult DepartmentInsert(DepartmentParam DepartmentParam)
        {
            var Id = _Department.Insert(DepartmentParam);
            return Ok(Id);
        }


        //
        [HttpPost("DepartmentUpdate")]
        public IActionResult UpdateConfigSetting(DepartmentParam DepartmentParam)
        {
            var SSR = _Department.Update(DepartmentParam);
            return Ok(SSR);
        }


        //DocDepatType
        [HttpPost("DocDeparttmentTypeInsert")]
        public IActionResult DocDeparttmentTypeInsert(DepartmentTypeParam DepartmentTypeParam)
        {
            var SSR = _DepartmentType.Insert(DepartmentTypeParam);
            return Ok(SSR);
        }


        //
        [HttpPost("DocDeparttmentTypeUpdate")]
        public IActionResult DocDeparttmentTypeUpdate(DepartmentTypeParam DepartmentTypeParam)
        {
            var SSR = _DepartmentType.Update(DepartmentTypeParam);
            return Ok(SSR);
        }


        //Registration
        [HttpPost("RegistrationInsert")]
        public IActionResult Registration(RegistrationParam RegistrationParam)
        {
            var SSR = _Registration.Insert(RegistrationParam);
            return Ok(SSR);
        }


        //
        [HttpPost("RegistrationUpdate")]
        public IActionResult RegistrationUpdate(RegistrationParam RegistrationParam)
        {
            var SSR = _Registration.Update(RegistrationParam);
            return Ok(SSR);
        }

        //Bill
        [HttpPost("BillInsert")]
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

        [HttpPost("CaseDetailUpdate")]
        public IActionResult CaseDetailUpdate(CaseDetail CaseDetail)
        {
            var menuMaster = _Case_Detail.Update(CaseDetail);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

        // Class Master Insert & Update
        [HttpPost("ClassSave")]
        public IActionResult ClassSave(Classparam Classparam)
        {
            var menuMaster = _ClassMaster.Save(Classparam);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("ClassUpdate")]
        public IActionResult ClassUpdate(Classparam Classparam)
        {
            var menuMaster = _ClassMaster.Update(Classparam);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

        // Concession Master Insert & Update
        [HttpPost("ConcessionSave")]
        public IActionResult ConcessionSave(ConcessionReasionParam ConcessionReasionParam)
        {
            var menuMaster = _ConcessionReasion.Save(ConcessionReasionParam);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("ConcessionUpdate")]
        public IActionResult ConcessionUpdate(ConcessionReasionParam ConcessionReasionParam)
        {
            var menuMaster = _ConcessionReasion.Update(ConcessionReasionParam);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }


/*
        // Service Master Insert & Update
        [HttpPost("ServiceSave")]
        public IActionResult ServiceSave(ServiceMasterParam ServiceMasterParam)
        {
            var menuMaster = _ServiceMaster.Save(ServiceMasterParam);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("ServiceUpdate")]
        public IActionResult ServiceUpdate(ServiceMasterParam ServiceMasterParam)
        {
            var menuMaster = _ServiceMaster.Update(ServiceMasterParam);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }
*/

        // Payment Master Insert & Update
        [HttpPost("PaymentSave")]
        public IActionResult PaymentSave(PaymentParam PaymentParam)
        {
            var menuMaster = _Payment.Save(PaymentParam);
            
            return Ok(menuMaster);
        }

        // Visit Insert & Update
        [HttpPost("VisitAddSave")]
        public IActionResult VisitAddSave(VisitMasterParam VisitMasterParam)
        {
            var menuMaster = _VisitMaster.Save(VisitMasterParam);

            return Ok(menuMaster);
        }

        [HttpPost("VisitUpdate")]
        public IActionResult VisitUpdate(VisitMasterParam VisitMasterParam)
        {
            var menuMaster = _VisitMaster.Update(VisitMasterParam);
                        return Ok(menuMaster);
        }

        [HttpPost("StopScreeningUpdate")]
        public IActionResult StopscreeningUpdate(InvoiceDetailParam InvoiceDetailParam)
        {
            var menuMaster = _InvoiceBillMapping.UpdateStoScreening(InvoiceDetailParam);
            return Ok(menuMaster);
        }

        // CompanyDetail Insert & Update
        [HttpPost("CompanyDetailSave")]
        public IActionResult CompanyDetailSave(CompanyDetail CompanyDetail)
        {
            var menuMaster = _CompanyDetail.Save(CompanyDetail);

            return Ok(menuMaster);
        }

        [HttpPost("CompanyDetailUpdate")]
        public IActionResult CompanyDetailUpdate(CompanyDetail CompanyDetail)
        {
            var menuMaster = _CompanyDetail.Update(CompanyDetail);
            return Ok(menuMaster);
        }



        // InvoiceBillMappinng Insert & Update
        [HttpPost("InvoiceBillMappinngSave")]
        public IActionResult InvoiceBillMappinngSave(InvoiceDetailParam InvoiceDetailParam)
        {
            var menuMaster = _InvoiceBillMapping.Insert(InvoiceDetailParam);

            return Ok(menuMaster);
        }

        [HttpPost("InvoiceBillMappinngUpdate")]
        public IActionResult InvoiceBillMappinngUpdate(InvoiceDetailParam InvoiceDetailParam)
        {
            var menuMaster = _InvoiceBillMapping.Update(InvoiceDetailParam);
            return Ok(menuMaster);
        }

        [HttpPost("UpdateInvoiceRegno")]
        public IActionResult UpdateInvoiceRegno(InvoiceUpdateRegNoParam InvoiceUpdateRegNoParam)
        {
            var Id = _InvoiceUpdateRegNo.Update(InvoiceUpdateRegNoParam);
            return Ok(Id);
        }


        [HttpPost("PatientservicePaymentUpdate")]
        public IActionResult PatientservicepayupdatePayment(PaymentParam PaymentParam)
        {
            var Id = _Payment.PatientServicePayUpdate(PaymentParam);

            return Ok(Id);
        }

    }

}
