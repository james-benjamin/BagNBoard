using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdSeriesBond
{
    public int Id { get; set; }

    public int OriginId { get; set; }

    public int TargetId { get; set; }

    public int? OriginIssueId { get; set; }

    public int? TargetIssueId { get; set; }

    public int BondTypeId { get; set; }

    public string Notes { get; set; } = null!;

    public bool Reserved { get; set; }

    public virtual GcdSeriesBondType BondType { get; set; } = null!;

    public virtual GcdSeries Origin { get; set; } = null!;

    public virtual GcdIssue? OriginIssue { get; set; }

    public virtual GcdSeries Target { get; set; } = null!;

    public virtual GcdIssue? TargetIssue { get; set; }
}
