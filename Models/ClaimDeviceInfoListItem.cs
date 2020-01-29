using Fox.Microservices.Claims.Models.Entities.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Claims.Models
{
    public class ClaimDeviceInfoListItem
    {
        public string DeviceID { get; set; }
        public DateTime? DateOfService { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public decimal? BilledAmount { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public string SideCode { get; set; }

        public ClaimDeviceInfoListItem()
        {

        }

        public ClaimDeviceInfoListItem(p_CL_B_CLAIM_EXT_AUS_GetAll_Result Entity)
        {
            DeviceID = Entity.ITEM_NUMBER;
            DateOfService = Entity.SERVICE_DATE;
            ProcessedDate = Entity.PROCESSED_DATE;
            BilledAmount = Entity.OHS_BILLED;
            ReceivedAmount = Entity.OHS_RECEIVED;
            SideCode = Entity.EAR_SIDE;
        }
    }
}
