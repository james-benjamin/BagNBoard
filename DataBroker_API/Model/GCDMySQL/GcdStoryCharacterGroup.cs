using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdStoryCharacterGroup
{
    public int Id { get; set; }

    public int StorycharacterId { get; set; }

    public int GroupId { get; set; }

    public virtual GcdGroup Group { get; set; } = null!;

    public virtual GcdStoryCharacter Storycharacter { get; set; } = null!;
}
