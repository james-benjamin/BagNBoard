using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdUniverse
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Multiverse { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int? YearFirstPublished { get; set; }

    public bool YearFirstPublishedUncertain { get; set; }

    public string Description { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public int? VerseId { get; set; }

    public virtual ICollection<GcdCharacter> GcdCharacters { get; set; } = new List<GcdCharacter>();

    public virtual ICollection<GcdGroupCharacter> GcdGroupCharacters { get; set; } = new List<GcdGroupCharacter>();

    public virtual ICollection<GcdGroup> GcdGroups { get; set; } = new List<GcdGroup>();

    public virtual ICollection<GcdMultiverse> GcdMultiverses { get; set; } = new List<GcdMultiverse>();

    public virtual ICollection<GcdStoryCharacter> GcdStoryCharacterGroupUniverses { get; set; } = new List<GcdStoryCharacter>();

    public virtual ICollection<GcdStoryCharacter> GcdStoryCharacterUniverses { get; set; } = new List<GcdStoryCharacter>();

    public virtual GcdMultiverse? Verse { get; set; }
}
