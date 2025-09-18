using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdStoryCharacter
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public bool IsFlashback { get; set; }

    public bool IsOrigin { get; set; }

    public bool IsDeath { get; set; }

    public string Notes { get; set; } = null!;

    public int CharacterId { get; set; }

    public int? RoleId { get; set; }

    public int StoryId { get; set; }

    public int? UniverseId { get; set; }

    public int? GroupUniverseId { get; set; }

    public virtual GcdCharacterNameDetail Character { get; set; } = null!;

    public virtual ICollection<GcdStoryCharacterGroup> GcdStoryCharacterGroups { get; set; } = new List<GcdStoryCharacterGroup>();

    public virtual GcdUniverse? GroupUniverse { get; set; }

    public virtual GcdCharacterRole? Role { get; set; }

    public virtual GcdStory Story { get; set; } = null!;

    public virtual GcdUniverse? Universe { get; set; }
}
