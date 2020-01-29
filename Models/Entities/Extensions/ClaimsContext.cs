using Fox.Microservices.Claims.Models.Entities.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fox.Microservices.Claims.Models.Entities
{
    public partial class ClaimsContext : DbContext
    {
        public virtual DbSet<p_CL_B_CLAIM_EXT_AUS_GetAll_Result> p_CL_B_CLAIM_EXT_AUS_GetAll_Result { get; set; }

        //TODO: REMEMBER TO ADD THIS CALL TO THE OnModelCreating OF THE DBContext each time it's updated
        protected void RegisterStoredProcedurePK(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<p_CL_B_CLAIM_EXT_AUS_GetAll_Result>().HasKey(table => new
            {
                table.COMPANY_CODE,
                table.DIVISION_CODE,
                table.CUSTOMER_CODE,
                table.CLAIM_ID,
                table.ITEM_NUMBER,
                table.EAR_SIDE
            }).HasName("PK_p_CL_B_CLAIM_EXT_AUS_GetAll_Result");
        }
    }
}
