using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdNonComicWorkRole
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<GcdCreatorNonComicWork> GcdCreatorNonComicWorks { get; set; } = new List<GcdCreatorNonComicWork>();
}
