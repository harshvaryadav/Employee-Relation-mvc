using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Employee_Relation.Models
{
    public partial class ACE42023Context : DbContext
    {
        public ACE42023Context()
        {
        }

        public ACE42023Context(DbContextOptions<ACE42023Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ArtUser> ArtUsers { get; set; } = null!;
        public virtual DbSet<Artistishan> Artistishans { get; set; } = null!;
        public virtual DbSet<Authorhritik> Authorhritiks { get; set; } = null!;
        public virtual DbSet<AvaniOrder> AvaniOrders { get; set; } = null!;
        public virtual DbSet<AvaniPerson> AvaniPersons { get; set; } = null!;
        public virtual DbSet<Bookhritik> Bookhritiks { get; set; } = null!;
        public virtual DbSet<Bookuserhritik> Bookuserhritiks { get; set; } = null!;
        public virtual DbSet<BrijeshBuyer> BrijeshBuyers { get; set; } = null!;
        public virtual DbSet<BrijeshProperty> BrijeshProperties { get; set; } = null!;
        public virtual DbSet<BrijeshSeller> BrijeshSellers { get; set; } = null!;
        public virtual DbSet<BrijeshTran> BrijeshTrans { get; set; } = null!;
        public virtual DbSet<Companyawa> Companyawas { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<DeptFrp> DeptFrps { get; set; } = null!;
        public virtual DbSet<DeptRahul> DeptRahuls { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<EmpArpit> EmpArpits { get; set; } = null!;
        public virtual DbSet<EmpAvaneshwari> EmpAvaneshwaris { get; set; } = null!;
        public virtual DbSet<EmpBrijesh> EmpBrijeshes { get; set; } = null!;
        public virtual DbSet<EmpDaksh> EmpDakshes { get; set; } = null!;
        public virtual DbSet<EmpHarsh> EmpHarshes { get; set; } = null!;
        public virtual DbSet<EmpHarshitBranch> EmpHarshitBranches { get; set; } = null!;
        public virtual DbSet<EmpHritik> EmpHritiks { get; set; } = null!;
        public virtual DbSet<EmpIshwar> EmpIshwars { get; set; } = null!;
        public virtual DbSet<EmpJaivardhan> EmpJaivardhans { get; set; } = null!;
        public virtual DbSet<EmpMana> EmpManas { get; set; } = null!;
        public virtual DbSet<EmpPrem> EmpPrems { get; set; } = null!;
        public virtual DbSet<EmpSatyam> EmpSatyams { get; set; } = null!;
        public virtual DbSet<EmpUseravani> EmpUseravanis { get; set; } = null!;
        public virtual DbSet<Empawanish> Empawanishes { get; set; } = null!;
        public virtual DbSet<Empharshit> Empharshits { get; set; } = null!;
        public virtual DbSet<Empishan> Empishans { get; set; } = null!;
        public virtual DbSet<Empprabhat> Empprabhats { get; set; } = null!;
        public virtual DbSet<EmpsRahul> EmpsRahuls { get; set; } = null!;
        public virtual DbSet<EmpsSameer> EmpsSameers { get; set; } = null!;
        public virtual DbSet<EmpsSuneet> EmpsSuneets { get; set; } = null!;
        public virtual DbSet<Empsuppawanish> Empsuppawanishes { get; set; } = null!;
        public virtual DbSet<FlightAvani> FlightAvanis { get; set; } = null!;
        public virtual DbSet<Flightawa> Flightawas { get; set; } = null!;
        public virtual DbSet<IBooking> IBookings { get; set; } = null!;
        public virtual DbSet<IFlight> IFlights { get; set; } = null!;
        public virtual DbSet<IUser> IUsers { get; set; } = null!;
        public virtual DbSet<LoginAwa> LoginAwas { get; set; } = null!;
        public virtual DbSet<ManasFerry> ManasFerries { get; set; } = null!;
        public virtual DbSet<ManasPort> ManasPorts { get; set; } = null!;
        public virtual DbSet<ManasTicket> ManasTickets { get; set; } = null!;
        public virtual DbSet<ManasUser> ManasUsers { get; set; } = null!;
        public virtual DbSet<Painting> Paintings { get; set; } = null!;
        public virtual DbSet<PremAttendance> PremAttendances { get; set; } = null!;
        public virtual DbSet<PremEmployee> PremEmployees { get; set; } = null!;
        public virtual DbSet<RahulBook> RahulBooks { get; set; } = null!;
        public virtual DbSet<RahulBooking> RahulBookings { get; set; } = null!;
        public virtual DbSet<RahulUser> RahulUsers { get; set; } = null!;
        public virtual DbSet<SuneetDept> SuneetDepts { get; set; } = null!;
        public virtual DbSet<SuneetEmployee> SuneetEmployees { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<TransactionVrm> TransactionVrms { get; set; } = null!;
        public virtual DbSet<UserList> UserLists { get; set; } = null!;
        public virtual DbSet<UserPrem> UserPrems { get; set; } = null!;
        public virtual DbSet<Userbtl> Userbtls { get; set; } = null!;
        public virtual DbSet<Userbtlishan> Userbtlishans { get; set; } = null!;
        public virtual DbSet<Userhritik> Userhritiks { get; set; } = null!;
        public virtual DbSet<UsersRahul> UsersRahuls { get; set; } = null!;
        public virtual DbSet<Usertbl> Usertbls { get; set; } = null!;
        public virtual DbSet<Usertbl2> Usertbl2s { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DEVSQL.corp.local;Database=ACE 4- 2023;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__art_user__DD70126488BB7E01");

                entity.ToTable("art_user");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Uname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("uname");
            });

            modelBuilder.Entity<Artistishan>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__artistis__DE508E2E425390CD");

                entity.ToTable("artistishan");

                entity.Property(e => e.Aid)
                    .ValueGeneratedNever()
                    .HasColumnName("aid");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Birthplace)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("birthplace");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.StyleOfWork)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("style_of_work");
            });

            modelBuilder.Entity<Authorhritik>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__authorhr__C6970A10555A5A05");

                entity.ToTable("authorhritik");

                entity.Property(e => e.Aid).ValueGeneratedNever();

                entity.Property(e => e.Aname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AvaniOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__avaniOrd__C3905BAFEEC2DAC7");

                entity.ToTable("avaniOrders");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AvaniOrders)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__avaniOrde__Perso__6D0D32F4");
            });

            modelBuilder.Entity<AvaniPerson>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK__avaniPer__AA2FFBE550F40911");

                entity.ToTable("avaniPersons");

                entity.Property(e => e.PersonId).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bookhritik>(entity =>
            {
                entity.HasKey(e => e.Bookid)
                    .HasName("PK__bookhrit__8BEA95C5A0B3FD2E");

                entity.ToTable("bookhritik");

                entity.Property(e => e.Bookid)
                    .ValueGeneratedNever()
                    .HasColumnName("bookid");

                entity.Property(e => e.Authorid).HasColumnName("authorid");

                entity.Property(e => e.Genre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("genre");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Year)
                    .HasColumnType("date")
                    .HasColumnName("year");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Bookhritiks)
                    .HasForeignKey(d => d.Authorid)
                    .HasConstraintName("FK__bookhriti__autho__1F98B2C1");
            });

            modelBuilder.Entity<Bookuserhritik>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__bookuser__C5B69A4AC4341A6F");

                entity.ToTable("bookuserhritik");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrijeshBuyer>(entity =>
            {
                entity.HasKey(e => e.BuyerId)
                    .HasName("PK__Brijesh___BAD1715251431297");

                entity.ToTable("Brijesh_buyer");

                entity.Property(e => e.BuyerId)
                    .ValueGeneratedNever()
                    .HasColumnName("buyer_id");

                entity.Property(e => e.BuyerName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("buyer_name");

                entity.Property(e => e.BuyerPassword)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("buyer_password");
            });

            modelBuilder.Entity<BrijeshProperty>(entity =>
            {
                entity.HasKey(e => e.PropertyId)
                    .HasName("PK__Brijesh___735BA463E5D56375");

                entity.ToTable("Brijesh_property");

                entity.Property(e => e.PropertyId)
                    .ValueGeneratedNever()
                    .HasColumnName("property_id");

                entity.Property(e => e.Loc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("loc");

                entity.Property(e => e.PName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.SellerpId).HasColumnName("sellerp_id");

                entity.HasOne(d => d.Sellerp)
                    .WithMany(p => p.BrijeshProperties)
                    .HasForeignKey(d => d.SellerpId)
                    .HasConstraintName("FK__Brijesh_p__selle__4C6B5938");
            });

            modelBuilder.Entity<BrijeshSeller>(entity =>
            {
                entity.HasKey(e => e.SellerId)
                    .HasName("PK__Brijesh___780A0A9702CCDD3D");

                entity.ToTable("Brijesh_seller");

                entity.Property(e => e.SellerId)
                    .ValueGeneratedNever()
                    .HasColumnName("seller_id");

                entity.Property(e => e.SellerName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("seller_name");

                entity.Property(e => e.SellerPassword)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("seller_password");
            });

            modelBuilder.Entity<BrijeshTran>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("PK__brijesh___438CAC186C2792EF");

                entity.ToTable("brijesh_trans");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.BuyertId).HasColumnName("buyert_id");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.PropId).HasColumnName("prop_id");

                entity.HasOne(d => d.Buyert)
                    .WithMany(p => p.BrijeshTrans)
                    .HasForeignKey(d => d.BuyertId)
                    .HasConstraintName("FK__brijesh_t__buyer__4E53A1AA");

                entity.HasOne(d => d.Prop)
                    .WithMany(p => p.BrijeshTrans)
                    .HasForeignKey(d => d.PropId)
                    .HasConstraintName("FK__brijesh_t__prop___4F47C5E3");
            });

            modelBuilder.Entity<Companyawa>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__companya__D837D05FC2E68D49");

                entity.ToTable("companyawa");

                entity.Property(e => e.Cid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cname");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__Customer__CBA1B257F2C4ED15");

                entity.ToTable("Customer");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<DeptFrp>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__dept_frp__C03122187BC50FC9");

                entity.ToTable("dept_frp");

                entity.Property(e => e.Did).ValueGeneratedNever();

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfEmployees).HasColumnName("No_of_employees");
            });

            modelBuilder.Entity<DeptRahul>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__dept_rah__D877D216FF2C365C");

                entity.ToTable("dept_rahul");

                entity.Property(e => e.Did)
                    .ValueGeneratedNever()
                    .HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dname");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Emp__C1971B53F11D094C");

                entity.ToTable("Emp");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Awards)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TeamLead)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Team_Lead");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Team_Name");

                entity.HasOne(d => d.TeamNameNavigation)
                    .WithMany(p => p.Emps)
                    .HasForeignKey(d => d.TeamName)
                    .HasConstraintName("FK__Emp__Team_Name__336AA144");
            });

            modelBuilder.Entity<EmpArpit>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__EmpArpit__D9509F6D748FA414");

                entity.ToTable("EmpArpit");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpAvaneshwari>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empAvane__D9509F6DDA2524D9");

                entity.ToTable("empAvaneshwari");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpBrijesh>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empBrije__D9509F6DFBBCEE86");

                entity.ToTable("empBrijesh");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpDaksh>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__EmpDaksh__C1971B53E4E8E96D");

                entity.ToTable("EmpDaksh");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpHarsh>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__EmpHarsh__C1971B533A73B3F7");

                entity.ToTable("EmpHarsh");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpHarshitBranch>(entity =>
            {
                entity.ToTable("empHarshitBranch");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branch_name");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpHarshitBranches)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__empHarshi__emp_i__73BA3083");
            });

            modelBuilder.Entity<EmpHritik>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empHriti__D9509F6D9EBABC74");

                entity.ToTable("empHritik");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpIshwar>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empIshwa__D9509F6D71EE07E4");

                entity.ToTable("empIshwar");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpJaivardhan>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empJaiva__D9509F6D2BCB7371");

                entity.ToTable("empJaivardhan");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<EmpMana>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("empManas");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpPrem>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empPrem__D9509F6D27559C2D");

                entity.ToTable("empPrem");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpSatyam>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__EmpSatya__D9509F6D23134A4E");

                entity.ToTable("empSatyam");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpUseravani>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__empUsera__C5B69A4A38D0985D");

                entity.ToTable("empUseravani");

                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.Uname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Upassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empawanish>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empawani__C1971B537D8161BB");

                entity.ToTable("empawanish");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.SId).HasColumnName("S_id");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.SIdNavigation)
                    .WithMany(p => p.Empawanishes)
                    .HasForeignKey(d => d.SId)
                    .HasConstraintName("FK__empawanish__S_id__68487DD7");
            });

            modelBuilder.Entity<Empharshit>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empharsh__D9509F6D853D881C");

                entity.ToTable("empharshit");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Empishan>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empishan__D9509F6DC5134935");

                entity.ToTable("empishan");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Empprabhat>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empprabh__D9509F6DB7BF358E");

                entity.ToTable("empprabhat");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpsRahul>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empsRahu__D9509F6DEC4CB700");

                entity.ToTable("empsRahul");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Ecity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ecity");

                entity.Property(e => e.Edoj)
                    .HasColumnType("date")
                    .HasColumnName("edoj")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Esal).HasColumnName("esal");
            });

            modelBuilder.Entity<EmpsSameer>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empsSame__D9509F6D10A6543F");

                entity.ToTable("empsSameer");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Ecity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ecity");

                entity.Property(e => e.Edoj)
                    .HasColumnType("date")
                    .HasColumnName("edoj")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Esal).HasColumnName("esal");
            });

            modelBuilder.Entity<EmpsSuneet>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empsSune__D9509F6D3F2EB727");

                entity.ToTable("empsSuneet");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Ecity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ecity");

                entity.Property(e => e.Edoj)
                    .HasColumnType("date")
                    .HasColumnName("edoj")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Esal).HasColumnName("esal");
            });

            modelBuilder.Entity<Empsuppawanish>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("PK__empsuppa__A3DCCCA5B9ECAFAA");

                entity.ToTable("empsuppawanish");

                entity.Property(e => e.SId)
                    .ValueGeneratedNever()
                    .HasColumnName("S_id");

                entity.Property(e => e.Sname)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlightAvani>(entity =>
            {
                entity.HasKey(e => e.FlightNo)
                    .HasName("PK__flightAv__E3700CB103A7E6CB");

                entity.ToTable("flightAvani");

                entity.Property(e => e.FlightNo)
                    .ValueGeneratedNever()
                    .HasColumnName("flight_no");

                entity.Property(e => e.AirlinesName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("airlines_name");

                entity.Property(e => e.Departure)
                    .HasColumnType("date")
                    .HasColumnName("departure");

                entity.Property(e => e.GoingTo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("going_to");

                entity.Property(e => e.LeaveFrom)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("leave_from");

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.StateSold).HasColumnName("state_sold");
            });

            modelBuilder.Entity<Flightawa>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__flightaw__DD70126433F9F42F");

                entity.ToTable("flightawa");

                entity.Property(e => e.Uid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("uid");

                entity.Property(e => e.Cid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cid");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.JFrom)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("j_from");

                entity.Property(e => e.JTo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("j_to");

                entity.Property(e => e.Uname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("uname");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.Flightawas)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK__flightawa__cid__42E1EEFE");
            });

            modelBuilder.Entity<IBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__iBooking__5DE3A5B10159E289");

                entity.ToTable("iBookings");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("booking_id");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("date")
                    .HasColumnName("booking_date");

                entity.Property(e => e.FlightId).HasColumnName("flight_id");

                entity.Property(e => e.SeatNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("seat_number");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.IBookings)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__iBookings__fligh__41B8C09B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IBookings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__iBookings__user___40C49C62");
            });

            modelBuilder.Entity<IFlight>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK__iFlights__E3705765959FAB65");

                entity.ToTable("iFlights");

                entity.Property(e => e.FlightId)
                    .ValueGeneratedNever()
                    .HasColumnName("flight_id");

                entity.Property(e => e.AvailableSeats).HasColumnName("available_seats");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("destination");

                entity.Property(e => e.FlightDate)
                    .HasColumnType("date")
                    .HasColumnName("flight_date");

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flight_number");

                entity.Property(e => e.FlightPrice).HasColumnName("flight_price");

                entity.Property(e => e.FlightTime).HasColumnName("flight_time");

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("origin");
            });

            modelBuilder.Entity<IUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__iUsers__B9BE370F2D23F7C0");

                entity.ToTable("iUsers");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_password");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("user_phone");
            });

            modelBuilder.Entity<LoginAwa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("login_awa");

                entity.Property(e => e.Pword)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("pword");

                entity.Property(e => e.Userid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("userid");

                entity.Property(e => e.Usernm)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("usernm");
            });

            modelBuilder.Entity<ManasFerry>(entity =>
            {
                entity.ToTable("ManasFerry");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Charge).HasColumnName("charge");

                entity.Property(e => e.Departure)
                    .HasColumnType("datetime")
                    .HasColumnName("departure");

                entity.Property(e => e.DestinationId).HasColumnName("destinationId");

                entity.Property(e => e.Image)
                    .HasColumnType("text")
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OriginId).HasColumnName("originId");

                entity.Property(e => e.RoomsLeft).HasColumnName("roomsLeft");
            });

            modelBuilder.Entity<ManasPort>(entity =>
            {
                entity.ToTable("ManasPort");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasColumnType("text")
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ManasTicket>(entity =>
            {
                entity.ToTable("ManasTicket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdultCount)
                    .HasColumnName("adultCount")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.FerryId).HasColumnName("ferryId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RoomNo).HasColumnName("roomNo");
            });

            modelBuilder.Entity<ManasUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("ManasUser");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<Painting>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Painting__DD37D91A3E6137C2");

                entity.ToTable("Painting");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.ArtistId).HasColumnName("artist_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.StyleOfArt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("style_of_art");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Year)
                    .HasColumnType("date")
                    .HasColumnName("year");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Paintings)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__Painting__artist__1CBC4616");
            });

            modelBuilder.Entity<PremAttendance>(entity =>
            {
                entity.ToTable("PremAttendance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttendanceDay)
                    .HasColumnType("date")
                    .HasColumnName("attendanceDay");

                entity.Property(e => e.AttendanceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attendanceStatus");

                entity.Property(e => e.AttendanceTime)
                    .HasColumnType("datetime")
                    .HasColumnName("attendanceTime");

                entity.Property(e => e.AttendanceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attendanceType");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.PremAttendanceEmps)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__PremAtten__empId__1209AD79");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PremAttendanceManagers)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__PremAtten__manag__11158940");
            });

            modelBuilder.Entity<PremEmployee>(entity =>
            {
                entity.ToTable("PremEmployee");

                entity.HasIndex(e => e.Username, "UQ__PremEmpl__F3DBC5720E65AE40")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__PremEmplo__manag__0E391C95");
            });

            modelBuilder.Entity<RahulBook>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__rahul_Bo__490D1AE1A7731EE7");

                entity.ToTable("rahul_Book");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.BookAuthor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("book_author");

                entity.Property(e => e.BookName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("book_name");

                entity.Property(e => e.BookQty).HasColumnName("book_qty");
            });

            modelBuilder.Entity<RahulBooking>(entity =>
            {
                entity.HasKey(e => e.Bookingid)
                    .HasName("PK__rahul_Bo__C6D307052EFDAB3E");

                entity.ToTable("rahul_Booking");

                entity.Property(e => e.Bookingid).HasColumnName("bookingid");

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.BidNavigation)
                    .WithMany(p => p.RahulBookings)
                    .HasForeignKey(d => d.Bid)
                    .HasConstraintName("FK__rahul_Booki__bid__1E6F845E");

                entity.HasOne(d => d.UidNavigation)
                    .WithMany(p => p.RahulBookings)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__rahul_Booki__uid__1D7B6025");
            });

            modelBuilder.Entity<RahulUser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__rahul_Us__CBA1B25753B271DE");

                entity.ToTable("rahul_User");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Userpassword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userpassword");
            });

            modelBuilder.Entity<SuneetDept>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Suneet_D__0148818EA754B5DB");

                entity.ToTable("Suneet_Dept");

                entity.Property(e => e.DeptId)
                    .ValueGeneratedNever()
                    .HasColumnName("DeptID");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfEmployees).HasColumnName("No_of_Employees");
            });

            modelBuilder.Entity<SuneetEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Suneet_E__7AD04FF1F58F10EF");

                entity.ToTable("Suneet_Employee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_birth");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.SuneetEmployees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Suneet_Em__DeptI__18B6AB08");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.TeamName)
                    .HasName("PK__Team__16C2F8BF06095764");

                entity.ToTable("Team");

                entity.HasIndex(e => e.Id, "UQ__Team__3214EC06B5CD49C7")
                    .IsUnique();

                entity.Property(e => e.TeamName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Team_Name");

                entity.Property(e => e.TeamLead)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Team_Lead");
            });

            modelBuilder.Entity<TransactionVrm>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Transact__9B57CF722FBCDF36");

                entity.ToTable("Transaction_vrm");

                entity.Property(e => e.TransactionId).HasColumnName("transactionId");

                entity.Property(e => e.RentalEndDate)
                    .HasColumnType("date")
                    .HasColumnName("rental_end_date");

                entity.Property(e => e.RentalRate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("rental_rate");

                entity.Property(e => e.RentalStartDate)
                    .HasColumnType("date")
                    .HasColumnName("rental_start_date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TransactionVrms)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacti__useri__04AFB25B");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.TransactionVrms)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacti__vehic__03BB8E22");
            });

            modelBuilder.Entity<UserList>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserList__1788CCACB1F20DE7");

                entity.ToTable("UserList");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<UserPrem>(entity =>
            {
                entity.ToTable("userPrem");

                entity.HasIndex(e => e.Username, "UQ__userPrem__F3DBC572C90E61BE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Userbtl>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__userbtl__1788CC4C1ACB02D1");

                entity.ToTable("userbtl");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Userbtlishan>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__userbtli__1788CC4C891106E7");

                entity.ToTable("userbtlishan");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Userhritik>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__userhrit__1797D024DBE43055");

                entity.ToTable("userhritik");

                entity.Property(e => e.Userid).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersRahul>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__usersRah__DD7012643BA6E206");

                entity.ToTable("usersRahul");

                entity.Property(e => e.Uid)
                    .ValueGeneratedNever()
                    .HasColumnName("uid");

                entity.Property(e => e.Uname)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("uname");

                entity.Property(e => e.Upswd)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("upswd");
            });

            modelBuilder.Entity<Usertbl>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Usertbl__1788CC4C7D51C4F2");

                entity.ToTable("Usertbl");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usertbl2>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Usertbl2__1788CC4CD87FA2C4");

                entity.ToTable("Usertbl2");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

                entity.Property(e => e.DailyRent).HasColumnName("dailyRent");

                entity.Property(e => e.IsAvailable).HasColumnName("isAvailable");

                entity.Property(e => e.KmsTravelled).HasColumnName("kmsTravelled");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modelName");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registrationNumber");

                entity.Property(e => e.VehicleType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
