using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
    public class PaymentParam
    {
        public OPInsertPayment OPInsertPayment { get; set; }

        public PatientServicepayupdate PatientServicepayupdate { get; set; }
    }

    public class OPInsertPayment
    {
        public int PaymentId { get; set; }
        public int BillNo { get; set; }
        // public String ReceiptNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PaymentTime { get; set; }
        public long CashPayAmount { get; set; }
        public long ChequePayAmount { get; set; }
        public String ChequeNo { get; set; }
        public String BankName { get; set; }
        public DateTime ChequeDate { get; set; }
        public long CardPayAmount { get; set; }
        public String CardNo { get; set; }
        public String CardBankName { get; set; }
        public DateTime CardDate { get; set; }
        public long AdvanceUsedAmount { get; set; }
        public int AdvanceId { get; set; }
        public int RefundId { get; set; }
        public int TransactionType { get; set; }
        public String Remark { get; set; }
        public int CreatedBy { get; set; }
        public int IsCancelled { get; set; }
        public int IsCancelledBy { get; set; }
        public DateTime IsCancelledDate { get; set; }

        public bool IsSelfORCompany { get; set; }
        public int CompanyId { get; set; }
        public long NEFTPayAmount { get; set; }
        public String NEFTNo { get; set; }
        public String NEFTBankMaster { get; set; }
        public DateTime NEFTDate { get; set; }
        public long PayTMAmount { get; set; }
        public String PayTMTranNo { get; set; }
        public DateTime PayTMDate { get; set; }
    }

  
    public class PatientServicepayupdate{
      public int ChargesId { get; set; }
    public String UTINo { get; set; }
    
    public DateTime PaymentDate { get; set; }
    public string Comments { get; set; }
}
}
