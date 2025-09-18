using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdReprint
{
    public int Id { get; set; }

    public int? OriginId { get; set; }

    public int? TargetId { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int OriginIssueId { get; set; }

    public int TargetIssueId { get; set; }

    public virtual GcdStory? Origin { get; set; }

    public virtual GcdIssue OriginIssue { get; set; } = null!;

    public virtual GcdStory? Target { get; set; }

    public virtual GcdIssue TargetIssue { get; set; } = null!;
}
