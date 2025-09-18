using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdAward
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Created { get; set; }

    public bool Deleted { get; set; }

    public DateTime Modified { get; set; }

    public string Notes { get; set; } = null!;

    public virtual ICollection<GcdReceivedAward> GcdReceivedAwards { get; set; } = new List<GcdReceivedAward>();
}
