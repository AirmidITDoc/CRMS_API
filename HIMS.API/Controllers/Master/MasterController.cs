using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HIMS.Data;
using HIMS.Data.Master;
using HIMS.Data.Master.Billing;
using HIMS.Data.Opd.OP;
using HIMS.Model;
using HIMS.Model.Master;
using HIMS.Model.Master.Billing;
using HIMS.Model.Opd.OP;
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
        public readonly I_AreaMaster _AreaMaster;
        public readonly I_StateMaster _StateMaster;
        public readonly I_CityMaster _CityMaster;
        public readonly I_CountryMaster _CountryMaster;
        public readonly I_ReligienMaster _ReligienMaster;
        //  public readonly I_RelationshipMaster _RelationshipMaster;
        public readonly I_DoctorMaster _DoctorMaster;
        public readonly I_PrefixMaster _PrefixMaster;
        public readonly I_GenderMaster _GenderMaster;
        public readonly I_MaritalStatusMaster _MaritalStatusMaster;

        public readonly I_CompanyMaster _CompanyMaster;
        public readonly I_BankMaster _BankMaster;
        public readonly I_ServiceMaster _ServiceMaster;
        public readonly I_DoctorTypeMaster _DoctorTypeMaster;
        public readonly I_PatientType _PatientType;
        public readonly I_CompanyTypeMaster _CompanyType;
        public readonly I_CashCounterMaster _CashCounterMaster;
        public readonly I_TariffMaster _TariffMaster;
        public readonly I_GroupMaster _GroupMaster;
        public readonly I_SubGroupMaster _SubGroupMaster;
        public MasterController(I_MenuMaster menuMaster,
            
            I_MenuMasterDetails menuMasterDetails,I_MenuMasterDetails_Details menuMasterDetails_Details,I_AreaMaster areaMaster,
            I_StateMaster stateMaster,I_CountryMaster countryMaster,I_ReligienMaster religienMaster,I_CityMaster cityMaster,I_DoctorMaster doctorMaster,
            I_CompanyMaster companyMaster,I_BankMaster bankMaster,I_ServiceMaster serviceMaster,I_DoctorTypeMaster doctorTypeMaster,I_PatientType patientType,
            I_CompanyTypeMaster companyType, I_CashCounterMaster counterMaster,I_TariffMaster tariffMaster,I_GroupMaster groupMaster,I_SubGroupMaster subGroupMaster,
            I_GenderMaster genderMaster,I_PrefixMaster prefixMaster,I_MaritalStatusMaster maritalStatusMaster
            )
        {
           
            this._MenuMaster = menuMaster;
            this._MenuMasterDetails = menuMasterDetails;
            this._MenuMasterDetails_Details = menuMasterDetails_Details;
            this._AreaMaster = areaMaster;
            this._ReligienMaster = religienMaster;
            this._CityMaster = cityMaster;
            this._StateMaster = stateMaster;
          //  this._RelationshipMaster = relationshipMaster;
            this._CountryMaster = countryMaster;
            this._DoctorMaster = doctorMaster;
            this._CompanyMaster = companyMaster;
            this._BankMaster = bankMaster;
            this._ServiceMaster = serviceMaster;
            this._PatientType = patientType;
            this._DoctorTypeMaster = doctorTypeMaster;
            this._CompanyType = companyType;
            this._CashCounterMaster = counterMaster;
            this._TariffMaster = tariffMaster;

            this._GroupMaster = groupMaster;
            this._SubGroupMaster = subGroupMaster;

            this._PrefixMaster = prefixMaster;

            this._GenderMaster = genderMaster;
            this._MaritalStatusMaster = maritalStatusMaster;
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


        // Prefix Master Insert & Update
        [HttpPost("PrefixSave")]
        public IActionResult PrefixSave(PrefixMasterParams PrefixMasterParams)
        {
            var Master = _PrefixMaster.Save(PrefixMasterParams);
            return Ok(Master);
        }

        [HttpPost("PrefixUpdate")]
        public IActionResult PrefixUpdate(PrefixMasterParams PrefixMasterParams)
        {
            var menuMaster = _PrefixMaster.Update(PrefixMasterParams);
            return Ok(menuMaster);
        }

        // Gender Master Insert & Update
        [HttpPost("GenderSave")]
        public IActionResult GenderSave(GenderMasterParams GenderMasterParams)
        {
            var Master = _GenderMaster.Save(GenderMasterParams);
            return Ok(Master);
        }

        [HttpPost("GenderUpdate")]
        public IActionResult GenderUpdate(GenderMasterParams GenderMasterParams)
        {
            var menuMaster = _GenderMaster.Update(GenderMasterParams);
            return Ok(menuMaster);
        }


        // MaritalStatus Master Insert & Update
        [HttpPost("MaritalStatusSave")]
        public IActionResult MaritalStatusSave(MaritalStatusMasterParams MaritalStatusMasterParams)
        {
            var Master = _MaritalStatusMaster.Save(MaritalStatusMasterParams);
            return Ok(Master);
        }

        [HttpPost("MaritalStatusUpdate")]
        public IActionResult MaritalStatusUpdate(MaritalStatusMasterParams MaritalStatusMasterParams)
        {
            var menuMaster = _MaritalStatusMaster.Update(MaritalStatusMasterParams);
            return Ok(menuMaster);
        }

        // Area Master Insert & Update
        [HttpPost("AreaSave")]
        public IActionResult AreaSave(AreaMasterParam AreaMasterParam)
        {
            var Master = _AreaMaster.Save(AreaMasterParam);
            return Ok(Master);
        }

        [HttpPost("AreaUpdate")]
        public IActionResult AreaUpdate(AreaMasterParam AreaMasterParam)
        {
            var menuMaster = _AreaMaster.Update(AreaMasterParam);
            return Ok(menuMaster);
        }
     

        // City Master Insert & Update
        [HttpPost("CitySave")]
        public IActionResult CitySave(CityMasterParam CityMasterParam)
        {
            var menuMaster = _CityMaster.Save(CityMasterParam);
             return Ok(menuMaster);
        }

        [HttpPost("CityrUpdate")]
        public IActionResult CityrUpdate(CityMasterParam CityMasterParam)
        {
            var menuMaster = _CityMaster.Update(CityMasterParam);
            return Ok(menuMaster);
        }
     

        // State Master Insert & Update
        [HttpPost("StateSave")]
        public IActionResult StateSave(StateMasterParam StateMasterParam)
        {
            var menuMaster = _StateMaster.Save(StateMasterParam);
               return Ok(menuMaster);
        }

        [HttpPost("StateUpdate")]
        public IActionResult StateUpdate(StateMasterParam StateMasterParam)
        {
            var menuMaster = _StateMaster.Update(StateMasterParam);
            return Ok(menuMaster);
        }
     
        // Country Master Insert & Update
        [HttpPost("CountrySave")]
        public IActionResult CountrySave(CountryMasterParam CountryMasterParam)
        {
            var menuMaster = _CountryMaster.Save(CountryMasterParam);
            //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("CountryUpdate")]
        public IActionResult CountryUpdate(CountryMasterParam CountryMasterParam)
        {
            var menuMaster = _CountryMaster.Update(CountryMasterParam);
            return Ok(menuMaster);
        }

        // Religion Master Insert & Update
        [HttpPost("ReligionSave")]
        public IActionResult ReligionSave(ReliginMasterParam ReliginMasterParam)
        {
            var menuMaster = _ReligienMaster.Save(ReliginMasterParam);
              return Ok(menuMaster);
        }

        [HttpPost("ReligionUpdate")]
        public IActionResult CountryUpdate(ReliginMasterParam ReliginMasterParam)
        {
            var menuMaster = _ReligienMaster.Update(ReliginMasterParam);
            return Ok(menuMaster);
        }

        /*
                // Relationship Master Insert & Update
                [HttpPost("RelationshipSave")]
                public IActionResult RelationshipSave(RelationshipMasterparam RelationshipMasterparam)
                {
                    var menuMaster = _RelationshipMaster.Save(RelationshipMasterparam);
                    //  var ServiceSave = _BankMasterResp.Save(bankMasterParams);
                    return Ok(menuMaster);
                }

                [HttpPost("RelationshipUpdate")]
                public IActionResult RelationshipUpdate(RelationshipMasterparam RelationshipMasterparam)
                {
                    var menuMaster = _RelationshipMaster.Update(RelationshipMasterparam);
                    return Ok(menuMaster);
                }*/



        // Doctor Master Insert & Update
        [HttpPost("DoctorSave")]
        public IActionResult DoctorSave(DoctorMasterparam DoctorMasterparam)
        {
            var menuMaster = _DoctorMaster.Insert(DoctorMasterparam);
            return Ok(menuMaster);
        }

        [HttpPost("DoctorUpdate")]
        public IActionResult DoctorUpdate(DoctorMasterparam DoctorMasterparam)
        {
            var menuMaster = _DoctorMaster.Update(DoctorMasterparam);
            return Ok(menuMaster);
        }

        // DoctorType Master Insert & Update
        [HttpPost("DoctorTypeSave")]
        public IActionResult DoctorTypeSave(Doctortypeparam Doctortypeparam)
        {
            var menuMaster = _DoctorTypeMaster.Save(Doctortypeparam);
            return Ok(menuMaster);
        }

        [HttpPost("DoctorTypeUpdate")]
        public IActionResult DoctorTypeUpdate(Doctortypeparam Doctortypeparam)
        {
            var menuMaster = _DoctorTypeMaster.Update(Doctortypeparam);
            return Ok(menuMaster);
        }
        // Company Master Insert & Update
        [HttpPost("CompanySave")]
        public IActionResult CompanySave(CompanyMasterParams CompanyMasterParams)
        {
            var menuMaster = _CompanyMaster.Save(CompanyMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("CompanyUpdate")]
        public IActionResult CompanyUpdate(CompanyMasterParams CompanyMasterParams)
        {
            var menuMaster = _CompanyMaster.Update(CompanyMasterParams);
            return Ok(menuMaster);
        }


        // CompanyType Master Insert & Update
        [HttpPost("CompanyTypeSave")]
        public IActionResult CompanyTypeSave(CompanyTypeMasterParams CompanyTypeMasterParams)
        {
            var menuMaster = _CompanyType.Save(CompanyTypeMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("CompanyTypeUpdate")]
        public IActionResult CompanyTypeUpdate(CompanyTypeMasterParams CompanyTypeMasterParams)
        {
            var menuMaster = _CompanyType.Update(CompanyTypeMasterParams);
            return Ok(menuMaster);
        }


     

        // Service Master Insert & Update
        [HttpPost("ServiceSave")]
        public IActionResult ServiceSave(ServiceMasterParams ServiceMasterParams)
        {
            var menuMaster = _ServiceMaster.Save(ServiceMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("ServiceUpdate")]
        public IActionResult ServiceUpdate(ServiceMasterParams ServiceMasterParams)
        {
            var menuMaster = _ServiceMaster.Update(ServiceMasterParams);
            return Ok(menuMaster);
        }

        // Bank Master Insert & Update
        [HttpPost("BankSave")]
        public IActionResult BankSave(BankMasterParams BankMasterParam)
        {
            var menuMaster = _BankMaster.Save(BankMasterParam);
            return Ok(menuMaster);
        }

        [HttpPost("BankUpdate")]
        public IActionResult ServiceUpdate(BankMasterParams BankMasterParams)
        {
            var menuMaster = _BankMaster.Update(BankMasterParams);
            return Ok(menuMaster);
        }

        // Traiff Master Insert & Update
        [HttpPost("TariffSave")]
        public IActionResult TariffSave(TariffMasterParams TariffMasterParams)
        {
            var menuMaster = _TariffMaster.Save(TariffMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("TariffUpdate")]
        public IActionResult TariffUpdate(TariffMasterParams TariffMasterParams)
        {
            var menuMaster = _TariffMaster.Update(TariffMasterParams);
            return Ok(menuMaster);
        }

        // CashCounter Master Insert & Update
        [HttpPost("CashCounterSave")]
        public IActionResult CashCounterSave(CashCounterMasterParams CashCounter)
        {
            var menuMaster = _CashCounterMaster.Save(CashCounter);
            return Ok(menuMaster);
        }

        [HttpPost("CashCounterUpdate")]
        public IActionResult CashCounterUpdate(CashCounterMasterParams CashCounter)
        {
            var menuMaster = _CashCounterMaster.Update(CashCounter);
            return Ok(menuMaster);
        }

        // Group Master Insert & Update
        [HttpPost("GroupSave")]
        public IActionResult GroupSave(GroupMasterParams GroupMasterParams)
        {
            var menuMaster = _GroupMaster.Save(GroupMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("GroupUpdate")]
        public IActionResult GroupUpdate(GroupMasterParams GroupMasterParams)
        {
            var menuMaster = _GroupMaster.Update(GroupMasterParams);
            return Ok(menuMaster);
        }


        // SubGroup Master Insert & Update
        [HttpPost("SubGroupSave")]
        public IActionResult SubGroupSave(SubGroupMasterParams SubGroupMasterParams)
        {
            var menuMaster = _SubGroupMaster.Save(SubGroupMasterParams);
            return Ok(menuMaster);
        }

        [HttpPost("SubGroupUpdate")]
        public IActionResult SubGroupUpdate(SubGroupMasterParams SubGroupMasterParams)
        {
            var menuMaster = _SubGroupMaster.Update(SubGroupMasterParams);
            return Ok(menuMaster);
        }




        // PatientType Master Insert & Update
        [HttpPost("PatientTypeSave")]
        public IActionResult PatientTypeSave(PatientTypeParam PatientTypeParam)
        {
            var menuMaster = _PatientType.Save(PatientTypeParam);
            return Ok(menuMaster);
        }

       /* [HttpPost("PatientTypeUpdate")]
        public IActionResult PatientTypeUpdate(PatientTypeParam PatientTypeParam)
        {
            var menuMaster = _PatientType.Update(PatientTypeParam);
            return Ok(menuMaster);
        }*/
    }
}
