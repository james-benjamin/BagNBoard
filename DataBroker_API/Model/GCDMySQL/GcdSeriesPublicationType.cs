using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdSeriesPublicationType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public virtual ICollection<GcdSeries> GcdSeries { get; set; } = new List<GcdSeries>();
}
