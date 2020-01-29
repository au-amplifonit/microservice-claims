using System;
using System.Collections.Generic;

namespace Fox.Microservices.Claims.Models.Entities
{
    public partial class CL_B_CLAIM_ITEMS_EXT_AUS
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string CLAIM_ID { get; set; }
        public int ITEM_NUMBER { get; set; }
        public short? QUANTITY { get; set; }
        public DateTime? DATE_OF_SERVICE { get; set; }
        public string SITE_ID { get; set; }
        public string PRACTIONER_NUMBER { get; set; }
        public decimal? COST_TO_CLIENT { get; set; }
        public decimal? ITEM_BENEFIT { get; set; }
        public decimal? GST_AMOUNT { get; set; }
        public decimal? TOTAL_BENEFIT { get; set; }
        public string ITEM_REASON_CODE { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public Guid? ROWGUID { get; set; }
        public decimal? GST_PAID { get; set; }
        public decimal? WHT_PAID { get; set; }
        public decimal? AMOUNT_PAID { get; set; }
        public short? LINE_NUMBER { get; set; }
    }
}
