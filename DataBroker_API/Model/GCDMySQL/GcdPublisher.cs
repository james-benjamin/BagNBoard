using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdPublisher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public int? YearBegan { get; set; }

    public int? YearEnded { get; set; }

    public string Notes { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int BrandCount { get; set; }

    public int IndiciaPublisherCount { get; set; }

    public int SeriesCount { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int IssueCount { get; set; }

    public bool Deleted { get; set; }

    public bool YearBeganUncertain { get; set; }

    public bool YearEndedUncertain { get; set; }

    public int? YearOverallBegan { get; set; }

    public bool YearOverallBeganUncertain { get; set; }

    public int? YearOverallEnded { get; set; }

    public bool YearOverallEndedUncertain { get; set; }

    public virtual StddataCountry Country { get; set; } = null!;

    public virtual ICollection<GcdBrandGroup> GcdBrandGroups { get; set; } = new List<GcdBrandGroup>();

    public virtual ICollection<GcdBrandUse> GcdBrandUses { get; set; } = new List<GcdBrandUse>();

    public virtual ICollection<GcdIndiciaPublisher> GcdIndiciaPublishers { get; set; } = new List<GcdIndiciaPublisher>();

    public virtual ICollection<GcdSeries> GcdSeries { get; set; } = new List<GcdSeries>();
}
