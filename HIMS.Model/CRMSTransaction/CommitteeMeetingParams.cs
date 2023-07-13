using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSTransaction
{
    public class CommitteeMeetingParams
    {
        public InsertCommitteeMeeting InsertCommitteeMeeting { get; set; }

        public List<InsertCommitteeMeetingMemberDet> InsertCommitteeMeetingMemberDet { get; set; }
    }
    public class InsertCommitteeMeeting
    {
        public int CommitteeMeetingId { get; set; }
        public DateTime CommitteeMeetingDate { get; set; }
        public DateTime CommitteeMeetingTime { get; set; }
        public string CommiteeMeetingName { get; set; }
        public string CommitteeMeetingLocation { get; set; }
        public int CommitteeMeetingAmount { get; set; }
        public int CreatedBy { get; set; }
    }

    public class InsertCommitteeMeetingMemberDet
    {
        public int CommitteeMeetingId { get; set; }
        public int MemberId { get; set; }
        public int StudyId { get; set; }
        public int MemberAmount { get; set; }
        public string MemberMeetingStatus { get; set; }
        public int CreatedBy { get; set; }

    }
}
