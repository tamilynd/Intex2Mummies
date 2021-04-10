using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mummies.Models.MummyDb
{
    public partial class MummyDbContext : DbContext
    {
        public MummyDbContext()
        {
        }

        public MummyDbContext(DbContextOptions<MummyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BiologicalSamples> BiologicalSamples { get; set; }
        public virtual DbSet<ByuFagElGamousDb> ByuFagElGamousDb { get; set; }
        public virtual DbSet<C14Data> C14Data { get; set; }
        public virtual DbSet<Cranial2002> Cranial2002 { get; set; }
        public virtual DbSet<FagElGamousDatabaseByLocation> FagElGamousDatabaseByLocation { get; set; }
        public virtual DbSet<Oraclespread> Oraclespread { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=mummydatabase.cy9bemqqeyif.us-east-1.rds.amazonaws.com;Initial Catalog=MummyDb;User ID=admin;Password=group4-7");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BiologicalSamples>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.Property(e => e.Index).HasMaxLength(50);

                entity.Property(e => e.BurialId).HasColumnName("Burial_ID");

                entity.Property(e => e.EW).HasColumnName("E_W");

                entity.Property(e => e.High2).HasColumnName("High_2");

                entity.Property(e => e.Low2).HasColumnName("Low_2");

                entity.Property(e => e.NS).HasColumnName("N_S");

                entity.Property(e => e.Notes2).HasColumnName("Notes_2");

                entity.Property(e => e.PreviouslySampled).HasColumnName("Previously_Sampled");
            });

            modelBuilder.Entity<ByuFagElGamousDb>(entity =>
            {
                entity.HasKey(e => e.BurialId)
                    .HasName("PK_BYU-Fag_el-Gamous_DB");

                entity.ToTable("BYU_Fag_el_Gamous_DB");

                entity.Property(e => e.BurialId)
                    .HasColumnName("Burial_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.ArtifactsDescription)
                    .HasColumnName("artifacts_description")
                    .HasMaxLength(150);

                entity.Property(e => e.BasilarSuture)
                    .HasColumnName("basilar_suture")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnName("basion_bregma_height")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionNasion)
                    .HasColumnName("basion_nasion")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnName("basion_prosthion_length")
                    .HasMaxLength(50);

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnName("bizygomatic_diameter")
                    .HasMaxLength(50);

                entity.Property(e => e.BoneLength)
                    .HasColumnName("bone_length")
                    .HasMaxLength(1);

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialDepth)
                    .HasColumnName("burial_depth")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialNumber)
                    .HasColumnName("burial_number")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialSituation)
                    .HasColumnName("burial_situation")
                    .HasMaxLength(1100);

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(50);

                entity.Property(e => e.CranialSuture)
                    .HasColumnName("cranial_suture")
                    .HasMaxLength(50);

                entity.Property(e => e.DayFound)
                    .HasColumnName("day_found")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionOfTaken)
                    .HasColumnName("description_of_taken")
                    .HasMaxLength(100);

                entity.Property(e => e.DorsalPitting)
                    .HasColumnName("dorsal_pitting")
                    .HasMaxLength(50);

                entity.Property(e => e.EastToFeet)
                    .HasColumnName("east_to_feet")
                    .HasMaxLength(50);

                entity.Property(e => e.EastToHead)
                    .HasColumnName("east_to_head")
                    .HasMaxLength(50);

                entity.Property(e => e.EpiphysealUnion)
                    .HasColumnName("epiphyseal_union")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimateAge)
                    .HasColumnName("estimate_age")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimateLivingStature)
                    .HasColumnName("estimate_living_stature")
                    .HasMaxLength(50);

                entity.Property(e => e.FemurDiameter)
                    .HasColumnName("femur_diameter")
                    .HasMaxLength(1);

                entity.Property(e => e.FemurHead)
                    .HasColumnName("femur_head")
                    .HasMaxLength(50);

                entity.Property(e => e.FemurLength)
                    .HasColumnName("femur_length")
                    .HasMaxLength(50);

                entity.Property(e => e.ForemanMagnum)
                    .HasColumnName("foreman_magnum")
                    .HasMaxLength(1);

                entity.Property(e => e.GeFunctionTotal)
                    .HasColumnName("GE_function_total")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderBodyCol)
                    .HasColumnName("gender_body_col")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderGe)
                    .HasColumnName("gender_GE")
                    .HasMaxLength(50);

                entity.Property(e => e.Gonian)
                    .HasColumnName("gonian")
                    .HasMaxLength(50);

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasMaxLength(50);

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection)
                    .HasColumnName("head_direction")
                    .HasMaxLength(50);

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasMaxLength(1);

                entity.Property(e => e.HumerusHead)
                    .HasColumnName("humerus_head")
                    .HasMaxLength(50);

                entity.Property(e => e.HumerusLength)
                    .HasColumnName("humerus_length")
                    .HasMaxLength(50);

                entity.Property(e => e.IliacCrest)
                    .HasColumnName("iliac_crest")
                    .HasMaxLength(1);

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnName("interorbital_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.LengthOfRemains)
                    .HasColumnName("length_of_remains")
                    .HasMaxLength(50);

                entity.Property(e => e.LowPairEw)
                    .HasColumnName("low_pair_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasColumnName("maximum_cranial_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumCranialLength)
                    .HasColumnName("maximum_cranial_length")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasColumnName("maximum_nasal_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.MedialClavicle)
                    .HasColumnName("medial_clavicle")
                    .HasMaxLength(1);

                entity.Property(e => e.MedialIpRamus)
                    .HasColumnName("medial_IP_ramus")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthFound)
                    .HasColumnName("month_found")
                    .HasMaxLength(50);

                entity.Property(e => e.NasionProsthion)
                    .HasColumnName("nasion_prosthion")
                    .HasMaxLength(50);

                entity.Property(e => e.NuchalCrest)
                    .HasColumnName("nuchal_crest")
                    .HasMaxLength(50);

                entity.Property(e => e.OrbitEdge)
                    .HasColumnName("orbit_edge")
                    .HasMaxLength(50);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(50);

                entity.Property(e => e.ParietalBossing)
                    .HasColumnName("parietal_bossing")
                    .HasMaxLength(50);

                entity.Property(e => e.PathologyAnomalies)
                    .HasColumnName("pathology_anomalies")
                    .HasMaxLength(200);

                entity.Property(e => e.PreaurSulcus)
                    .HasColumnName("preaur_sulcus")
                    .HasMaxLength(50);

                entity.Property(e => e.PreservationIndex)
                    .HasColumnName("preservation_index")
                    .HasMaxLength(50);

                entity.Property(e => e.PubicBone)
                    .HasColumnName("pubic_bone")
                    .HasMaxLength(50);

                entity.Property(e => e.PubicSymphysis)
                    .HasColumnName("pubic_symphysis")
                    .HasMaxLength(50);

                entity.Property(e => e.Robust)
                    .HasColumnName("robust")
                    .HasMaxLength(50);

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch)
                    .HasColumnName("sciatic_notch")
                    .HasMaxLength(50);

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet)
                    .HasColumnName("south_to_feet")
                    .HasMaxLength(50);

                entity.Property(e => e.SouthToHead)
                    .HasColumnName("south_to_head")
                    .HasMaxLength(50);

                entity.Property(e => e.SubpubicAngle)
                    .HasColumnName("subpubic_angle")
                    .HasMaxLength(50);

                entity.Property(e => e.SupraorbitalRidges)
                    .HasColumnName("supraorbital_ridges")
                    .HasMaxLength(50);

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength)
                    .HasColumnName("tibia_length")
                    .HasMaxLength(50);

                entity.Property(e => e.ToothAttrition)
                    .HasColumnName("tooth_attrition")
                    .HasMaxLength(50);

                entity.Property(e => e.ToothEruption)
                    .HasColumnName("tooth_eruption")
                    .HasMaxLength(50);

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.VentralArc)
                    .HasColumnName("ventral_arc")
                    .HasMaxLength(50);

                entity.Property(e => e.YearFound)
                    .HasColumnName("year_found")
                    .HasMaxLength(50);

                entity.Property(e => e.ZygomaticCrest)
                    .HasColumnName("zygomatic_crest")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<C14Data>(entity =>
            {
                entity.HasKey(e => e.BurialId);

                entity.ToTable("C14 DATA");

                entity.Property(e => e.BurialId)
                    .HasColumnName("Burial_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(50);

                entity.Property(e => e.Burial).HasMaxLength(50);

                entity.Property(e => e.C14Sample2017)
                    .HasColumnName("C14_Sample_2017")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95CalendarDateAvg)
                    .HasColumnName("Calibrated_95_Calendar_Date_AVG")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95CalendarDateMax).HasColumnName("Calibrated_95_Calendar_Date_MAX");

                entity.Property(e => e.Calibrated95CalendarDateMin).HasColumnName("Calibrated_95_Calendar_Date_MIN");

                entity.Property(e => e.Calibrated95CalendarDateSpan).HasColumnName("Calibrated_95_Calendar_Date_SPAN");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Column20)
                    .HasColumnName("column20")
                    .HasMaxLength(50);

                entity.Property(e => e.Column29)
                    .HasColumnName("column29")
                    .HasMaxLength(50);

                entity.Property(e => e.Column4)
                    .HasColumnName("column4")
                    .HasMaxLength(50);

                entity.Property(e => e.Column7)
                    .HasColumnName("column7")
                    .HasMaxLength(50);

                entity.Property(e => e.Conventional14cAgeBp).HasColumnName("Conventional_14C_age_BP");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EWLower)
                    .HasColumnName("E_W_Lower")
                    .HasMaxLength(50);

                entity.Property(e => e.EWUpper).HasColumnName("E_W_Upper");

                entity.Property(e => e.Foci).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.NSLower).HasColumnName("N_S_Lower");

                entity.Property(e => e.NSUpper).HasColumnName("N_S_Upper");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.QuestionS)
                    .HasColumnName("Question_s")
                    .HasMaxLength(150);

                entity.Property(e => e.SizeMl).HasColumnName("Size_ml");

                entity.Property(e => e.Square).HasMaxLength(50);

                entity.Property(e => e.Tube)
                    .HasColumnName("TUBE")
                    .HasMaxLength(50);

                entity.Property(e => e._14cCalendarDate).HasColumnName("_14C_Calendar_Date");
            });

            modelBuilder.Entity<Cranial2002>(entity =>
            {
                entity.HasKey(e => e.BurialId);

                entity.ToTable("cranial2002");

                entity.Property(e => e.BurialId)
                    .HasColumnName("Burial_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("Basion_Bregma_Height");

                entity.Property(e => e.BasionNasion).HasColumnName("Basion_Nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("Basion_Prosthion_Length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("Bizygomatic_Diameter");

                entity.Property(e => e.BodyGender).HasMaxLength(50);

                entity.Property(e => e.BurialArtifactDescription)
                    .HasColumnName("Burial_Artifact_Description")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialDepth)
                    .HasColumnName("Burial_Depth")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialNumber)
                    .HasColumnName("Burial_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialPositioningEastWestDirection)
                    .HasColumnName("Burial_Positioning_East_West_Direction")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialPositioningEastWestNumber)
                    .HasColumnName("Burial_Positioning_East_West_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialPositioningNorthSouthDirection)
                    .HasColumnName("Burial_Positioning_North_South_Direction")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialPositioningNorthSouthNumber)
                    .HasColumnName("Burial_Positioning_North_South_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialSubPlotDirection)
                    .HasColumnName("Burial_sub_plot_direction")
                    .HasMaxLength(50);

                entity.Property(e => e.BuriedWithArtifacts).HasColumnName("Buried_with_Artifacts");

                entity.Property(e => e.GilesGender).HasMaxLength(1);

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("Interorbital_Breadth");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("Maximum_Cranial_Breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("Maximum_Cranial_Length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("Maximum_Nasal_Breadth");

                entity.Property(e => e.NasionProsthion).HasColumnName("Nasion_Prosthion");

                entity.Property(e => e.SampleNumber)
                    .HasColumnName("Sample_Number")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FagElGamousDatabaseByLocation>(entity =>
            {
                entity.HasKey(e => e.BurialId)
                    .HasName("PK_FagElGamousDatabaseByLocations");

                entity.Property(e => e.BurialId)
                    .HasColumnName("Burial_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.AdultChild).HasColumnName("Adult_Child");

                entity.Property(e => e.AgeCodeSingle).HasColumnName("Age_Code_SINGLE");

                entity.Property(e => e.AgeSkull2018).HasColumnName("Age_Skull_2018");

                entity.Property(e => e.AreaHillBurials).HasColumnName("Area_Hill_burials");

                entity.Property(e => e.BodyAnalysis).HasColumnName("Body_Analysis");

                entity.Property(e => e.BurialAdultChild).HasColumnName("burial_adult_child");

                entity.Property(e => e.BurialAreaEastOrWestLower).HasColumnName("burial_area_east_or_west_lower");

                entity.Property(e => e.BurialAreaEastOrWestUpper).HasColumnName("burial_area_east_or_west_upper");

                entity.Property(e => e.BurialAreaNorthOrSouthLower).HasColumnName("burial_area_North_or_South_lower");

                entity.Property(e => e.BurialAreaNorthOrSouthUpper).HasColumnName("burial_area_North_or_South_upper");

                entity.Property(e => e.BurialDepth)
                    .HasColumnName("burial_depth")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BurialDirection).HasColumnName("burial_direction");

                entity.Property(e => e.BurialDirection2).HasColumnName("Burial_Direction2");

                entity.Property(e => e.BurialNumber).HasColumnName("Burial_Number");

                entity.Property(e => e.BurialPreservation).HasColumnName("burial_preservation");

                entity.Property(e => e.BurialSouthToFeet).HasColumnName("burial_south_to_feet");

                entity.Property(e => e.BurialSouthToHead).HasColumnName("burial_south_to_head");

                entity.Property(e => e.BurialWestToFeet).HasColumnName("burial_west_to_feet");

                entity.Property(e => e.BurialWestToHead).HasColumnName("burial_west_to_head");

                entity.Property(e => e.BurialWrapping).HasColumnName("Burial_Wrapping");

                entity.Property(e => e.BurialWrappingCode).HasColumnName("burial_wrapping_code");

                entity.Property(e => e.Burialageatdeath).HasColumnName("burialageatdeath");

                entity.Property(e => e.Burialagemethod).HasColumnName("burialagemethod");

                entity.Property(e => e.Burialgendermethod).HasColumnName("burialgendermethod");

                entity.Property(e => e.Burialhaircolor).HasColumnName("burialhaircolor");

                entity.Property(e => e.Burialnors).HasColumnName("burialnors");

                entity.Property(e => e.Burialsampletaken).HasColumnName("burialsampletaken");

                entity.Property(e => e.Burialxeorw).HasColumnName("burialxeorw");

                entity.Property(e => e.ButtonOsteoma).HasColumnName("Button_Osteoma");

                entity.Property(e => e.ByuSample).HasColumnName("BYU_Sample");

                entity.Property(e => e.Column73).HasColumnName("column73");

                entity.Property(e => e.Column74).HasColumnName("column74");

                entity.Property(e => e.Column75).HasColumnName("column75");

                entity.Property(e => e.Column76).HasColumnName("column76");

                entity.Property(e => e.Column77).HasColumnName("column77");

                entity.Property(e => e.Column78).HasColumnName("column78");

                entity.Property(e => e.Column79).HasColumnName("column79");

                entity.Property(e => e.Column80).HasColumnName("column80");

                entity.Property(e => e.Column81).HasColumnName("column81");

                entity.Property(e => e.Column82).HasColumnName("column82");

                entity.Property(e => e.Column83).HasColumnName("column83");

                entity.Property(e => e.Column84).HasColumnName("column84");

                entity.Property(e => e.Column85).HasColumnName("column85");

                entity.Property(e => e.Column86).HasColumnName("column86");

                entity.Property(e => e.Column87).HasColumnName("column87");

                entity.Property(e => e.Column88).HasColumnName("column88");

                entity.Property(e => e.Column89).HasColumnName("column89");

                entity.Property(e => e.Column90).HasColumnName("column90");

                entity.Property(e => e.Column91).HasColumnName("column91");

                entity.Property(e => e.Column92).HasColumnName("column92");

                entity.Property(e => e.Column93).HasColumnName("column93");

                entity.Property(e => e.Column94).HasColumnName("column94");

                entity.Property(e => e.Column95).HasColumnName("column95");

                entity.Property(e => e.Column96).HasColumnName("column96");

                entity.Property(e => e.CribraOrbitala).HasColumnName("Cribra_Orbitala");

                entity.Property(e => e.DateExcavated).HasColumnName("Date_Excavated");

                entity.Property(e => e.DateOnSkull).HasColumnName("Date_on_Skull");

                entity.Property(e => e.FaceBundle).HasColumnName("Face_Bundle");

                entity.Property(e => e.FieldBook).HasColumnName("Field_Book");

                entity.Property(e => e.FieldBookPageNumber).HasColumnName("Field_Book_Page_Number");

                entity.Property(e => e.GenderCode).HasColumnName("Gender_Code");

                entity.Property(e => e.HairColor).HasColumnName("Hair_Color");

                entity.Property(e => e.HairColorCode).HasColumnName("Hair_Color_Code");

                entity.Property(e => e.InitialsOfDataEntryChecker).HasColumnName("Initials_of_Data_Entry_Checker");

                entity.Property(e => e.InitialsOfDataEntryExpert).HasColumnName("Initials_of_Data_Entry_Expert");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LengthCm).HasColumnName("length_CM");

                entity.Property(e => e.LengthM).HasColumnName("length_M");

                entity.Property(e => e.LinearHypoplasiaEnamel).HasColumnName("Linear_Hypoplasia_Enamel");

                entity.Property(e => e.MetopicSuture).HasColumnName("Metopic_Suture");

                entity.Property(e => e.MonthExcavated).HasColumnName("Month_Excavated");

                entity.Property(e => e.MonthOnSkull).HasColumnName("Month_on_skull");

                entity.Property(e => e.OsteologyNotes).HasColumnName("Osteology_Notes");

                entity.Property(e => e.OsteologyUnknownComment).HasColumnName("Osteology_unknown_comment");

                entity.Property(e => e.PoroticHyperostosis).HasColumnName("Porotic_Hyperostosis");

                entity.Property(e => e.PoroticHyperostosisLocations).HasColumnName("Porotic_Hyperostosis_LOCATIONS");

                entity.Property(e => e.PostcraniaAtMagazine).HasColumnName("Postcrania_at_Magazine");

                entity.Property(e => e.PostcraniaTrauma).HasColumnName("Postcrania_Trauma");

                entity.Property(e => e.PostcraniaTrauma2).HasColumnName("Postcrania_Trauma2");

                entity.Property(e => e.RackAndShelf).HasColumnName("Rack_and_Shelf");

                entity.Property(e => e.SexSkull2018).HasColumnName("Sex_Skull_2018");

                entity.Property(e => e.SkullAtMagazine).HasColumnName("Skull_at_Magazine");

                entity.Property(e => e.SkullTrauma).HasColumnName("Skull_Trauma");

                entity.Property(e => e.TemporalMandibularJointOsteoarthritisTmjOa).HasColumnName("Temporal_Mandibular_Joint_Osteoarthritis_TMJ_OA");

                entity.Property(e => e.ToBeConfirmed).HasColumnName("TO_BE_CONFIRMED");

                entity.Property(e => e.UnknownField).HasColumnName("Unknown_Field");

                entity.Property(e => e.YearExcav).HasColumnName("year_excav");

                entity.Property(e => e.YearOnSkull).HasColumnName("Year_on_skull");
            });

            modelBuilder.Entity<Oraclespread>(entity =>
            {
                entity.HasKey(e => e.BurialId);

                entity.ToTable("oraclespread");

                entity.Property(e => e.BurialId)
                    .HasColumnName("Burial_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("AGEATDEATH")
                    .HasMaxLength(50);

                entity.Property(e => e.Agemethod)
                    .HasColumnName("AGEMETHOD")
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialicon)
                    .HasColumnName("BURIALICON")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialicon2)
                    .HasColumnName("BURIALICON2")
                    .HasMaxLength(50);

                entity.Property(e => e.Burialnum)
                    .HasColumnName("BURIALNUM")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialsquareLower).HasColumnName("BURIALSQUARE_Lower");

                entity.Property(e => e.BurialsquareUpper).HasColumnName("BURIALSQUARE_Upper");

                entity.Property(e => e.Depth)
                    .HasColumnName("DEPTH")
                    .HasMaxLength(50);

                entity.Property(e => e.Eorw)
                    .HasColumnName("EORW")
                    .HasMaxLength(50);

                entity.Property(e => e.Gamous)
                    .HasColumnName("GAMOUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Haircolor)
                    .HasColumnName("HAIRCOLOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Nors)
                    .HasColumnName("NORS")
                    .HasMaxLength(50);

                entity.Property(e => e.Preservation)
                    .HasColumnName("PRESERVATION")
                    .HasMaxLength(50);

                entity.Property(e => e.Sample)
                    .HasColumnName("SAMPLE")
                    .HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasMaxLength(50);

                entity.Property(e => e.Sexmethod)
                    .HasColumnName("SEXMETHOD")
                    .HasMaxLength(50);

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("SOUTHTOFEET")
                    .HasMaxLength(50);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("SOUTHTOHEAD")
                    .HasMaxLength(50);

                entity.Property(e => e.Sq2Lower)
                    .HasColumnName("SQ2_Lower")
                    .HasMaxLength(50);

                entity.Property(e => e.Sq2Upper).HasColumnName("SQ2_Upper");

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("WESTTOFEET")
                    .HasMaxLength(50);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("WESTTOHEAD")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
