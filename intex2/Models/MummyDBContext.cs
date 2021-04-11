using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace intex2.Models
{
    public partial class MummyDBContext : DbContext
    {
        public MummyDBContext()
        {
        }

        public MummyDBContext(DbContextOptions<MummyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artifact> Artifacts { get; set; }
        public virtual DbSet<BiologicalSample> BiologicalSamples { get; set; }
        public virtual DbSet<BurialCharacteristic> BurialCharacteristics { get; set; }
        public virtual DbSet<BurialId> BurialIds { get; set; }
        public virtual DbSet<BurialNote> BurialNotes { get; set; }
        public virtual DbSet<RemainsCharacteristic> RemainsCharacteristics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = mummyintexdb.chtyw6mkdxcw.us-east-1.rds.amazonaws.com; Database = MummyDB; User Id = admin; Password = thisistheadminpassword;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artifact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Artifacts$");

                entity.Property(e => e.ArtifactDescription)
                    .HasMaxLength(255)
                    .HasColumnName("artifact_description");

                entity.Property(e => e.ArtifactId)
                    .HasMaxLength(255)
                    .HasColumnName("artifact_id");

                entity.Property(e => e.BagNum)
                    .HasMaxLength(255)
                    .HasColumnName("bag_num");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(255)
                    .HasColumnName("burial_id");

                entity.Property(e => e.PhotoDate)
                    .HasMaxLength(255)
                    .HasColumnName("photo_date");

                entity.Property(e => e.RackNum)
                    .HasMaxLength(255)
                    .HasColumnName("rack_num");

                entity.Property(e => e.Sampled)
                    .HasMaxLength(255)
                    .HasColumnName("sampled");

                entity.Property(e => e.SampledDate)
                    .HasMaxLength(255)
                    .HasColumnName("sampled_date");

                entity.Property(e => e.ScientificDate)
                    .HasMaxLength(255)
                    .HasColumnName("scientific_date");
            });

            modelBuilder.Entity<BiologicalSample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Biological_Samples$");

                entity.Property(e => e.BagNum)
                    .HasMaxLength(255)
                    .HasColumnName("bag_num");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("Basion-Bregma Height");

                entity.Property(e => e.BasionNasion).HasColumnName("Basion-Nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("Basion-Prosthion Length");

                entity.Property(e => e.BiosampleId).HasColumnName("biosample_id");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("Bizygomatic Diameter");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(255)
                    .HasColumnName("burial_id");

                entity.Property(e => e.ClusterNum).HasColumnName("cluster_num");

                entity.Property(e => e.Initials)
                    .HasMaxLength(255)
                    .HasColumnName("initials");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("Interorbital Breadth");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("Maximum Cranial Breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("Maximum Cranial Length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("Maximum Nasal Breadth");

                entity.Property(e => e.NasionProsthion).HasColumnName("Nasion-Prosthion");

                entity.Property(e => e.PreviouslySampled)
                    .HasMaxLength(255)
                    .HasColumnName("previously_sampled");

                entity.Property(e => e.RackNum).HasColumnName("rack_num");

                entity.Property(e => e.SampleDate).HasColumnName("sample_date");

                entity.Property(e => e.SampleNotes)
                    .HasMaxLength(255)
                    .HasColumnName("sample_notes");

                entity.Property(e => e.SampleNumber).HasColumnName("Sample Number");
            });

            modelBuilder.Entity<BurialCharacteristic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Burial_Characteristics$");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(255)
                    .HasColumnName("burial_id");

                entity.Property(e => e.Cluster)
                    .HasMaxLength(255)
                    .HasColumnName("cluster");

                entity.Property(e => e.DayFound)
                    .HasMaxLength(255)
                    .HasColumnName("day_found");

                entity.Property(e => e.DepthRemains).HasColumnName("depth_remains");

                entity.Property(e => e.HeadDirection)
                    .HasMaxLength(255)
                    .HasColumnName("head_direction");

                entity.Property(e => e.LengthRemainsCalculated)
                    .HasMaxLength(255)
                    .HasColumnName("length_remains_calculated");

                entity.Property(e => e.LengthRemainsMeasured)
                    .HasMaxLength(255)
                    .HasColumnName("length_remains_measured");

                entity.Property(e => e.MonthFound)
                    .HasMaxLength(255)
                    .HasColumnName("month_found");

                entity.Property(e => e.SouthToFeet).HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead).HasColumnName("south_to_head");

                entity.Property(e => e.WestToFeet).HasColumnName("west_to_feet");

                entity.Property(e => e.WestToHead).HasColumnName("west_to_head");

                entity.Property(e => e.YearFound)
                    .HasMaxLength(255)
                    .HasColumnName("year_found");
            });

            modelBuilder.Entity<BurialId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Burial_ID$");

                entity.Property(e => e.BurialArea)
                    .HasMaxLength(255)
                    .HasColumnName("burial_area");

                entity.Property(e => e.BurialId1)
                    .HasMaxLength(255)
                    .HasColumnName("burial_id");

                entity.Property(e => e.BurialLocationEw)
                    .HasMaxLength(255)
                    .HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs)
                    .HasMaxLength(255)
                    .HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialNum).HasColumnName("burial_num");

                entity.Property(e => e.F10).HasMaxLength(255);

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");
            });

            modelBuilder.Entity<BurialNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Burial_Notes$");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(255)
                    .HasColumnName("burial_id");

                entity.Property(e => e.BurialNotes).HasColumnName("burial_notes");

                entity.Property(e => e.OsteologyNotes)
                    .HasMaxLength(255)
                    .HasColumnName("osteology_notes");
            });

            modelBuilder.Entity<RemainsCharacteristic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Remains_Characteristics$");

                entity.Property(e => e.BasilarSuture)
                    .HasMaxLength(255)
                    .HasColumnName("basilar_suture");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BoneLength)
                    .HasMaxLength(255)
                    .HasColumnName("bone_length");

                entity.Property(e => e.BurialId)
                    .HasMaxLength(255)
                    .HasColumnName("burial_id");

                entity.Property(e => e.BurialWrapping)
                    .HasMaxLength(255)
                    .HasColumnName("burial_wrapping");

                entity.Property(e => e.CranialSuture)
                    .HasMaxLength(255)
                    .HasColumnName("cranial_suture");

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EpiphysealUnion)
                    .HasMaxLength(255)
                    .HasColumnName("epiphyseal_union");

                entity.Property(e => e.EstimateAge)
                    .HasMaxLength(255)
                    .HasColumnName("estimate_age");

                entity.Property(e => e.EstimateLivingStature).HasColumnName("estimate_living_stature");

                entity.Property(e => e.FaceBundle)
                    .HasMaxLength(255)
                    .HasColumnName("face_bundle");

                entity.Property(e => e.FemurDiameter)
                    .HasMaxLength(255)
                    .HasColumnName("femur_diameter");

                entity.Property(e => e.FemurHead).HasColumnName("femur_head");

                entity.Property(e => e.FemurLength).HasColumnName("femur_length");

                entity.Property(e => e.ForemanMagnum)
                    .HasMaxLength(255)
                    .HasColumnName("foreman_magnum");

                entity.Property(e => e.GeFunctionTotal).HasColumnName("GE_function_total");

                entity.Property(e => e.GenderBodyCol)
                    .HasMaxLength(255)
                    .HasColumnName("gender_body_col");

                entity.Property(e => e.GenderGe)
                    .HasMaxLength(255)
                    .HasColumnName("gender_GE");

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.HairColor)
                    .HasMaxLength(255)
                    .HasColumnName("hair_color");

                entity.Property(e => e.Humerus)
                    .HasMaxLength(255)
                    .HasColumnName("humerus");

                entity.Property(e => e.HumerusHead).HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength).HasColumnName("humerus_length");

                entity.Property(e => e.IliacCrest)
                    .HasMaxLength(255)
                    .HasColumnName("iliac_crest");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialClavicle)
                    .HasMaxLength(255)
                    .HasColumnName("medial_clavicle");

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_IP_ramus");

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.Osteophytosis)
                    .HasMaxLength(255)
                    .HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies)
                    .HasMaxLength(255)
                    .HasColumnName("pathology_anomalies");

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex)
                    .HasMaxLength(255)
                    .HasColumnName("preservation_index");

                entity.Property(e => e.PreservationNotes)
                    .HasMaxLength(255)
                    .HasColumnName("preservation_notes");

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis)
                    .HasMaxLength(255)
                    .HasColumnName("pubic_symphysis");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TibiaLength).HasColumnName("tibia_length");

                entity.Property(e => e.ToothAttrition)
                    .HasMaxLength(255)
                    .HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption)
                    .HasMaxLength(255)
                    .HasColumnName("tooth_eruption");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
