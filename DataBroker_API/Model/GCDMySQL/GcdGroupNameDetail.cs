using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdGroupNameDetail
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public string SortName { get; set; } = null!;

    public bool IsOfficialName { get; set; }

    public int GroupId { get; set; }

    public virtual ICollection<GcdGroupCharacter> GcdGroupCharacters { get; set; } = new List<GcdGroupCharacter>();

    public virtual GcdGroup Group { get; set; } = null!;
}
