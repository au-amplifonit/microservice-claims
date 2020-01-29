using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Claims.Models.Entities.StoredProcedures
{
    public class p_CL_B_CLAIM_EXT_AUS_GetAll_Result
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CLAIM_ID { get; set; }
        public string ITEM_NUMBER { get; set; }
        public DateTime? SERVICE_DATE { get; set; }
        public DateTime? PROCESSED_DATE { get; set; }
        public decimal? OHS_BILLED { get; set; }
        public decimal? OHS_RECEIVED { get; set; }
        public string VOUCHER_NUMBER { get; set; }
        public DateTime? ISSUE_DATE { get; set; }
        public string VOUCHER_TYPE { get; set; }
        public string CLAIM_TYPE { get; set; }
        public string CLAIM_STATUS { get; set; }
        public string BATCH_ID { get; set; }
        public decimal? TOTAL_BENEFIT { get; set; }
        public string STATUS_REASON_CODE { get; set; }
        public string TYPE_CODE { get; set; }
        public string STATUS_CODE { get; set; }
        public string MCP_REASON_CODE { get; set; }
        public string IS_ADHOC_CLAIM { get; set; }
        public string HAS_CHILD { get; set; }
        public string EAR_SIDE { get; set; }
        public string SALE_NUMBER { get; set; }
        public DateTime? SALE_DATE { get; set; }
    }
}
