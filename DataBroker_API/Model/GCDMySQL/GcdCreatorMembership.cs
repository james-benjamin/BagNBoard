using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorMembership
{
    public int Id { get; set; }

    public string OrganizationName { get; set; } = null!;

    public ushort? MembershipYearBegan { get; set; }

    public bool MembershipYearBeganUncertain { get; set; }

    public ushort? MembershipYearEnded { get; set; }

    public bool MembershipYearEndedUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int CreatorId { get; set; }

    public int? MembershipTypeId { get; set; }

    public virtual GcdCreator Creator { get; set; } = null!;

    public virtual GcdMembershipType? MembershipType { get; set; }
}
