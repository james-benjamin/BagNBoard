using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdFeatureRelationType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ReverseDescription { get; set; } = null!;

    public virtual ICollection<GcdFeatureRelation> GcdFeatureRelations { get; set; } = new List<GcdFeatureRelation>();
}
