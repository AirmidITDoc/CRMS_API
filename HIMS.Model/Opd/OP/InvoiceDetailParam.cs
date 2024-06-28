using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
   public class InvoiceDetailParam
    {
        public InsertInvoiceDetail InsertInvoiceDetail { get; set; }

        public List<InsertInvoiceBillDetail> InsertInvoiceBillDetail { get; set; }

        public List<UpdatebillInvoice> UpdatebillInvoice { get; set; }

        public UpdateInvoiceDetail UpdateInvoiceDetail { get; set; }

        public List<UpdateInvoiceBillDetail> UpdateInvoiceBillDetail { get; set; }

        public UpdateStopScreening UpdateStopScreening { get; set; }
    }

    public class InsertInvoiceDetail
    {
       
        public int InvoiceId { get; set; }
        public int CaseId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceTime { get; set; }
        public float TaxableAmount { get; set; }
        public float CGST { get; set; }
        public float SGST { get; set; }
        
        public float IGST { get; set; }
             
        public float TotalAmount { get; set; }
        public String ApprovalStatus { get; set; }
        public String ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public String InvoiceStatus { get; set; }
        public int CashCounterId { get; set; }
        public int CreatedBy { get; set; }
     
    }

    public class UpdateInvoiceDetail
    {

        public int InvoiceId { get; set; }
        public int CaseId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceTime { get; set; }
        public float TaxableAmount { get; set; }
        public float CGST { get; set; }

        public float SGST { get; set; }
        public float IGST { get; set; }
        public String ApprovalStatus { get; set; }
        public String ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public String InvoiceStatus { get; set; }
        public bool IsActive { get; set; }
        public int UpdatedBy { get; set; }

    }

    public class InsertInvoiceBillDetail
    {
        public int InvoiceId { get; set; }
        public int BillNo { get; set; }

        public int CreatedBy { get; set; }
    }
    public class UpdatebillInvoice
    {
       
        public int BillNo { get; set; }
        public int InvoiceId { get; set; }
        public bool IsInvoiceGenerated { get; set; }
    }
    public class UpdateInvoiceBillDetail
    {       

         public int InvBillId { get; set; }
        public int InvoiceId { get; set; }
        public int BillNo { get; set; }
        public bool IsActive { get; set; }
        public int UpdatedBy { get; set; }
    }


   public class UpdateStopScreening
    {
        public int VisitId { get; set; }
        public int RegId { get; set; }
    }
}