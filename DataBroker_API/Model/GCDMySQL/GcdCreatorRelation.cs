using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorRelation
{
    public int Id { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int FromCreatorId { get; set; }

    public int RelationTypeId { get; set; }

    public int ToCreatorId { get; set; }

    public virtual GcdCreator FromCreator { get; set; } = null!;

    public virtual ICollection<GcdCreatorRelationCreatorName> GcdCreatorRelationCreatorNames { get; set; } = new List<GcdCreatorRelationCreatorName>();

    public virtual GcdRelationType RelationType { get; set; } = null!;

    public virtual GcdCreator ToCreator { get; set; } = null!;
}
