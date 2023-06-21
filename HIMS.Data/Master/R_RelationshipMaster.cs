using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_RelationshipMaster :GenericRepository,I_RelationshipMaster
    {
        public R_RelationshipMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(RelationshipMasterparam RelationshipMasterparam)
        {
            // throw new NotImplementedException();

            var disc1 = RelationshipMasterparam.RelationshipMasterInsert.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_RelationshipMaster_1", disc1); 

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(RelationshipMasterparam RelationshipMasterparam)
        {
            //throw new NotImplementedException();
            var disc = RelationshipMasterparam.RelationshipMasterUpdate.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("update_RelationshipMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
