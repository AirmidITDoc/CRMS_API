﻿using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_CompanyTypeMaster :GenericRepository,I_CompanyTypeMaster 
    {
        public R_CompanyTypeMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Update(CompanyTypeMasterParams CompanyTypeMasterParams)
        {
            var disc1 = CompanyTypeMasterParams.CompanyTypeMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_CompanyTypeMaster_1", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Save(CompanyTypeMasterParams CompanyTypeMasterParams)
        {
            // throw new NotImplementedException();
            var disc = CompanyTypeMasterParams.CompanyTypeMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("insert_CompanyType_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;

        }

       /* public bool Update(CompanyMasterParams CompanyMasterParams)
        {
            throw new NotImplementedException();
        }

        public bool Save(CompanyMasterParams CompanyMasterParams)
        {
            throw new NotImplementedException();
        }*/
    }
}
