using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public  class R_CountryMaster:GenericRepository,I_CountryMaster
    {
        public R_CountryMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(CountryMasterParam CountryMasterParam)
        {
            //  throw new NotImplementedException();
            var disc1 = CountryMasterParam.CountryMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_CountryMaster_1", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(CountryMasterParam CountryMasterParam)
        {
            //throw new NotImplementedException();

            var disc = CountryMasterParam.CountryMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("insert_CountryMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
