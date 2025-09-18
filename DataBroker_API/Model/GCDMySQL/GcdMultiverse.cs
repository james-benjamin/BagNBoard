using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdMultiverse
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public int MainstreamId { get; set; }

    public virtual ICollection<GcdUniverse> GcdUniverses { get; set; } = new List<GcdUniverse>();

    public virtual GcdUniverse Mainstream { get; set; } = null!;
}
