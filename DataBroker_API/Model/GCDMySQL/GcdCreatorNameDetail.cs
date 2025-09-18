using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorNameDetail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int CreatorId { get; set; }

    public int? TypeId { get; set; }

    public string SortName { get; set; } = null!;

    public bool IsOfficialName { get; set; }

    public int InScriptId { get; set; }

    public string FamilyName { get; set; } = null!;

    public string GivenName { get; set; } = null!;

    public virtual GcdCreator Creator { get; set; } = null!;

    public virtual ICollection<GcdCreatorRelationCreatorName> GcdCreatorRelationCreatorNames { get; set; } = new List<GcdCreatorRelationCreatorName>();

    public virtual ICollection<GcdIssueCredit> GcdIssueCredits { get; set; } = new List<GcdIssueCredit>();

    public virtual ICollection<GcdStoryCredit> GcdStoryCredits { get; set; } = new List<GcdStoryCredit>();

    public virtual StddataScript InScript { get; set; } = null!;

    public virtual GcdNameType? Type { get; set; }
}
