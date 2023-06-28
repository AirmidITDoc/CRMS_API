using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
   public class VisitMasterParam
    {
        public VisitMasterUpdate VisitMasterUpdate { get; set; }
        public VisitMasterAdd VisitMasterAdd { get; set; }

    }

    public class VisitMasterUpdate
    {
        public long VisitId { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime VisitTime { get; set; }

        public long ConsultantDocId { get; set; }

        public long CreatedBy { get; set; }


        /*public long RegID { get; set; }

        //   public long CaseID { get; set; }

        public long UnitId { get; set; }
        public long PatientTypeId { get; set; }
      
        public long RefDocId { get; set; }
        public long TariffId { get; set; }
        public long CompanyId { get; set; }
        public long UpdatedBy { get; set; }

        public bool IsCancelled { get; set; }
        public long IsCancelledBy { get; set; }
        public DateTime IsCancelledDate { get; set; }
        public long ClassId { get; set; }
        public long DepartmentId { get; set; }
        public long PatientOldNew { get; set; }
        public Boolean FirstFollowupVisit { get; set; }
        public long AppPurposeId { get; set; }
        public DateTime FollowupDate { get; set; }

        public Boolean IsMark { get; set; }
        // public Boolean IsXray { get; set; }

        public String Comments { get; set; }
        public DateTime Intime { get; set; }
        public DateTime OutTime { get; set; }*/

        


    }

    public class VisitMasterAdd
    {
        public long VisitId { get; set; }
        public long RegID { get; set; }

        public long CaseID { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime VisitTime { get; set; }
        public long UnitId { get; set; }
        public long PatientTypeId { get; set; }
        public long ConsultantDocId { get; set; }
        public long RefDocId { get; set; }
        public long TariffId { get; set; }
        public long CompanyId { get; set; }
        public long UpdatedBy { get; set; }

        public bool IsCancelled { get; set; }
        public long IsCancelledBy { get; set; }
        public DateTime IsCancelledDate { get; set; }
        public long ClassId { get; set; }
        public long DepartmentId { get; set; }
        public long PatientOldNew { get; set; }
        public Boolean FirstFollowupVisit { get; set; }
        public long AppPurposeId { get; set; }
        public DateTime FollowupDate { get; set; }

        public Boolean IsMark { get; set; }
        // public Boolean IsXray { get; set; }

        public String Comments { get; set; }
        public DateTime Intime { get; set; }
        public DateTime OutTime { get; set; }

        public long CreatedBy { get; set; }
    }
}

