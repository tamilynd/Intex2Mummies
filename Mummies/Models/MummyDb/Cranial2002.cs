using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mummies.Models.MummyDb
{
    public partial class Cranial2002
    {
        public string BurialId { get; set; }
        public string SampleNumber { get; set; }
        public double? MaximumCranialLength { get; set; }
        public double? MaximumCranialBreadth { get; set; }
        public double? BasionBregmaHeight { get; set; }
        public double? BasionNasion { get; set; }
        public double? BasionProsthionLength { get; set; }
        public double? BizygomaticDiameter { get; set; }
        public double? NasionProsthion { get; set; }
        public double? MaximumNasalBreadth { get; set; }
        public double? InterorbitalBreadth { get; set; }
        public string BurialPositioningNorthSouthNumber { get; set; }
        public string BurialPositioningNorthSouthDirection { get; set; }
        public string BurialPositioningEastWestNumber { get; set; }
        public string BurialPositioningEastWestDirection { get; set; }
        public string BurialNumber { get; set; }
        public string BurialDepth { get; set; }
        public string BurialSubPlotDirection { get; set; }
        public string BurialArtifactDescription { get; set; }
        public bool? BuriedWithArtifacts { get; set; }
        public string GilesGender { get; set; }
        public string BodyGender { get; set; }
    }
}
