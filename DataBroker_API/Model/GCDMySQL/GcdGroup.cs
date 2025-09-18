using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdGroup
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public string SortName { get; set; } = null!;

    public string Disambiguation { get; set; } = null!;

    public int? YearFirstPublished { get; set; }

    public bool YearFirstPublishedUncertain { get; set; }

    public string Description { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public int LanguageId { get; set; }

    public int? UniverseId { get; set; }

    public virtual ICollection<GcdGroupMembership> GcdGroupMemberships { get; set; } = new List<GcdGroupMembership>();

    public virtual ICollection<GcdGroupNameDetail> GcdGroupNameDetails { get; set; } = new List<GcdGroupNameDetail>();

    public virtual ICollection<GcdGroupRelation> GcdGroupRelationFromGroups { get; set; } = new List<GcdGroupRelation>();

    public virtual ICollection<GcdGroupRelation> GcdGroupRelationToGroups { get; set; } = new List<GcdGroupRelation>();

    public virtual ICollection<GcdStoryCharacterGroup> GcdStoryCharacterGroups { get; set; } = new List<GcdStoryCharacterGroup>();

    public virtual StddataLanguage Language { get; set; } = null!;

    public virtual GcdUniverse? Universe { get; set; }
}
