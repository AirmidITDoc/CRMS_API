using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using HIMS.Common.Utility;
using HIMS.Data.CRMSTransaction;
using HIMS.Model.CRMSTransaction;

namespace HIMS.Data.CRMSTransaction
{
    public class R_StudyUploadDocument : GenericRepository, I_StudyUploadDocument
    {
        public R_StudyUploadDocument(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string InsertStudyUploadDocument(StudyUploadDocumentParams _StudyUploadDocumentParams)
        {
            //  throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@StudyDocId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _StudyUploadDocumentParams.InsertStudyUploadDocument.ToDictionary();
            disc3.Remove("StudyDocId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_StudyUploadDocument", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateStudyUploadDocument(StudyUploadDocumentParams _StudyUploadDocumentParams)
        {
            //throw new NotImplementedException();

            var disc3 = _StudyUploadDocumentParams.UpdateStudyUploadDocument.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("Update_StudyUploadDocument", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
