using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PIZZA_API.Models
{
    public partial class _2019SBDContext : DbContext
    {
        public _2019SBDContext()
        {
        } 

       

        public virtual DbSet<AcAddresses> AcAddresses { get; set; }
        public virtual DbSet<AchAdditive> AchAdditive { get; set; }
        public virtual DbSet<AchCustomer> AchCustomer { get; set; }
        public virtual DbSet<AchCustomerAlergen> AchCustomerAlergen { get; set; }
        public virtual DbSet<AchIngredient> AchIngredient { get; set; }
        public virtual DbSet<AchOrder> AchOrder { get; set; }
        public virtual DbSet<AchPizza> AchPizza { get; set; }
        public virtual DbSet<AchPizzaComposition> AchPizzaComposition { get; set; }
        public virtual DbSet<AcIngredients> AcIngredients { get; set; }
        public virtual DbSet<AcPizzaDetails> AcPizzaDetails { get; set; }
        public virtual DbSet<AcPizzaOrder> AcPizzaOrder { get; set; }
        public virtual DbSet<AcPizzaPie> AcPizzaPie { get; set; }
        public virtual DbSet<AcPizzas> AcPizzas { get; set; }
        public virtual DbSet<AcSize> AcSize { get; set; }
        public virtual DbSet<AcUsers> AcUsers { get; set; }
        public virtual DbSet<Dydaktyk> Dydaktyk { get; set; }
        public virtual DbSet<Grupa> Grupa { get; set; }
        public virtual DbSet<Miasto> Miasto { get; set; }
        public virtual DbSet<Ocena> Ocena { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Panstwo> Panstwo { get; set; }
        public virtual DbSet<Przedmiot> Przedmiot { get; set; }
        public virtual DbSet<PrzedmiotPoprzedzajacy> PrzedmiotPoprzedzajacy { get; set; }
        public virtual DbSet<RokAkademicki> RokAkademicki { get; set; }
        public virtual DbSet<StopnieTytuly> StopnieTytuly { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentGrupa> StudentGrupa { get; set; }

        // Unable to generate entity type for table 's15245.ACH_ORDER_ADDITIVE'. Please see the warning messages.
        // Unable to generate entity type for table 's15245.ACH_ORDER_PIZZA'. Please see the warning messages.
        // Unable to generate entity type for table 's15245.temp'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=2019SBD;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "s15245");

            modelBuilder.Entity<AcAddresses>(entity =>
            {
                entity.ToTable("ac_addresses");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlatNumber).HasColumnName("flat_number");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PostalCode).HasColumnName("postal_code");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("street")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AchAdditive>(entity =>
            {
                entity.HasKey(e => e.IdAdditive);

                entity.ToTable("ACH_ADDITIVE");

                entity.Property(e => e.IdAdditive)
                    .HasColumnName("ID_ADDITIVE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("PRICE");
            });

            modelBuilder.Entity<AchCustomer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("ACH_CUSTOMER");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("ID_CUSTOMER")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomeNumber)
                    .IsRequired()
                    .HasColumnName("HOME_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("STREET")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone).HasColumnName("TELEPHONE");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasColumnName("USER_LOGIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasColumnName("USER_PASS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AchCustomerAlergen>(entity =>
            {
                entity.HasKey(e => e.CustomerAlergenId);

                entity.ToTable("ACH_CUSTOMER_ALERGEN");

                entity.Property(e => e.CustomerAlergenId)
                    .HasColumnName("CUSTOMER_ALERGEN_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AchCustomerIdCustomer).HasColumnName("ACH_CUSTOMER_ID_CUSTOMER");

                entity.Property(e => e.AchIngredientIdIngredient).HasColumnName("ACH_INGREDIENT_ID_INGREDIENT");

                entity.HasOne(d => d.AchCustomerIdCustomerNavigation)
                    .WithMany(p => p.AchCustomerAlergen)
                    .HasForeignKey(d => d.AchCustomerIdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACH_CUSTOMER_ALERGEN_ACH_CUSTOMER");

                entity.HasOne(d => d.AchIngredientIdIngredientNavigation)
                    .WithMany(p => p.AchCustomerAlergen)
                    .HasForeignKey(d => d.AchIngredientIdIngredient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACH_CUSTOMER_ALERGEN_ACH_INGREDIENT");
            });

            modelBuilder.Entity<AchIngredient>(entity =>
            {
                entity.HasKey(e => e.IdIngredient);

                entity.ToTable("ACH_INGREDIENT");

                entity.Property(e => e.IdIngredient)
                    .HasColumnName("ID_INGREDIENT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alergen).HasColumnName("ALERGEN");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AchOrder>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("ACH_ORDER");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("ID_ORDER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AchCustomerIdCustomer).HasColumnName("ACH_CUSTOMER_ID_CUSTOMER");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("ORDER_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStatus).HasColumnName("ORDER_STATUS");

                entity.HasOne(d => d.AchCustomerIdCustomerNavigation)
                    .WithMany(p => p.AchOrder)
                    .HasForeignKey(d => d.AchCustomerIdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACH_ORDER_ACH_CUSTOMER");
            });

            modelBuilder.Entity<AchPizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza);

                entity.ToTable("ACH_PIZZA");

                entity.Property(e => e.IdPizza)
                    .HasColumnName("ID_PIZZA")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("PRICE");
            });

            modelBuilder.Entity<AchPizzaComposition>(entity =>
            {
                entity.HasKey(e => e.PizzaCompositionId);

                entity.ToTable("ACH_PIZZA_COMPOSITION");

                entity.Property(e => e.PizzaCompositionId)
                    .HasColumnName("PIZZA_COMPOSITION_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AchIngredientIdIngredient).HasColumnName("ACH_INGREDIENT_ID_INGREDIENT");

                entity.Property(e => e.AchPizzaIdPizza).HasColumnName("ACH_PIZZA_ID_PIZZA");

                entity.Property(e => e.Grams).HasColumnName("grams");

                entity.HasOne(d => d.AchIngredientIdIngredientNavigation)
                    .WithMany(p => p.AchPizzaComposition)
                    .HasForeignKey(d => d.AchIngredientIdIngredient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACH_PIZZA_COMPOSITION_ACH_INGREDIENT");

                entity.HasOne(d => d.AchPizzaIdPizzaNavigation)
                    .WithMany(p => p.AchPizzaComposition)
                    .HasForeignKey(d => d.AchPizzaIdPizza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ACH_PIZZA_COMPOSITION_ACH_PIZZA");
            });

            modelBuilder.Entity<AcIngredients>(entity =>
            {
                entity.ToTable("ac_ingredients");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Carbohydrate).HasColumnName("carbohydrate");

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Protein).HasColumnName("protein");
            });

            modelBuilder.Entity<AcPizzaDetails>(entity =>
            {
                entity.ToTable("ac_pizza_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcIngredientsId).HasColumnName("ac_ingredients_id");

                entity.Property(e => e.AcPizzaPieId).HasColumnName("ac_pizza_pie_id");

                entity.Property(e => e.AcPizzasId).HasColumnName("ac_pizzas_id");

                entity.Property(e => e.AcSizeId).HasColumnName("ac_size_id");

                entity.Property(e => e.Pirce).HasColumnName("pirce");

                entity.HasOne(d => d.AcIngredients)
                    .WithMany(p => p.AcPizzaDetails)
                    .HasForeignKey(d => d.AcIngredientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ac_pizza_ingredients_ac_ingredients");

                entity.HasOne(d => d.AcPizzaPie)
                    .WithMany(p => p.AcPizzaDetails)
                    .HasForeignKey(d => d.AcPizzaPieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ac_pizza_details_ac_pizza_pie");

                entity.HasOne(d => d.AcPizzas)
                    .WithMany(p => p.AcPizzaDetails)
                    .HasForeignKey(d => d.AcPizzasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ac_pizza_ingredients_ac_pizzas");

                entity.HasOne(d => d.AcSize)
                    .WithMany(p => p.AcPizzaDetails)
                    .HasForeignKey(d => d.AcSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ac_pizza_ingredients_ac_size");
            });

            modelBuilder.Entity<AcPizzaOrder>(entity =>
            {
                entity.ToTable("ac_pizza_order");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcAddressesId).HasColumnName("ac_addresses_id");

                entity.Property(e => e.AcIngredientsId).HasColumnName("ac_ingredients_id");

                entity.Property(e => e.AcUsersId).HasColumnName("ac_users_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.HasOne(d => d.AcAddresses)
                    .WithMany(p => p.AcPizzaOrder)
                    .HasForeignKey(d => d.AcAddressesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ac_pizza_order_ac_addresses");

                entity.HasOne(d => d.AcIngredients)
                    .WithMany(p => p.AcPizzaOrder)
                    .HasForeignKey(d => d.AcIngredientsId)
                    .HasConstraintName("ac_pizza_order_ac_ingredients_addition");

                entity.HasOne(d => d.AcUsers)
                    .WithMany(p => p.AcPizzaOrder)
                    .HasForeignKey(d => d.AcUsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ac_pizza_order_ac_users");
            });

            modelBuilder.Entity<AcPizzaPie>(entity =>
            {
                entity.ToTable("ac_pizza_pie");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<AcPizzas>(entity =>
            {
                entity.ToTable("ac_pizzas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcSize>(entity =>
            {
                entity.ToTable("ac_size");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<AcUsers>(entity =>
            {
                entity.ToTable("ac_users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dydaktyk>(entity =>
            {
                entity.HasKey(e => e.IdOsoba);

                entity.Property(e => e.IdOsoba).ValueGeneratedNever();

                entity.Property(e => e.Placa).HasColumnName("PLACA");

                entity.HasOne(d => d.IdOsobaNavigation)
                    .WithOne(p => p.Dydaktyk)
                    .HasForeignKey<Dydaktyk>(d => d.IdOsoba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Osoba_Dydaktyk_FK1");

                entity.HasOne(d => d.IdStopienNavigation)
                    .WithMany(p => p.Dydaktyk)
                    .HasForeignKey(d => d.IdStopien)
                    .HasConstraintName("StopnieTytuly_Dydaktyk_FK1");

                entity.HasOne(d => d.PodlegaNavigation)
                    .WithMany(p => p.InversePodlegaNavigation)
                    .HasForeignKey(d => d.Podlega)
                    .HasConstraintName("Dydaktyk_Dydaktyk_FK1");
            });

            modelBuilder.Entity<Grupa>(entity =>
            {
                entity.HasKey(e => e.IdGrupa);

                entity.HasIndex(e => new { e.NrGrupy, e.IdRokAkademicki })
                    .HasName("UQ_Rok_Nr")
                    .IsUnique();

                entity.Property(e => e.IdRokAkademicki)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NrGrupy)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRokAkademickiNavigation)
                    .WithMany(p => p.Grupa)
                    .HasForeignKey(d => d.IdRokAkademicki)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RokAkad_GrupaStud_FK1");
            });

            modelBuilder.Entity<Miasto>(entity =>
            {
                entity.HasKey(e => e.Idmiasto);

                entity.ToTable("MIASTO");

                entity.Property(e => e.IdpanstwoFk).HasColumnName("idpanstwo_fk");

                entity.Property(e => e.Miasto1)
                    .IsRequired()
                    .HasColumnName("Miasto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdpanstwoFkNavigation)
                    .WithMany(p => p.Miasto)
                    .HasForeignKey(d => d.IdpanstwoFk)
                    .HasConstraintName("miasto_panstwo_fk");
            });

            modelBuilder.Entity<Ocena>(entity =>
            {
                entity.HasKey(e => new { e.IdStudent, e.DataWystawienia, e.IdPrzedmiot });

                entity.Property(e => e.DataWystawienia).HasColumnType("date");

                entity.Property(e => e.Ocena1)
                    .HasColumnName("Ocena")
                    .HasColumnType("decimal(2, 1)");

                entity.HasOne(d => d.IdDydaktykNavigation)
                    .WithMany(p => p.Ocena)
                    .HasForeignKey(d => d.IdDydaktyk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dydaktyk_Ocena_FK1");

                entity.HasOne(d => d.IdPrzedmiotNavigation)
                    .WithMany(p => p.Ocena)
                    .HasForeignKey(d => d.IdPrzedmiot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Przedmiot_Ocena_FK1");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.Ocena)
                    .HasForeignKey(d => d.IdStudent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Student_Ocena_FK1");
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.HasKey(e => e.IdOsoba);

                entity.Property(e => e.DataUrodzenia).HasColumnType("date");

                entity.Property(e => e.Idmiasto).HasColumnName("IDMIASTO");

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasMaxLength(62)
                    .IsUnicode(false);

                entity.Property(e => e.Plec)
                    .HasColumnName("PLEC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdmiastoNavigation)
                    .WithMany(p => p.Osoba)
                    .HasForeignKey(d => d.Idmiasto)
                    .HasConstraintName("miasto_OSOBA_fk1");
            });

            modelBuilder.Entity<Panstwo>(entity =>
            {
                entity.HasKey(e => e.IdPanstwo);

                entity.Property(e => e.Panstwo1)
                    .IsRequired()
                    .HasColumnName("Panstwo")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Przedmiot>(entity =>
            {
                entity.HasKey(e => e.IdPrzedmiot);

                entity.Property(e => e.Przedmiot1)
                    .IsRequired()
                    .HasColumnName("Przedmiot")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrzedmiotPoprzedzajacy>(entity =>
            {
                entity.HasKey(e => new { e.IdPoprzednik, e.IdPrzedmiot });

                entity.HasOne(d => d.IdPoprzednikNavigation)
                    .WithMany(p => p.PrzedmiotPoprzedzajacyIdPoprzednikNavigation)
                    .HasForeignKey(d => d.IdPoprzednik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Przedmiot_PrzedmiotPop_FK1");

                entity.HasOne(d => d.IdPrzedmiotNavigation)
                    .WithMany(p => p.PrzedmiotPoprzedzajacyIdPrzedmiotNavigation)
                    .HasForeignKey(d => d.IdPrzedmiot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Przedmiot_PrzedmiotPop_FK2");
            });

            modelBuilder.Entity<RokAkademicki>(entity =>
            {
                entity.HasKey(e => e.IdRokAkademicki);

                entity.Property(e => e.IdRokAkademicki)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DataRozp)
                    .HasColumnName("Data_rozp")
                    .HasColumnType("date");

                entity.Property(e => e.DataZak)
                    .HasColumnName("Data_zak")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<StopnieTytuly>(entity =>
            {
                entity.HasKey(e => e.IdStopien);

                entity.Property(e => e.Skrot)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Stopien)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IdOsoba);

                entity.Property(e => e.IdOsoba).ValueGeneratedNever();

                entity.Property(e => e.DataRekrutacji).HasColumnType("date");

                entity.Property(e => e.NrIndeksu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdOsobaNavigation)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.IdOsoba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Osoba_Student_FK1");
            });

            modelBuilder.Entity<StudentGrupa>(entity =>
            {
                entity.HasKey(e => new { e.IdGrupa, e.IdOsoba });

                entity.HasOne(d => d.IdGrupaNavigation)
                    .WithMany(p => p.StudentGrupa)
                    .HasForeignKey(d => d.IdGrupa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Grupa_StudentGrupa_FK1");

                entity.HasOne(d => d.IdOsobaNavigation)
                    .WithMany(p => p.StudentGrupa)
                    .HasForeignKey(d => d.IdOsoba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Student_StudentGrupa_FK1");
            });
        }
    }
}
