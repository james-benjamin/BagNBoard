using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdFeatureLogo
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public string SortName { get; set; } = null!;

    public int? YearBegan { get; set; }

    public int? YearEnded { get; set; }

    public bool YearBeganUncertain { get; set; }

    public bool YearEndedUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public bool Generic { get; set; }

    public virtual ICollection<GcdFeatureLogo2Feature> GcdFeatureLogo2Features { get; set; } = new List<GcdFeatureLogo2Feature>();

    public virtual ICollection<GcdStoryFeatureLogo> GcdStoryFeatureLogos { get; set; } = new List<GcdStoryFeatureLogo>();
}
