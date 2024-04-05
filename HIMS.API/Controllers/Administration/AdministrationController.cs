using HIMS.Data.User;
using HIMS.Model.UserDetail;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIMS.API.Controllers.Administration
{

    [ApiController]
    [Route("api/[controller]")]
    public class AdministrationController : Controller
    {
        public readonly I_ChangePassword _ChangePassword;
        //public readonly I_PatientPastHistory _PatientPastHistory;

        public AdministrationController(I_ChangePassword changePassword)
        {
            _ChangePassword = changePassword;
            //_PatientPastHistory = patientPastHistory;
        }

        [HttpPost("UserChangePassword")]
        public IActionResult UserChangePassword(CreateUserPassword CreateUserPassword)
        {
            var UserName = _ChangePassword.Update(CreateUserPassword);
            return Ok(UserName);
        }

        [HttpPost("InsertLoginUser")]
        public IActionResult UserInsert(CreateUserPassword CreateUserPassword)
        {
            var UserName = _ChangePassword.Insertlogin(CreateUserPassword);
            return Ok(UserName);
        }

        [HttpPost("UpdateLoginUser")]
        public IActionResult Userupdate(CreateUserPassword CreateUserPassword)
        {
            var UserName = _ChangePassword.UpdateLogin(CreateUserPassword);
            return Ok(UserName);
        }


    }
}
