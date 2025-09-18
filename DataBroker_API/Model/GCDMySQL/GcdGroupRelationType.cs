using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdGroupRelationType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string ReverseType { get; set; } = null!;

    public virtual ICollection<GcdGroupRelation> GcdGroupRelations { get; set; } = new List<GcdGroupRelation>();
}
