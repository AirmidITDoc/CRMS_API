using HIMS.Data.User;
using HIMS.Model.UserDetail;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIMS.API.Controllers.Role
{

    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
        public readonly I_RoleMaster _RoleMaster;

        public RoleController(I_RoleMaster roleMaster)
        {
            _RoleMaster = roleMaster;
            //_PatientPastHistory = patientPastHistory;
        }

        [HttpGet]
        [Route("get-roles")]
        public IActionResult GetRoles(string RoleName)
        {
            return Ok(_RoleMaster.GetRoles(RoleName));
        }
        [HttpPost]
        [Route("save")]
        public IActionResult Save(RoleModelparam obj)
        {
            _RoleMaster.Insert(obj);
            return Ok(obj);
        }
        [HttpGet]
        [Route("get-permissions")]
        public IActionResult GetPermission(int RoleId)
        {
            return Ok(_RoleMaster.GetPermisison(RoleId));
        }
        [HttpPost]
        [Route("save-permission")]
        public IActionResult PostPermission(List<PermissionModelparam> obj)
        {
            _RoleMaster.SavePermission(obj);
            return Ok();
        }

    }
}
