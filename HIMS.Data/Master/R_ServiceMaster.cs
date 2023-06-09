﻿using HIMS.Common.Utility;
using HIMS.Model.Master;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{ 
   public class R_ServiceMaster :GenericRepository ,I_ServiceMaster
    {
        public R_ServiceMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

         
        public bool Save(ServiceMasterParams ServiceMasterParams)
        {
            //Service master insert
            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ServiceId",
                Value = 0,
                Direction = ParameterDirection.Output
            };
            var dic = ServiceMasterParams.ServiceMasterInsert.ToDictionary();
            dic.Remove("ServiceId");
            var ServiceId = ExecNonQueryProcWithOutSaveChanges("insert_ServiceMaster_1", dic, outputId);
            
            
            // Service Detail Insert
            foreach(var a in ServiceMasterParams.ServiceDetailInsert)
            {
                var d = a.ToDictionary();
                d["ServiceId"] = ServiceId;
                ExecNonQueryProcWithOutSaveChanges("insert_ServiceDetail_1", d);

            }
            _unitofWork.SaveChanges();
            return true;
        }

          public bool Update(ServiceMasterParams ServiceMasterParams)
           {

            //Update Service
            var dic = ServiceMasterParams.ServiceMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_ServiceMaster_1", dic);

            //Delete Service Details
            var S_Det = ServiceMasterParams.ServiceDetDelete.ToDictionary();
            S_Det["ServiceId"] = ServiceMasterParams.ServiceMasterUpdate.ServiceId;
            ExecNonQueryProcWithOutSaveChanges("Delete_ServiceDetail", S_Det);

            //add ServiceDetails
            foreach (var a in ServiceMasterParams.ServiceDetailInsert)
            {
                var disc = a.ToDictionary();
                disc["ServiceId"] = ServiceMasterParams.ServiceMasterUpdate.ServiceId;
                ExecNonQueryProcWithOutSaveChanges("insert_ServiceDetail_1", disc);
            }

            _unitofWork.SaveChanges();
            return true;

        }

    }
}
