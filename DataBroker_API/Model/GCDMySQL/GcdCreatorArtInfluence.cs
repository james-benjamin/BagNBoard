using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorArtInfluence
{
    public int Id { get; set; }

    public string InfluenceName { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int CreatorId { get; set; }

    public int? InfluenceLinkId { get; set; }

    public virtual GcdCreator Creator { get; set; } = null!;

    public virtual GcdCreator? InfluenceLink { get; set; }
}
