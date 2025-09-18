using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdStoryFeatureLogo
{
    public int Id { get; set; }

    public int StoryId { get; set; }

    public int FeaturelogoId { get; set; }

    public virtual GcdFeatureLogo Featurelogo { get; set; } = null!;

    public virtual GcdStory Story { get; set; } = null!;
}
