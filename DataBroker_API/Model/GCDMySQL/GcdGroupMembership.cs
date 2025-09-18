using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdGroupMembership
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public ushort? YearJoined { get; set; }

    public bool YearJoinedUncertain { get; set; }

    public ushort? YearLeft { get; set; }

    public bool YearLeftUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public int CharacterId { get; set; }

    public int GroupId { get; set; }

    public int MembershipTypeId { get; set; }

    public virtual GcdCharacter Character { get; set; } = null!;

    public virtual GcdGroup Group { get; set; } = null!;

    public virtual GcdGroupMembershipType MembershipType { get; set; } = null!;
}
