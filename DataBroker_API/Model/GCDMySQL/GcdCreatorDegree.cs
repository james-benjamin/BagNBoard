using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorDegree
{
    public int Id { get; set; }

    public ushort? DegreeYear { get; set; }

    public bool DegreeYearUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int CreatorId { get; set; }

    public int DegreeId { get; set; }

    public int? SchoolId { get; set; }

    public virtual GcdCreator Creator { get; set; } = null!;

    public virtual GcdDegree Degree { get; set; } = null!;

    public virtual GcdSchool? School { get; set; }
}
