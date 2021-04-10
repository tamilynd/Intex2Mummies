using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

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
                    .HasMaxLength(50)
                    .HasColumnName("Burial_ID");

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.ArtifactsDescription)
                    .HasMaxLength(150)
                    .HasColumnName("artifacts_description");

                entity.Property(e => e.BasilarSuture)
                    .HasMaxLength(50)
                    .HasColumnName("basilar_suture");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasMaxLength(50)
                    .HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion)
                    .HasMaxLength(50)
                    .HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength)
                    .HasMaxLength(50)
                    .HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasMaxLength(50)
                    .HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BoneLength)
                    .HasMaxLength(1)
                    .HasColumnName("bone_length");

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialDepth)
                    .HasMaxLength(50)
                    .HasColumnName("burial_depth");

                entity.Property(e => e.BurialLocationEw)
                    .HasMaxLength(50)
                    .HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs)
                    .HasMaxLength(50)
                    .HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialNumber)
                    .HasMaxLength(50)
                    .HasColumnName("burial_number");

                entity.Property(e => e.BurialSituation)
                    .HasMaxLength(1100)
                    .HasColumnName("burial_situation");

                entity.Property(e => e.BurialSubplot)
                    .HasMaxLength(50)
                    .HasColumnName("burial_subplot");

                entity.Property(e => e.CranialSuture)
                    .HasMaxLength(50)
                    .HasColumnName("cranial_suture");

                entity.Property(e => e.DayFound)
                    .HasMaxLength(50)
                    .HasColumnName("day_found");

                entity.Property(e => e.DescriptionOfTaken)
                    .HasMaxLength(100)
                    .HasColumnName("description_of_taken");

                entity.Property(e => e.DorsalPitting)
                    .HasMaxLength(50)
                    .HasColumnName("dorsal_pitting");

                entity.Property(e => e.EastToFeet)
                    .HasMaxLength(50)
                    .HasColumnName("east_to_feet");

                entity.Property(e => e.EastToHead)
                    .HasMaxLength(50)
                    .HasColumnName("east_to_head");

                entity.Property(e => e.EpiphysealUnion)
                    .HasMaxLength(50)
                    .HasColumnName("epiphyseal_union");

                entity.Property(e => e.EstimateAge)
                    .HasMaxLength(50)
                    .HasColumnName("estimate_age");

                entity.Property(e => e.EstimateLivingStature)
                    .HasMaxLength(50)
                    .HasColumnName("estimate_living_stature");

                entity.Property(e => e.FemurDiameter)
                    .HasMaxLength(1)
                    .HasColumnName("femur_diameter");

                entity.Property(e => e.FemurHead)
                    .HasMaxLength(50)
                    .HasColumnName("femur_head");

                entity.Property(e => e.FemurLength)
                    .HasMaxLength(50)
                    .HasColumnName("femur_length");

                entity.Property(e => e.ForemanMagnum)
                    .HasMaxLength(1)
                    .HasColumnName("foreman_magnum");

                entity.Property(e => e.GeFunctionTotal)
                    .HasMaxLength(50)
                    .HasColumnName("GE_function_total");

                entity.Property(e => e.GenderBodyCol)
                    .HasMaxLength(50)
                    .HasColumnName("gender_body_col");

                entity.Property(e => e.GenderGe)
                    .HasMaxLength(50)
                    .HasColumnName("gender_GE");

                entity.Property(e => e.Gonian)
                    .HasMaxLength(50)
                    .HasColumnName("gonian");

                entity.Property(e => e.HairColor)
                    .HasMaxLength(50)
                    .HasColumnName("hair_color");

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection)
                    .HasMaxLength(50)
                    .HasColumnName("head_direction");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.Humerus)
                    .HasMaxLength(1)
                    .HasColumnName("humerus");

                entity.Property(e => e.HumerusHead)
                    .HasMaxLength(50)
                    .HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength)
                    .HasMaxLength(50)
                    .HasColumnName("humerus_length");

                entity.Property(e => e.IliacCrest)
                    .HasMaxLength(1)
                    .HasColumnName("iliac_crest");

                entity.Property(e => e.InterorbitalBreadth)
                    .HasMaxLength(50)
                    .HasColumnName("interorbital_breadth");

                entity.Property(e => e.LengthOfRemains)
                    .HasMaxLength(50)
                    .HasColumnName("length_of_remains");

                entity.Property(e => e.LowPairEw)
                    .HasMaxLength(50)
                    .HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasMaxLength(50)
                    .HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength)
                    .HasMaxLength(50)
                    .HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasMaxLength(50)
                    .HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialClavicle)
                    .HasMaxLength(1)
                    .HasColumnName("medial_clavicle");

                entity.Property(e => e.MedialIpRamus)
                    .HasMaxLength(50)
                    .HasColumnName("medial_IP_ramus");

                entity.Property(e => e.MonthFound)
                    .HasMaxLength(50)
                    .HasColumnName("month_found");

                entity.Property(e => e.NasionProsthion)
                    .HasMaxLength(50)
                    .HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest)
                    .HasMaxLength(50)
                    .HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge)
                    .HasMaxLength(50)
                    .HasColumnName("orbit_edge");

                entity.Property(e => e.Osteophytosis)
                    .HasMaxLength(50)
                    .HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing)
                    .HasMaxLength(50)
                    .HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies)
                    .HasMaxLength(200)
                    .HasColumnName("pathology_anomalies");

                entity.Property(e => e.PreaurSulcus)
                    .HasMaxLength(50)
                    .HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex)
                    .HasMaxLength(50)
                    .HasColumnName("preservation_index");

                entity.Property(e => e.PubicBone)
                    .HasMaxLength(50)
                    .HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis)
                    .HasMaxLength(50)
                    .HasColumnName("pubic_symphysis");

                entity.Property(e => e.Robust)
                    .HasMaxLength(50)
                    .HasColumnName("robust");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch)
                    .HasMaxLength(50)
                    .HasColumnName("sciatic_notch");

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet)
                    .HasMaxLength(50)
                    .HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead)
                    .HasMaxLength(50)
                    .HasColumnName("south_to_head");

                entity.Property(e => e.SubpubicAngle)
                    .HasMaxLength(50)
                    .HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges)
                    .HasMaxLength(50)
                    .HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength)
                    .HasMaxLength(50)
                    .HasColumnName("tibia_length");

                entity.Property(e => e.ToothAttrition)
                    .HasMaxLength(50)
                    .HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption)
                    .HasMaxLength(50)
                    .HasColumnName("tooth_eruption");

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.VentralArc)
                    .HasMaxLength(50)
                    .HasColumnName("ventral_arc");

                entity.Property(e => e.YearFound)
                    .HasMaxLength(50)
                    .HasColumnName("year_found");

                entity.Property(e => e.ZygomaticCrest)
                    .HasMaxLength(50)
                    .HasColumnName("zygomatic_crest");
            });

            modelBuilder.Entity<C14Data>(entity =>
            {
                entity.HasKey(e => e.BurialId);

                entity.ToTable("C14 DATA");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_ID");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .HasColumnName("AREA");

                entity.Property(e => e.Burial).HasMaxLength(50);

                entity.Property(e => e.C14Sample2017)
                    .HasMaxLength(50)
                    .HasColumnName("C14_Sample_2017");

                entity.Property(e => e.Calibrated95CalendarDateAvg)
                    .HasMaxLength(50)
                    .HasColumnName("Calibrated_95_Calendar_Date_AVG");

                entity.Property(e => e.Calibrated95CalendarDateMax).HasColumnName("Calibrated_95_Calendar_Date_MAX");

                entity.Property(e => e.Calibrated95CalendarDateMin).HasColumnName("Calibrated_95_Calendar_Date_MIN");

                entity.Property(e => e.Calibrated95CalendarDateSpan).HasColumnName("Calibrated_95_Calendar_Date_SPAN");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Column20)
                    .HasMaxLength(50)
                    .HasColumnName("column20");

                entity.Property(e => e.Column29)
                    .HasMaxLength(50)
                    .HasColumnName("column29");

                entity.Property(e => e.Column4)
                    .HasMaxLength(50)
                    .HasColumnName("column4");

                entity.Property(e => e.Column7)
                    .HasMaxLength(50)
                    .HasColumnName("column7");

                entity.Property(e => e.Conventional14cAgeBp).HasColumnName("Conventional_14C_age_BP");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EWLower)
                    .HasMaxLength(50)
                    .HasColumnName("E_W_Lower");

                entity.Property(e => e.EWUpper).HasColumnName("E_W_Upper");

                entity.Property(e => e.Foci).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.NSLower).HasColumnName("N_S_Lower");

                entity.Property(e => e.NSUpper).HasColumnName("N_S_Upper");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.QuestionS)
                    .HasMaxLength(150)
                    .HasColumnName("Question_s");

                entity.Property(e => e.SizeMl).HasColumnName("Size_ml");

                entity.Property(e => e.Square).HasMaxLength(50);

                entity.Property(e => e.Tube)
                    .HasMaxLength(50)
                    .HasColumnName("TUBE");

                entity.Property(e => e._14cCalendarDate).HasColumnName("_14C_Calendar_Date");
            });

            modelBuilder.Entity<Cranial2002>(entity =>
            {
                entity.HasKey(e => e.BurialId);

                entity.ToTable("cranial2002");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_ID");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("Basion_Bregma_Height");

                entity.Property(e => e.BasionNasion).HasColumnName("Basion_Nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("Basion_Prosthion_Length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("Bizygomatic_Diameter");

                entity.Property(e => e.BodyGender).HasMaxLength(50);

                entity.Property(e => e.BurialArtifactDescription)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_Artifact_Description");

                entity.Property(e => e.BurialDepth)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_Depth");

                entity.Property(e => e.BurialNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_Number");

                entity.Property(e => e.BurialPositioningEastWestDirection)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_Positioning_East_West_Direction");

                entity.Property(e => e.BurialPositioningEastWestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_Positioning_East_West_Number");

                entity.Property(e => e.BurialPositioningNorthSouthDirection)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_Positioning_North_South_Direction");

                entity.Property(e => e.BurialPositioningNorthSouthNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_Positioning_North_South_Number");

                entity.Property(e => e.BurialSubPlotDirection)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_sub_plot_direction");

                entity.Property(e => e.BuriedWithArtifacts).HasColumnName("Buried_with_Artifacts");

                entity.Property(e => e.GilesGender).HasMaxLength(1);

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("Interorbital_Breadth");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("Maximum_Cranial_Breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("Maximum_Cranial_Length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("Maximum_Nasal_Breadth");

                entity.Property(e => e.NasionProsthion).HasColumnName("Nasion_Prosthion");

                entity.Property(e => e.SampleNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Sample_Number");
            });

            modelBuilder.Entity<FagElGamousDatabaseByLocation>(entity =>
            {
                entity.HasKey(e => e.BurialId);

                entity.ToTable("Fag_el_Gamous_Database_by_Location");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(50)
                    .HasColumnName("Burial_ID");

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

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

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

                entity.Property(e => e.Length).HasColumnName("length");

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
                    .HasMaxLength(50)
                    .HasColumnName("Burial_ID");

                entity.Property(e => e.Ageatdeath)
                    .HasMaxLength(50)
                    .HasColumnName("AGEATDEATH");

                entity.Property(e => e.Agemethod)
                    .HasMaxLength(50)
                    .HasColumnName("AGEMETHOD");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .HasColumnName("AREA");

                entity.Property(e => e.Burialicon)
                    .HasMaxLength(50)
                    .HasColumnName("BURIALICON");

                entity.Property(e => e.Burialicon2)
                    .HasMaxLength(50)
                    .HasColumnName("BURIALICON2");

                entity.Property(e => e.Burialnum)
                    .HasMaxLength(50)
                    .HasColumnName("BURIALNUM");

                entity.Property(e => e.BurialsquareLower).HasColumnName("BURIALSQUARE_Lower");

                entity.Property(e => e.BurialsquareUpper).HasColumnName("BURIALSQUARE_Upper");

                entity.Property(e => e.Depth)
                    .HasMaxLength(50)
                    .HasColumnName("DEPTH");

                entity.Property(e => e.Eorw)
                    .HasMaxLength(50)
                    .HasColumnName("EORW");

                entity.Property(e => e.Gamous)
                    .HasMaxLength(50)
                    .HasColumnName("GAMOUS");

                entity.Property(e => e.Haircolor)
                    .HasMaxLength(50)
                    .HasColumnName("HAIRCOLOR");

                entity.Property(e => e.Nors)
                    .HasMaxLength(50)
                    .HasColumnName("NORS");

                entity.Property(e => e.Preservation)
                    .HasMaxLength(50)
                    .HasColumnName("PRESERVATION");

                entity.Property(e => e.Sample)
                    .HasMaxLength(50)
                    .HasColumnName("SAMPLE");

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .HasColumnName("SEX");

                entity.Property(e => e.Sexmethod)
                    .HasMaxLength(50)
                    .HasColumnName("SEXMETHOD");

                entity.Property(e => e.Southtofeet)
                    .HasMaxLength(50)
                    .HasColumnName("SOUTHTOFEET");

                entity.Property(e => e.Southtohead)
                    .HasMaxLength(50)
                    .HasColumnName("SOUTHTOHEAD");

                entity.Property(e => e.Sq2Lower)
                    .HasMaxLength(50)
                    .HasColumnName("SQ2_Lower");

                entity.Property(e => e.Sq2Upper).HasColumnName("SQ2_Upper");

                entity.Property(e => e.Westtofeet)
                    .HasMaxLength(50)
                    .HasColumnName("WESTTOFEET");

                entity.Property(e => e.Westtohead)
                    .HasMaxLength(50)
                    .HasColumnName("WESTTOHEAD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
