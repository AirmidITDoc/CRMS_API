using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
  public  class R_CompanyType:GenericRepository,I_CompanyType
    {
        public R_CompanyType(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(CompanyTypeParam CompanyTypeParam)
        {
            // throw new NotImplementedException();
            var disc1 = CompanyTypeParam.CompanyTypeMasterInsert.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_CompanyType_1", disc1); 

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(CompanyTypeParam CompanyTypeParam)
        {
            //throw new NotImplementedException();

            var disc = CompanyTypeParam.CompanyTypeMasterUpdate.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("update_CompanyTypeMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
