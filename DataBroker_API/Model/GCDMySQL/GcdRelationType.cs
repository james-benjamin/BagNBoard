using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdRelationType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string ReverseType { get; set; } = null!;

    public virtual ICollection<GcdCreatorRelation> GcdCreatorRelations { get; set; } = new List<GcdCreatorRelation>();
}
