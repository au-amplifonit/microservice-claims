using System;
using System.Collections.Generic;

namespace Fox.Microservices.Claims.Models.Entities
{
    public partial class CL_B_CLAIM_EXT_AUS
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string VOUCHER_ID { get; set; }
        public string STATUS_CODE { get; set; }
        public string TYPE_CODE { get; set; }
        public DateTime? CREATION_DATE { get; set; }
        public string STATUS_REASON_CODE { get; set; }
        public string CLINIC_ID { get; set; }
        public int? BATCH_NUMBER { get; set; }
        public decimal? TOTAL_COST_OF_FITTING_BENEFIT { get; set; }
        public decimal? TOTAL_COST_OF_FITTING_GST_AMT { get; set; }
        public decimal? TOTAL_BENEFIT_COST_OF_FITTING { get; set; }
        public decimal? MAINTENANCE_FEE { get; set; }
        public decimal? REPLACEMENT_FEE { get; set; }
        public decimal? TOTAL_COST_OF_PRG_TO_CLIENT { get; set; }
        public string AUTHORIZED_BY { get; set; }
        public string IS_CLIENT_SIGNED { get; set; }
        public DateTime? CLIENT_SIGNED_DATE { get; set; }
        public string IS_CLINICIAN_SIGNED { get; set; }
        public DateTime? CLINICIAN_SIGNED_DATE { get; set; }
        public string IS_CTC { get; set; }
        public string PARENT_CLAIM_ID { get; set; }
        public string ASSIGNED_TO { get; set; }
        public string IS_HOLD { get; set; }
        public string ELIGIBLE_FOR_HEARING_SERVICE { get; set; }
        public short? TOTAL_ITEM_QUATITY { get; set; }
        public short? TOTAL_DEVICE_QUATITIY { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public Guid? ROWGUID { get; set; }
        public string MCP_REASON_CODE { get; set; }
        public DateTime? VOUCHER_ISSUE_DATE { get; set; }
        public string APPOINTMENT_ID { get; set; }
        public DateTime? PROCESSED_DATE { get; set; }
        public string STATUS_REASON_DESCR { get; set; }
        public string IS_ADHOC_CLAIM { get; set; }
        public string HAS_CHILD { get; set; }
        public string CLAIM_ID { get; set; }
        public decimal? PTA1_L { get; set; }
        public decimal? PTA1_R { get; set; }
    }
}
