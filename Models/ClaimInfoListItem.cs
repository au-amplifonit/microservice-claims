using Fox.Microservices.Claims.Models.Entities.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Claims.Models
{
    public class ClaimInfoListItem
    {
        public string ClaimID { get; set; }
        public string CustomerCode { get; set; }
        public string SaleNumber { get; set; }
        public string VoucherNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string VoucherType { get; set; }
        public string ClaimTypeCode { get; set; }
        public string ClaimTypeDescription { get; set; }
        public string ClaimStatusCode { get; set; }
        public string ClaimStatusDescription { get; set; }
        public string BatchID { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public decimal? TotalBenefit { get; set; }

        public ClaimDeviceInfoListItem[] Devices { get => DeviceList.ToArray(); }

        internal List<ClaimDeviceInfoListItem> DeviceList { get; } = new List<ClaimDeviceInfoListItem>();

        public ClaimInfoListItem()
        {
        }

        public ClaimInfoListItem(p_CL_B_CLAIM_EXT_AUS_GetAll_Result Entity)
        {
            ClaimID = Entity.CLAIM_ID;
            CustomerCode = Entity.CUSTOMER_CODE;
            SaleNumber = Entity.SALE_NUMBER;
            VoucherNumber = Entity.VOUCHER_NUMBER;
            IssueDate = Entity.ISSUE_DATE;
            VoucherType = Entity.VOUCHER_TYPE;
            ClaimTypeCode = Entity.TYPE_CODE;
            ClaimTypeDescription = Entity.CLAIM_TYPE;
            ClaimStatusCode = Entity.STATUS_CODE;
            ClaimStatusDescription = Entity.CLAIM_STATUS;
            BatchID = Entity.BATCH_ID;
            ProcessedDate = Entity.PROCESSED_DATE;
            TotalBenefit = Entity.TOTAL_BENEFIT;
        }
    }
}
