using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdNonComicWorkType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<GcdCreatorNonComicWork> GcdCreatorNonComicWorks { get; set; } = new List<GcdCreatorNonComicWork>();
}
