﻿using HIMS.Common.Utility;
using HIMS.Model.Master;
using HIMS.Model.Master.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_CompanyMaster :GenericRepository,I_CompanyMaster
    {
        public R_CompanyMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
         
        public bool Update(CompanyMasterParams CompanyMasterParams)
        {
            var disc1 = CompanyMasterParams.CompanyMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Update_CompanyMaster_1", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Save(CompanyMasterParams CompanyMasterParams)
        {
            // throw new NotImplementedException();
            var disc = CompanyMasterParams.CompanyMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("Insert_CompanyMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;

        }

    }
}
