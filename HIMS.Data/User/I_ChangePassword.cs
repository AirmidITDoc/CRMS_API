using HIMS.Model.UserDetail;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.User
{
   public interface I_ChangePassword
    {
        public bool Update(CreateUserPassword CreateUserPassword);


        public bool Insertlogin(CreateUserPassword CreateUserPassword);
        public bool UpdateLogin(CreateUserPassword CreateUserPassword);
    }
}
