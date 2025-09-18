using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCharacterRelationType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string ReverseType { get; set; } = null!;

    public virtual ICollection<GcdCharacterRelation> GcdCharacterRelations { get; set; } = new List<GcdCharacterRelation>();
}
