using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_ServiceMaster:GenericRepository,I_ServiceMaster
    {
        public R_ServiceMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(ServiceMasterParam ServiceMasterParam)
        {
            //throw new NotImplementedException();
            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ServiceId",
                Value = 0,
                Direction = ParameterDirection.Output
            };
            var dic = ServiceMasterParam.ServiceMasterInsert.ToDictionary();
            dic.Remove("ServiceId");
            var ServiceId = ExecNonQueryProcWithOutSaveChanges("insert_ServiceMaster_1", dic, outputId);


            // Service Detail Insert
            foreach (var a in ServiceMasterParam.ServiceDetailInsert)
            {
                var d = a.ToDictionary();
                d["ServiceId"] = ServiceId;
                ExecNonQueryProcWithOutSaveChanges("insert_ServiceDetail_1", d);

            }
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(ServiceMasterParam ServiceMasterParam)
        {
            // throw new NotImplementedException();

            var dic = ServiceMasterParam.ServiceMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_ServiceMaster_1", dic);

            //Delete Service Details
            var S_Det = ServiceMasterParam.ServiceDetDelete.ToDictionary();
            //ExecNonQueryProcWithOutSaveChanges("Ps_Delete_M_ServiceDetail", S_Det);

            //add ServiceDetails
            foreach (var a in ServiceMasterParam.ServiceDetailInsert)
            {
                var disc = a.ToDictionary();
                ExecNonQueryProcWithOutSaveChanges("insert_ServiceDetail_1", disc);
            }

            _unitofWork.SaveChanges();
            return true;
        }

       
    }
}
