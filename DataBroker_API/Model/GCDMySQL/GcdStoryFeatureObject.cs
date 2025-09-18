using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdStoryFeatureObject
{
    public int Id { get; set; }

    public int StoryId { get; set; }

    public int FeatureId { get; set; }

    public virtual GcdFeature Feature { get; set; } = null!;

    public virtual GcdStory Story { get; set; } = null!;
}
