using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreditType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int SortCode { get; set; }

    public virtual ICollection<GcdIssueCredit> GcdIssueCredits { get; set; } = new List<GcdIssueCredit>();

    public virtual ICollection<GcdStoryCredit> GcdStoryCredits { get; set; } = new List<GcdStoryCredit>();
}
