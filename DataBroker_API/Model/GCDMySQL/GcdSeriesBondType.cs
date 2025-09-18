using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdSeriesBondType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public virtual ICollection<GcdSeriesBond> GcdSeriesBonds { get; set; } = new List<GcdSeriesBond>();
}
