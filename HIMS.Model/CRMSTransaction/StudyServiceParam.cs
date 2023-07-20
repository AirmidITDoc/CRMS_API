using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSTransaction
{
    public class StudyServiceParam
    {
        public List<InsertStudyservice> InsertStudyservice { get; set; }
        public List<UpdateStudyservice> UpdateStudyservice { get; set; }

        public DeleteStudyService DeleteStudyService { get; set; }

    }
    public class InsertStudyservice

    {
        public int StudyServicesId { get; set; }
        public int StudyId { get; set; }
        public int StudyVisitId { get; set; }
        public int ServiceId { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateStudyservice
    {
        public String Operation { get; set; }
        public int StudyServicesId { get; set; }
        public int StudyId { get; set; }
        public int StudyVisitId { get; set; }
        public int ServiceId { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }
        public int UpdatedBy { get; set; }
    }

    public class DeleteStudyService
    {
        public int StudyId { get; set; }
    }
}