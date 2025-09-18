using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class StddataLanguage
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string NativeName { get; set; } = null!;

    public virtual ICollection<GcdCharacter> GcdCharacters { get; set; } = new List<GcdCharacter>();

    public virtual ICollection<GcdFeature> GcdFeatures { get; set; } = new List<GcdFeature>();

    public virtual ICollection<GcdGroup> GcdGroups { get; set; } = new List<GcdGroup>();

    public virtual ICollection<GcdSeries> GcdSeries { get; set; } = new List<GcdSeries>();
}
