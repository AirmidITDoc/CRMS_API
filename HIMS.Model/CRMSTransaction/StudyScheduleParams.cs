using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSTransaction
{
    public class StudyScheduleParams
    {
        public List<InsertStudySchedule> InsertStudySchedule { get; set; }
        public List<UpdateStudySchedule> UpdateStudySchedule { get; set; }
        public DeleteStudySchedule DeleteStudySchedule { get; set; }
        public UpdateStudyScheduleId UpdateStudyScheduleId { get; set; }

    }

    public class InsertStudySchedule
    {
    //    public int StudyVisitId { get; set; }
        public int StudyId { get; set; }
        public string VisitName { get; set; }
        public string VisitDescription { get; set; }
        public int VisitAmount { get; set; }
        public int VisitFrequency { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateStudySchedule
    {
        public string Operation { get; set; }
        public int StudyVisitId { get; set; }
        public int StudyId { get; set; }
        public string VisitName { get; set; }
        public string VisitDescription { get; set; }
        public int VisitAmount { get; set; }
        public int VisitFrequency { get; set; }
        public int UpdatedBy { get; set; }
    }

    public class UpdateStudyScheduleId
    {
        public string Operation { get; set; }
        public int StudyVisitId { get; set; }
        public int StudyId { get; set; }
        public string VisitName { get; set; }
        public string VisitDescription { get; set; }
        public int VisitAmount { get; set; }
        public int VisitFrequency { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class DeleteStudySchedule
    {
        public int StudyId { get; set; }
    }
}
