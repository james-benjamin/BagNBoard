using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCharacterRole
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int SortCode { get; set; }

    public virtual ICollection<GcdStoryCharacter> GcdStoryCharacters { get; set; } = new List<GcdStoryCharacter>();
}
