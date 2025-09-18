using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdGroupMembershipType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string ReverseType { get; set; } = null!;

    public virtual ICollection<GcdGroupMembership> GcdGroupMemberships { get; set; } = new List<GcdGroupMembership>();
}
