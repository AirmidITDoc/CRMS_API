using HIMS.Common.Utility;
using HIMS.Model.UserDetail;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.User
{
   public class R_ChangePassword :GenericRepository,I_ChangePassword
    {
        public R_ChangePassword(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public bool Insertlogin(CreateUserPassword CreateUserPassword)
        {
            //  throw new NotImplementedException();
            var disc = CreateUserPassword.LoginInsert.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("m_insert_LoginManager_1", disc);

            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(CreateUserPassword CreateUserPassword)
        {
            //  throw new NotImplementedException();

            var disc3 = CreateUserPassword.ChangePassword.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("m_update_UserPassword", disc3);

            _unitofWork.SaveChanges();
            return true;
        }

        public bool UpdateLogin(CreateUserPassword CreateUserPassword)
        {
            //throw new NotImplementedException();
            var disc = CreateUserPassword.LoginUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("m_update_LoginManager_1", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
