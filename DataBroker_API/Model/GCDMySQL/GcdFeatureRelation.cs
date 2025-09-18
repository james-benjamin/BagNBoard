using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdFeatureRelation
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Notes { get; set; } = null!;

    public int FromFeatureId { get; set; }

    public int RelationTypeId { get; set; }

    public int ToFeatureId { get; set; }

    public virtual GcdFeature FromFeature { get; set; } = null!;

    public virtual GcdFeatureRelationType RelationType { get; set; } = null!;

    public virtual GcdFeature ToFeature { get; set; } = null!;
}
