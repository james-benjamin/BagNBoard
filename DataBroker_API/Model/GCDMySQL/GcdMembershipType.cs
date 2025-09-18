using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdMembershipType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<GcdCreatorMembership> GcdCreatorMemberships { get; set; } = new List<GcdCreatorMembership>();
}
