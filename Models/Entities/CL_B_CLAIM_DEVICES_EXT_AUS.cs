using System;
using System.Collections.Generic;

namespace Fox.Microservices.Claims.Models.Entities
{
    public partial class CL_B_CLAIM_DEVICES_EXT_AUS
    {
        public string COMPANY_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string CLAIM_ID { get; set; }
        public string DEVICE_CODE { get; set; }
        public short? QUANTITY { get; set; }
        public string EAR_SIDE { get; set; }
        public DateTime? DATE_OF_FITTING { get; set; }
        public string TOP_UP_DEVICE { get; set; }
        public decimal? COST_TO_CLIENT { get; set; }
        public decimal? DEVICE_BENEFIT { get; set; }
        public decimal? GST_AMOUNT { get; set; }
        public decimal? TOTAL_DEVICE_BENEFIT { get; set; }
        public DateTime? DT_INSERT { get; set; }
        public string USERINSERT { get; set; }
        public DateTime? DT_UPDATE { get; set; }
        public string USERUPDATE { get; set; }
        public Guid? ROWGUID { get; set; }
    }
}
