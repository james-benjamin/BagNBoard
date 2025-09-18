using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCharacterNameDetail
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public string SortName { get; set; } = null!;

    public int CharacterId { get; set; }

    public bool IsOfficialName { get; set; }

    public virtual GcdCharacter Character { get; set; } = null!;

    public virtual ICollection<GcdStoryCharacter> GcdStoryCharacters { get; set; } = new List<GcdStoryCharacter>();
}
