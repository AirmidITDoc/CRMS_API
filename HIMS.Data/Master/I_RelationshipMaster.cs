using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
  public  interface I_RelationshipMaster
    {
        bool Update(RelationshipMasterparam RelationshipMasterparam);
        bool Save(RelationshipMasterparam RelationshipMasterparam);
    }
}
