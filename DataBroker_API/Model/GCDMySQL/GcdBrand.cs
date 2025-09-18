using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdBrand
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? YearBegan { get; set; }

    public int? YearEnded { get; set; }

    public string Notes { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int IssueCount { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public bool YearBeganUncertain { get; set; }

    public bool YearEndedUncertain { get; set; }

    public int? YearOverallBegan { get; set; }

    public bool YearOverallBeganUncertain { get; set; }

    public int? YearOverallEnded { get; set; }

    public bool YearOverallEndedUncertain { get; set; }

    public bool Generic { get; set; }

    public virtual ICollection<GcdBrandEmblemGroup> GcdBrandEmblemGroups { get; set; } = new List<GcdBrandEmblemGroup>();

    public virtual ICollection<GcdBrandUse> GcdBrandUses { get; set; } = new List<GcdBrandUse>();

    public virtual ICollection<GcdIssue> GcdIssues { get; set; } = new List<GcdIssue>();
}
