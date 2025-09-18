using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdGroupRelation
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Notes { get; set; } = null!;

    public int FromGroupId { get; set; }

    public int RelationTypeId { get; set; }

    public int ToGroupId { get; set; }

    public virtual GcdGroup FromGroup { get; set; } = null!;

    public virtual GcdGroupRelationType RelationType { get; set; } = null!;

    public virtual GcdGroup ToGroup { get; set; } = null!;
}
