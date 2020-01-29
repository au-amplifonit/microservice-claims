using System;
using Fox.Microservices.Claims.Models.Entities.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fox.Microservices.Claims.Models.Entities
{
    public partial class ClaimsContext : DbContext
    {
        public ClaimsContext()
        {
        }

        public ClaimsContext(DbContextOptions<ClaimsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CL_B_CLAIM_DEVICES_EXT_AUS> CL_B_CLAIM_DEVICES_EXT_AUS { get; set; }
        public virtual DbSet<CL_B_CLAIM_EXT_AUS> CL_B_CLAIM_EXT_AUS { get; set; }
        public virtual DbSet<CL_B_CLAIM_ITEMS_EXT_AUS> CL_B_CLAIM_ITEMS_EXT_AUS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=CAU02DB01FOXSIT.D09.ROOT.SYS;Database=FoxAustralia_SIT2;Trusted_Connection=False;User ID=foxuser;Password=Df0x35ZZ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            RegisterStoredProcedurePK(modelBuilder);

            modelBuilder.Entity<CL_B_CLAIM_DEVICES_EXT_AUS>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CLAIM_ID, e.DEVICE_CODE, e.EAR_SIDE })
                    .HasName("PK_CL_B_CLAIM_DEVICES");

                entity.HasIndex(e => e.CLAIM_ID)
                    .HasName("missing_index_18027");

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("missing_index_25973");

                entity.HasIndex(e => new { e.CLAIM_ID, e.EAR_SIDE })
                    .HasName("missing_index_40023");

                entity.HasIndex(e => new { e.CLAIM_ID, e.ROWGUID })
                    .HasName("missing_index_25428");

                entity.HasIndex(e => new { e.DATE_OF_FITTING, e.CLAIM_ID })
                    .HasName("missing_index_18023");

                entity.HasIndex(e => new { e.EAR_SIDE, e.CLAIM_ID })
                    .HasName("missing_index_25276");

                entity.HasIndex(e => new { e.GST_AMOUNT, e.CLAIM_ID })
                    .HasName("missing_index_25090");

                entity.HasIndex(e => new { e.TOTAL_DEVICE_BENEFIT, e.CLAIM_ID })
                    .HasName("missing_index_25088");

                entity.HasIndex(e => new { e.CLAIM_ID, e.DATE_OF_FITTING, e.EAR_SIDE })
                    .HasName("missing_index_25116");

                entity.HasIndex(e => new { e.DATE_OF_FITTING, e.CLAIM_ID, e.EAR_SIDE })
                    .HasName("missing_index_25111");

                entity.HasIndex(e => new { e.DEVICE_CODE, e.EAR_SIDE, e.DATE_OF_FITTING, e.DEVICE_BENEFIT, e.CLAIM_ID })
                    .HasName("missing_index_18030");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CLAIM_ID, e.QUANTITY, e.EAR_SIDE, e.DATE_OF_FITTING, e.TOP_UP_DEVICE, e.COST_TO_CLIENT, e.DEVICE_BENEFIT, e.GST_AMOUNT, e.TOTAL_DEVICE_BENEFIT, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.DEVICE_CODE })
                    .HasName("missing_index_49789");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.CLAIM_ID).HasMaxLength(8);

                entity.Property(e => e.DEVICE_CODE).HasMaxLength(8);

                entity.Property(e => e.EAR_SIDE).HasMaxLength(1);

                entity.Property(e => e.COST_TO_CLIENT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.DATE_OF_FITTING).HasColumnType("datetime");

                entity.Property(e => e.DEVICE_BENEFIT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.GST_AMOUNT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TOP_UP_DEVICE).HasMaxLength(2);

                entity.Property(e => e.TOTAL_DEVICE_BENEFIT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);
            });

            modelBuilder.Entity<CL_B_CLAIM_EXT_AUS>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CLAIM_ID });

                entity.HasIndex(e => e.BATCH_NUMBER)
                    .HasName("missing_index_39509");

                entity.HasIndex(e => e.CLAIM_ID)
                    .HasName("missing_index_39474");

                entity.HasIndex(e => e.CUSTOMER_CODE)
                    .HasName("missing_index_39573");

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("missing_index_39419");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.VOUCHER_ID })
                    .HasName("missing_index_39165");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.CLAIM_ID })
                    .HasName("missing_index_43187");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.STATUS_CODE })
                    .HasName("missing_index_40282");

                entity.HasIndex(e => new { e.DT_UPDATE, e.ROWGUID })
                    .HasName("missing_index_41333");

                entity.HasIndex(e => new { e.STATUS_CODE, e.BATCH_NUMBER })
                    .HasName("missing_index_53305");

                entity.HasIndex(e => new { e.VOUCHER_ID, e.CLAIM_ID })
                    .HasName("missing_index_43157");

                entity.HasIndex(e => new { e.VOUCHER_ID, e.STATUS_CODE })
                    .HasName("missing_index_39398");

                entity.HasIndex(e => new { e.CLAIM_ID, e.STATUS_CODE, e.STATUS_REASON_CODE })
                    .HasName("missing_index_44985");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.BATCH_NUMBER })
                    .HasName("missing_index_44994");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE });

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.VOUCHER_ID })
                    .HasName("missing_index_39406");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.CLINIC_ID, e.CLAIM_ID })
                    .HasName("missing_index_53301");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CLAIM_ID, e.VOUCHER_ID })
                    .HasName("missing_index_43154");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.CLINIC_ID, e.CLAIM_ID, e.IS_CTC })
                    .HasName("missing_index_53360");

                entity.HasIndex(e => new { e.STATUS_CODE, e.VOUCHER_ISSUE_DATE, e.CLAIM_ID, e.VOUCHER_ID })
                    .HasName("missing_index_39394");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.PARENT_CLAIM_ID, e.CLAIM_ID, e.STATUS_CODE })
                    .HasName("missing_index_53307");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.DT_INSERT, e.USERUPDATE, e.APPOINTMENT_ID, e.CLAIM_ID, e.DT_UPDATE })
                    .HasName("missing_index_33031");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.STATUS_CODE, e.CREATION_DATE, e.CLINIC_ID, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.CLAIM_ID, e.USERINSERT })
                    .HasName("missing_index_34486");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.STATUS_CODE, e.CREATION_DATE, e.CLINIC_ID, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.CLAIM_ID, e.CUSTOMER_CODE, e.VOUCHER_ID, e.USERINSERT })
                    .HasName("missing_index_34640");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.CLAIM_ID, e.TYPE_CODE })
                    .HasName("missing_index_42959");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.TYPE_CODE, e.CLAIM_ID })
                    .HasName("missing_index_42957");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.CLAIM_ID, e.STATUS_CODE, e.TYPE_CODE })
                    .HasName("missing_index_43191");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.VOUCHER_ID, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.MAINTENANCE_FEE, e.REPLACEMENT_FEE, e.TOTAL_COST_OF_PRG_TO_CLIENT, e.CLIENT_SIGNED_DATE, e.CLINICIAN_SIGNED_DATE, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.COMPANY_CODE, e.DIVISION_CODE, e.STATUS_CODE })
                    .HasName("missing_index_42902");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.VOUCHER_ID, e.TYPE_CODE, e.CREATION_DATE, e.STATUS_REASON_CODE, e.CLINIC_ID, e.BATCH_NUMBER, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.MAINTENANCE_FEE, e.REPLACEMENT_FEE, e.TOTAL_COST_OF_PRG_TO_CLIENT, e.AUTHORIZED_BY, e.IS_CLIENT_SIGNED, e.CLIENT_SIGNED_DATE, e.IS_CLINICIAN_SIGNED, e.CLINICIAN_SIGNED_DATE, e.IS_CTC, e.PARENT_CLAIM_ID, e.ASSIGNED_TO, e.IS_HOLD, e.ELIGIBLE_FOR_HEARING_SERVICE, e.TOTAL_ITEM_QUATITY, e.TOTAL_DEVICE_QUATITIY, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.IS_ADHOC_CLAIM, e.HAS_CHILD, e.CLAIM_ID, e.COMPANY_CODE, e.DIVISION_CODE, e.STATUS_CODE })
                    .HasName("missing_index_39102");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.TYPE_CODE, e.CREATION_DATE, e.STATUS_REASON_CODE, e.CLINIC_ID, e.BATCH_NUMBER, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.MAINTENANCE_FEE, e.REPLACEMENT_FEE, e.TOTAL_COST_OF_PRG_TO_CLIENT, e.AUTHORIZED_BY, e.IS_CLIENT_SIGNED, e.CLIENT_SIGNED_DATE, e.IS_CLINICIAN_SIGNED, e.CLINICIAN_SIGNED_DATE, e.IS_CTC, e.PARENT_CLAIM_ID, e.ASSIGNED_TO, e.IS_HOLD, e.ELIGIBLE_FOR_HEARING_SERVICE, e.TOTAL_ITEM_QUATITY, e.TOTAL_DEVICE_QUATITIY, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.MCP_REASON_CODE, e.VOUCHER_ISSUE_DATE, e.APPOINTMENT_ID, e.PROCESSED_DATE, e.STATUS_REASON_DESCR, e.IS_ADHOC_CLAIM, e.HAS_CHILD, e.PTA1_L, e.PTA1_R, e.CLAIM_ID })
                    .HasName("missing_index_53659");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.CREATION_DATE, e.STATUS_REASON_CODE, e.CLINIC_ID, e.BATCH_NUMBER, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.MAINTENANCE_FEE, e.REPLACEMENT_FEE, e.TOTAL_COST_OF_PRG_TO_CLIENT, e.AUTHORIZED_BY, e.IS_CLIENT_SIGNED, e.CLIENT_SIGNED_DATE, e.IS_CLINICIAN_SIGNED, e.CLINICIAN_SIGNED_DATE, e.IS_CTC, e.PARENT_CLAIM_ID, e.ASSIGNED_TO, e.IS_HOLD, e.ELIGIBLE_FOR_HEARING_SERVICE, e.TOTAL_ITEM_QUATITY, e.TOTAL_DEVICE_QUATITIY, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.MCP_REASON_CODE, e.VOUCHER_ISSUE_DATE, e.APPOINTMENT_ID, e.PROCESSED_DATE, e.STATUS_REASON_DESCR, e.IS_ADHOC_CLAIM, e.HAS_CHILD, e.CLAIM_ID, e.PTA1_L, e.PTA1_R, e.STATUS_CODE, e.TYPE_CODE })
                    .HasName("missing_index_42954");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.STATUS_CODE, e.TYPE_CODE, e.CREATION_DATE, e.STATUS_REASON_CODE, e.CLINIC_ID, e.BATCH_NUMBER, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.MAINTENANCE_FEE, e.REPLACEMENT_FEE, e.TOTAL_COST_OF_PRG_TO_CLIENT, e.AUTHORIZED_BY, e.IS_CLIENT_SIGNED, e.CLIENT_SIGNED_DATE, e.IS_CLINICIAN_SIGNED, e.CLINICIAN_SIGNED_DATE, e.IS_CTC, e.PARENT_CLAIM_ID, e.ASSIGNED_TO, e.IS_HOLD, e.ELIGIBLE_FOR_HEARING_SERVICE, e.TOTAL_ITEM_QUATITY, e.TOTAL_DEVICE_QUATITIY, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.MCP_REASON_CODE, e.VOUCHER_ISSUE_DATE, e.APPOINTMENT_ID, e.PROCESSED_DATE, e.STATUS_REASON_DESCR, e.IS_ADHOC_CLAIM, e.HAS_CHILD, e.PTA1_L, e.PTA1_R, e.CLAIM_ID })
                    .HasName("missing_index_53345");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.VOUCHER_ID, e.TYPE_CODE, e.CREATION_DATE, e.CLINIC_ID, e.BATCH_NUMBER, e.TOTAL_COST_OF_FITTING_BENEFIT, e.TOTAL_COST_OF_FITTING_GST_AMT, e.TOTAL_BENEFIT_COST_OF_FITTING, e.MAINTENANCE_FEE, e.REPLACEMENT_FEE, e.TOTAL_COST_OF_PRG_TO_CLIENT, e.AUTHORIZED_BY, e.IS_CLIENT_SIGNED, e.CLIENT_SIGNED_DATE, e.IS_CLINICIAN_SIGNED, e.CLINICIAN_SIGNED_DATE, e.IS_CTC, e.PARENT_CLAIM_ID, e.ASSIGNED_TO, e.IS_HOLD, e.ELIGIBLE_FOR_HEARING_SERVICE, e.TOTAL_ITEM_QUATITY, e.TOTAL_DEVICE_QUATITIY, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.MCP_REASON_CODE, e.VOUCHER_ISSUE_DATE, e.APPOINTMENT_ID, e.PROCESSED_DATE, e.STATUS_REASON_DESCR, e.IS_ADHOC_CLAIM, e.HAS_CHILD, e.CLAIM_ID, e.PTA1_L, e.PTA1_R, e.STATUS_CODE, e.STATUS_REASON_CODE })
                    .HasName("missing_index_44980");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.CLAIM_ID).HasMaxLength(8);

                entity.Property(e => e.APPOINTMENT_ID).HasMaxLength(10);

                entity.Property(e => e.ASSIGNED_TO).HasMaxLength(15);

                entity.Property(e => e.AUTHORIZED_BY).HasMaxLength(50);

                entity.Property(e => e.CLIENT_SIGNED_DATE).HasColumnType("datetime");

                entity.Property(e => e.CLINICIAN_SIGNED_DATE).HasColumnType("datetime");

                entity.Property(e => e.CLINIC_ID).HasMaxLength(3);

                entity.Property(e => e.CREATION_DATE).HasColumnType("datetime");

                entity.Property(e => e.CUSTOMER_CODE)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.ELIGIBLE_FOR_HEARING_SERVICE).HasMaxLength(1);

                entity.Property(e => e.HAS_CHILD).HasMaxLength(1);

                entity.Property(e => e.IS_ADHOC_CLAIM).HasMaxLength(1);

                entity.Property(e => e.IS_CLIENT_SIGNED).HasMaxLength(1);

                entity.Property(e => e.IS_CLINICIAN_SIGNED).HasMaxLength(1);

                entity.Property(e => e.IS_CTC).HasMaxLength(1);

                entity.Property(e => e.IS_HOLD).HasMaxLength(1);

                entity.Property(e => e.MAINTENANCE_FEE).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.MCP_REASON_CODE).HasMaxLength(8);

                entity.Property(e => e.PARENT_CLAIM_ID).HasMaxLength(15);

                entity.Property(e => e.PROCESSED_DATE).HasColumnType("datetime");

                entity.Property(e => e.PTA1_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA1_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.REPLACEMENT_FEE).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.STATUS_CODE)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.STATUS_REASON_CODE).HasMaxLength(10);

                entity.Property(e => e.STATUS_REASON_DESCR).HasMaxLength(255);

                entity.Property(e => e.TOTAL_BENEFIT_COST_OF_FITTING).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.TOTAL_COST_OF_FITTING_BENEFIT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.TOTAL_COST_OF_FITTING_GST_AMT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.TOTAL_COST_OF_PRG_TO_CLIENT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.TYPE_CODE)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);

                entity.Property(e => e.VOUCHER_ID)
                    .IsRequired()
                    .HasMaxLength(19);

                entity.Property(e => e.VOUCHER_ISSUE_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<CL_B_CLAIM_ITEMS_EXT_AUS>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CLAIM_ID, e.ITEM_NUMBER })
                    .HasName("pk_CL_B_CLAIM_ITEMS_EXT_AUS");

                entity.HasIndex(e => e.CLAIM_ID)
                    .HasName("missing_index_18138");

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("missing_index_25322");

                entity.HasIndex(e => new { e.CLAIM_ID, e.DATE_OF_SERVICE })
                    .HasName("missing_index_44987");

                entity.HasIndex(e => new { e.CLAIM_ID, e.ITEM_NUMBER })
                    .HasName("missing_index_25077");

                entity.HasIndex(e => new { e.DT_UPDATE, e.ROWGUID })
                    .HasName("missing_index_31474");

                entity.HasIndex(e => new { e.ITEM_NUMBER, e.CLAIM_ID })
                    .HasName("missing_index_32683");

                entity.HasIndex(e => new { e.SITE_ID, e.CLAIM_ID })
                    .HasName("missing_index_25468");

                entity.HasIndex(e => new { e.CLAIM_ID, e.DATE_OF_SERVICE, e.ITEM_NUMBER })
                    .HasName("missing_index_25102");

                entity.HasIndex(e => new { e.CLAIM_ID, e.ITEM_NUMBER, e.DATE_OF_SERVICE })
                    .HasName("missing_index_25287");

                entity.HasIndex(e => new { e.CLAIM_ID, e.ITEM_NUMBER, e.ROWGUID })
                    .HasName("missing_index_25029");

                entity.HasIndex(e => new { e.ITEM_NUMBER, e.CLAIM_ID, e.DATE_OF_SERVICE })
                    .HasName("missing_index_25283");

                entity.HasIndex(e => new { e.ITEM_NUMBER, e.DATE_OF_SERVICE, e.CLAIM_ID })
                    .HasName("missing_index_25280");

                entity.HasIndex(e => new { e.ITEM_REASON_CODE, e.COMPANY_CODE, e.CLAIM_ID })
                    .HasName("missing_index_17909");

                entity.HasIndex(e => new { e.ITEM_NUMBER, e.DATE_OF_SERVICE, e.TOTAL_BENEFIT, e.AMOUNT_PAID, e.CLAIM_ID })
                    .HasName("missing_index_18025");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.GST_AMOUNT, e.TOTAL_BENEFIT, e.CLAIM_ID, e.ITEM_NUMBER })
                    .HasName("missing_index_25092");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CLAIM_ID, e.QUANTITY, e.DATE_OF_SERVICE, e.SITE_ID, e.PRACTIONER_NUMBER, e.COST_TO_CLIENT, e.ITEM_BENEFIT, e.GST_AMOUNT, e.TOTAL_BENEFIT, e.ITEM_REASON_CODE, e.DT_INSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.GST_PAID, e.WHT_PAID, e.AMOUNT_PAID, e.LINE_NUMBER, e.ITEM_NUMBER, e.USERINSERT })
                    .HasName("missing_index_18190");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CLAIM_ID, e.QUANTITY, e.DATE_OF_SERVICE, e.SITE_ID, e.PRACTIONER_NUMBER, e.COST_TO_CLIENT, e.ITEM_BENEFIT, e.GST_AMOUNT, e.TOTAL_BENEFIT, e.ITEM_REASON_CODE, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.GST_PAID, e.WHT_PAID, e.AMOUNT_PAID, e.LINE_NUMBER, e.ITEM_NUMBER })
                    .HasName("missing_index_18105");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.ITEM_NUMBER, e.QUANTITY, e.DATE_OF_SERVICE, e.SITE_ID, e.PRACTIONER_NUMBER, e.COST_TO_CLIENT, e.ITEM_BENEFIT, e.GST_AMOUNT, e.TOTAL_BENEFIT, e.ITEM_REASON_CODE, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.GST_PAID, e.WHT_PAID, e.AMOUNT_PAID, e.LINE_NUMBER, e.CLAIM_ID })
                    .HasName("missing_index_25151");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.QUANTITY, e.DATE_OF_SERVICE, e.SITE_ID, e.PRACTIONER_NUMBER, e.COST_TO_CLIENT, e.ITEM_BENEFIT, e.GST_AMOUNT, e.TOTAL_BENEFIT, e.ITEM_REASON_CODE, e.DT_INSERT, e.USERINSERT, e.DT_UPDATE, e.USERUPDATE, e.ROWGUID, e.GST_PAID, e.WHT_PAID, e.AMOUNT_PAID, e.LINE_NUMBER, e.CLAIM_ID, e.ITEM_NUMBER })
                    .HasName("missing_index_32675");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.CLAIM_ID).HasMaxLength(8);

                entity.Property(e => e.AMOUNT_PAID).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.COST_TO_CLIENT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.DATE_OF_SERVICE).HasColumnType("datetime");

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.GST_AMOUNT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.GST_PAID).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.ITEM_BENEFIT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.ITEM_REASON_CODE).HasMaxLength(10);

                entity.Property(e => e.PRACTIONER_NUMBER).HasMaxLength(15);

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.SITE_ID).HasMaxLength(15);

                entity.Property(e => e.TOTAL_BENEFIT).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);

                entity.Property(e => e.WHT_PAID).HasColumnType("numeric(8, 2)");
            });

            modelBuilder.HasSequence("NextFoxid").StartsAt(0);

            modelBuilder.HasSequence("GETNEXTBATCHNUMBER").StartsAt(200);

            modelBuilder.HasSequence("NextFoxCouponid").StartsAt(0);

            modelBuilder.HasSequence("NextFoxid").StartsAt(4000);

            modelBuilder.HasSequence("NextFoxVoucherId");
        }
    }
}
