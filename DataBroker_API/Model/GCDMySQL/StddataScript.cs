using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class StddataScript
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public ushort Number { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GcdCreatorNameDetail> GcdCreatorNameDetails { get; set; } = new List<GcdCreatorNameDetail>();
}
