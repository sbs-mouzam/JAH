namespace DataAccessLayer.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JamiatDb : DbContext
    {
        public JamiatDb()
            : base("name=JamiatDb")
        {
        }

        public virtual DbSet<BoardMember> BoardMembers { get; set; }
        public virtual DbSet<BoardRequestProcess> BoardRequestProcesses { get; set; }
        public virtual DbSet<BoardType> BoardTypes { get; set; }
        public virtual DbSet<EventRequest> EventRequests { get; set; }
        public virtual DbSet<EventRequestDetail> EventRequestDetails { get; set; }
        public virtual DbSet<ExistingMadarsaOperationsRequest> ExistingMadarsaOperationsRequests { get; set; }
        public virtual DbSet<Halqa> Halqas { get; set; }
        public virtual DbSet<Madarsa> Madarsas { get; set; }
        public virtual DbSet<MadarsaConstructionRequest> MadarsaConstructionRequests { get; set; }
        public virtual DbSet<MadarsaExtensionRequest> MadarsaExtensionRequests { get; set; }
        public virtual DbSet<MadarsaLandRequest> MadarsaLandRequests { get; set; }
        public virtual DbSet<Masjid> Masjids { get; set; }
        public virtual DbSet<MasjidConstructionRequest> MasjidConstructionRequests { get; set; }
        public virtual DbSet<MasjidExtensionRequest> MasjidExtensionRequests { get; set; }
        public virtual DbSet<MasjidLandRequest> MasjidLandRequests { get; set; }
        public virtual DbSet<MasjidRenovationRequest> MasjidRenovationRequests { get; set; }
        public virtual DbSet<NewMadarsaOperationsRequest> NewMadarsaOperationsRequests { get; set; }
        public virtual DbSet<PanelMember> PanelMembers { get; set; }
        public virtual DbSet<PanelRequestProcess> PanelRequestProcesses { get; set; }
        public virtual DbSet<PanelType> PanelTypes { get; set; }
        public virtual DbSet<RequestSubmit> RequestSubmits { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardMember>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BoardMember>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<BoardMember>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<BoardMember>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<BoardMember>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<BoardMember>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<BoardRequestProcess>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<BoardRequestProcess>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<BoardRequestProcess>()
                .HasMany(e => e.PanelRequestProcesses)
                .WithOptional(e => e.BoardRequestProcess)
                .HasForeignKey(e => e.BoardMemberId);

            modelBuilder.Entity<BoardType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequest>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequest>()
                .Property(e => e.TotalSpeakers)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequest>()
                .Property(e => e.Venu)
                .IsUnicode(false);

            modelBuilder.Entity<EventRequestDetail>()
                .Property(e => e.SpeakerName)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Girls)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Boys)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Teachers)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.MonthlyConst)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.CostPerStudent)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.RevenueSource)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.TotalLandArea)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.ConstructedArea)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.IsRented)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.IfChargingHowmuch)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<ExistingMadarsaOperationsRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<Halqa>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Madarsa>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Madarsa>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Madarsa>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<Madarsa>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.ConstructionCost)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.ExistingFloors)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.AmountNeeded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Engineer)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Elevation)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Paln)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaConstructionRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.ConstructionCost)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.ExistingFloors)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.AmountNeeded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Engineer)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Elevation)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Paln)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaExtensionRequest>()
                .HasOptional(e => e.MadarsaExtensionRequest1)
                .WithRequired(e => e.MadarsaExtensionRequest2);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.TimePeriod)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.AmountPaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.AmountNeeded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.LandArea)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.LandPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.PurchasingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<MadarsaLandRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<Masjid>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Masjid>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Masjid>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<Masjid>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.ConstructionCost)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.ExistingFloors)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.AmountNeeded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Engineer)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Elevation)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Paln)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidConstructionRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.ConstructionCost)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.ExistingFloors)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.AmountNeeded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Engineer)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Elevation)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Paln)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidExtensionRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.TimePeriod)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.AmountPaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.AmountNeeded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.LandArea)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.LandPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.PurchasingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidLandRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.ConstructionCost)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.ExistingFloors)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.AmountNeeded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Engineer)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Elevation)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Paln)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<MasjidRenovationRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.ExpectedStudents)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Girls)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Boys)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Teachers)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.MonthlyConst)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.CostPerStudent)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.RevenueSource)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.TotalLandArea)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.ConstructedArea)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.IsRented)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.IfChargingHowmuch)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Doc1)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Doc2)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Doc3)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Pic1)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Pic2)
                .IsUnicode(false);

            modelBuilder.Entity<NewMadarsaOperationsRequest>()
                .Property(e => e.Pic3)
                .IsUnicode(false);

            modelBuilder.Entity<PanelMember>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PanelMember>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PanelMember>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<PanelMember>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<PanelMember>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<PanelMember>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<PanelRequestProcess>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<PanelRequestProcess>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<PanelType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RequestSubmit>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<RequestSubmit>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<RequestType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RequestType>()
                .HasMany(e => e.ExistingMadarsaOperationsRequests)
                .WithOptional(e => e.RequestType1)
                .HasForeignKey(e => e.RequestType);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Madarsas)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserIdHead);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Masjids)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserIdHead);

            modelBuilder.Entity<UserType>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
