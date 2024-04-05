using HIMS.Model;
using HIMS.Model.Master;
using HIMS.Model.UserDetail;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.User
{
   public interface I_RoleMaster
    {
        public string Insert(RoleModelparam RoleModelparam);
        List<RoleModelparam> GetRoles(string RoleName);
        List<MenuMasterParam> GetPermisison(int RoleId);
        void SavePermission(List<PermissionModelparam> lst);
    }
}
