using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdGroupCharacter
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Notes { get; set; } = null!;

    public int StoryId { get; set; }

    public int? UniverseId { get; set; }

    public int GroupNameId { get; set; }

    public virtual GcdGroupNameDetail GroupName { get; set; } = null!;

    public virtual GcdStory Story { get; set; } = null!;

    public virtual GcdUniverse? Universe { get; set; }
}
