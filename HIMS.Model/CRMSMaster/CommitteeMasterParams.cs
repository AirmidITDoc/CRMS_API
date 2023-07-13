using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSMaster
{
    public class CommitteeMasterParams
    {
        public InsertCommitteeMaster InsertCommitteeMaster { get; set; }

        public List<InsertCommitteeMemberDetails> InsertCommitteeMemberDetails { get; set; }

    }

    public class InsertCommitteeMaster
    {
        public int CommitteeId { get; set; }
	    public string CommiteeName {get; set; } 
	    public int CreatedBy { get; set; }  
    }

    public class InsertCommitteeMemberDetails
    {
        public int CommitteeId { get; set; }
        public int MemberId { get; set; }
        public int CreatedBy { get; set; }
    }
}
