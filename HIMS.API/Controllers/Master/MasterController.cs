using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HIMS.Data;
using HIMS.Data.Master;
using HIMS.Data.Opd.OP;
using HIMS.Model;
using HIMS.Model.Master;
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

        public readonly I_CompanyMaster _CompanyMaster;
        public readonly I_BankMaster _BankMaster;
        public readonly I_ServiceMaster _ServiceMaster;
        public readonly I_DoctorTypeMaster _DoctorTypeMaster;
        public readonly I_PatientType _PatientType;
        public readonly I_CompanyType _CompanyType;
        public MasterController(I_MenuMaster menuMaster,
            
            I_MenuMasterDetails menuMasterDetails,I_MenuMasterDetails_Details menuMasterDetails_Details,I_AreaMaster areaMaster,
            I_StateMaster stateMaster,I_CountryMaster countryMaster,I_ReligienMaster religienMaster,I_CityMaster cityMaster,I_DoctorMaster doctorMaster,
            I_CompanyMaster companyMaster,I_BankMaster bankMaster,I_ServiceMaster serviceMaster,I_DoctorTypeMaster doctorTypeMaster,I_PatientType patientType,
            I_CompanyType companyType
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
        public IActionResult CompanySave(CompanyMasterparam CompanyMasterparam)
        {
            var menuMaster = _CompanyMaster.Save(CompanyMasterparam);
            return Ok(menuMaster);
        }

        [HttpPost("CompanyUpdate")]
        public IActionResult CompanyUpdate(CompanyMasterparam CompanyMasterparam)
        {
            var menuMaster = _CompanyMaster.Update(CompanyMasterparam);
            return Ok(menuMaster);
        }


        // CompanyType Master Insert & Update
        [HttpPost("CompanyTypeSave")]
        public IActionResult CompanyTypeSave(CompanyTypeParam CompanyTypeParam)
        {
            var menuMaster = _CompanyType.Save(CompanyTypeParam);
            return Ok(menuMaster);
        }

        [HttpPost("CompanyTypeUpdate")]
        public IActionResult CompanyTypeUpdate(CompanyTypeParam CompanyTypeParam)
        {
            var menuMaster = _CompanyType.Update(CompanyTypeParam);
            return Ok(menuMaster);
        }


     

        // Service Master Insert & Update
        [HttpPost("ServiceSave")]
        public IActionResult ServiceSave(ServiceMasterParam ServiceMasterParam)
        {
            var menuMaster = _ServiceMaster.Save(ServiceMasterParam);
            return Ok(menuMaster);
        }

        [HttpPost("ServiceUpdate")]
        public IActionResult ServiceUpdate(ServiceMasterParam ServiceMasterParam)
        {
            var menuMaster = _ServiceMaster.Update(ServiceMasterParam);
            return Ok(menuMaster);
        }

        // Bank Master Insert & Update
        [HttpPost("BankSave")]
        public IActionResult BankSave(BankMasterParam BankMasterParam)
        {
            var menuMaster = _BankMaster.Save(BankMasterParam);
            return Ok(menuMaster);
        }

        [HttpPost("BankUpdate")]
        public IActionResult ServiceUpdate(BankMasterParam BankMasterParam)
        {
            var menuMaster = _BankMaster.Update(BankMasterParam);
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
