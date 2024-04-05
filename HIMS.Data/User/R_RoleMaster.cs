using HIMS.Common.Utility;
using HIMS.Model.Master;
using HIMS.Model.UserDetail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.User
{
   public class R_RoleMaster:GenericRepository,I_RoleMaster
    {
        public R_RoleMaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public List<MenuMasterParam> GetPermisison(int RoleId)
        {
            // throw new NotImplementedException();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@RoleId", RoleId);
            var lst = GetListBySp<MenuMasterParam>("GET_PERMISSION", sqlParameters);
            _unitofWork.SaveChanges();
            return lst;
        }

        public List<RoleModelparam> GetRoles(string RoleName)
        {
            if (string.IsNullOrEmpty(RoleName))
                RoleName = "";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@RoleName", RoleName);
            return GetList<RoleModelparam>("SELECT RoleId,RoleName FROM RoleMaster WHERE IsActive=1 AND RoleName LIKE '%'+@RoleName+'%'", para);
        }

       
        public string Insert(RoleModelparam RoleModelparam)
        {
            //throw new NotImplementedException();

            var dic = RoleModelparam.ToDictionary();
            if (RoleModelparam.RoleId > 0)
            {
                ExecScalar("UPDATE RoleMaster SET ROleName=@RoleName WHERE RoleId=@RoleId", dic);
            }
            else
            {
                ExecScalar("INSERT INTO RoleMaster(ROleName,IsActive) VALUES(@RoleName,1)", dic);
            }
            return "Ok";
        }

        public void SavePermission(List<PermissionModelparam> lst)
        {
            // throw new NotImplementedException();

            DataTable dt = new DataTable();
            dt.Columns.Add("RoleID", typeof(int));
            dt.Columns.Add("MenuId", typeof(int));
            dt.Columns.Add("IsView", typeof(int));
            dt.Columns.Add("IsAdd", typeof(int));
            dt.Columns.Add("IsEdit", typeof(int));
            dt.Columns.Add("IsDelete", typeof(int));
            foreach (var item in lst)
                dt.Rows.Add(item.RoleId, item.MenuId, item.IsView, item.IsAdd, item.IsEdit, item.IsDelete);
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@tbl", SqlDbType.Structured)
            {
                Value = dt,
                TypeName = "dbo.Permission"
            };
            object dd = ExecuteObjectBySP("Insert_Permission", para);
        }
    }
}
