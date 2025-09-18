using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdIssueCredit
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public bool IsCredited { get; set; }

    public bool Uncertain { get; set; }

    public string CreditedAs { get; set; } = null!;

    public string CreditName { get; set; } = null!;

    public int CreatorId { get; set; }

    public int CreditTypeId { get; set; }

    public int IssueId { get; set; }

    public bool IsSourced { get; set; }

    public string SourcedBy { get; set; } = null!;

    public virtual GcdCreatorNameDetail Creator { get; set; } = null!;

    public virtual GcdCreditType CreditType { get; set; } = null!;

    public virtual GcdIssue Issue { get; set; } = null!;
}
