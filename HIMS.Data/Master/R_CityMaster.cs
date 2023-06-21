using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public    class R_CityMaster :GenericRepository,I_CityMaster
    {
        public R_CityMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(CityMasterParam CityMasterParam)
        {
            // throw new NotImplementedException();

            var disc1 = CityMasterParam.CityMasterInsert.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_M_CityMaster_1", disc1); 
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(CityMasterParam CityMasterParam)
        {
            //throw new NotImplementedException();
            var disc = CityMasterParam.CityMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_M_CityMaster_1", disc);
            //commit transaction
            _unitofWork.SaveChanges();
            return true;

        }
    }
}
