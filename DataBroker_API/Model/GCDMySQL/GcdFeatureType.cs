using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdFeatureType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GcdFeature> GcdFeatures { get; set; } = new List<GcdFeature>();
}
