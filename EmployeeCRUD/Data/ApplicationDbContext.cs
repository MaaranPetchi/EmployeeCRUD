using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Spreadsheet;
using EmployeeCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EmployeeCRUD.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
       
        public ApplicationDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Server = tcp:kryptosinatechpoc.database.windows.net,1433; Initial Catalog = kryptosinatechpocdb; Persist Security Info = False; User ID = kryptos; Password = Password@1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");
            options.UseSqlServer(connectionString);
        }
        internal void BulkInsert()
        {
            throw new NotImplementedException();
        }

        public DbSet<UsersConsumptionData> UsersConsumptionReport { get; set; }

        public DbSet<EmployeeCRUD.Models.Login> Login { get; set; }

        public DbSet<EmployeeCRUD.Models.SignUp> SignUp { get; set; }
         
        
         
        public DbSet<EmployeeCRUD.Models.Fileupload> Fileupload { get; set; }

        public DbSet<MeteringData> MeterData { get; set; }
        public DbSet<MeterFileUpload> MeterFileUploads { get; set; }

        public DbSet<RIExcelname>RIExcelUploads { get; set; }
        public DbSet<NonRIExcelname> NonRIExcelUploads { get; set; }

        public DbSet<RIBillingFile> RiBillingfile { get; set; }
        public DbSet<NonRiBillingFile> NonRiBillingfile { get; set; }

        public DbSet<UsersConsumptionData> ManualUserConsumptionData { get; set; }
        public DbSet<UserConsumptionUpload> UserConsumptionDataFileUpload { get; set; }

        public DbSet<UserConsumptionExcelModel> UserConsumptionRecords { get; set; }

        public DbSet<ExisitingUserConsumptionData> ExisitingName { get; set; }

    }

}
