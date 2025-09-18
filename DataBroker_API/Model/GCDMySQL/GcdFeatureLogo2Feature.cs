using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdFeatureLogo2Feature
{
    public int Id { get; set; }

    public int FeaturelogoId { get; set; }

    public int FeatureId { get; set; }

    public virtual GcdFeature Feature { get; set; } = null!;

    public virtual GcdFeatureLogo Featurelogo { get; set; } = null!;
}
