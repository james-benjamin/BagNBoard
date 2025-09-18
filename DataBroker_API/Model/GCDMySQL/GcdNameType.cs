using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdNameType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual ICollection<GcdCreatorNameDetail> GcdCreatorNameDetails { get; set; } = new List<GcdCreatorNameDetail>();
}
