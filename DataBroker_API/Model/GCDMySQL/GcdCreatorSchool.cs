using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorSchool
{
    public int Id { get; set; }

    public ushort? SchoolYearBegan { get; set; }

    public bool SchoolYearBeganUncertain { get; set; }

    public ushort? SchoolYearEnded { get; set; }

    public bool SchoolYearEndedUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int CreatorId { get; set; }

    public int SchoolId { get; set; }

    public virtual GcdCreator Creator { get; set; } = null!;

    public virtual GcdSchool School { get; set; } = null!;
}
