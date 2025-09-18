using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdBiblioEntry
{
    public int StoryPtrId { get; set; }

    public int? PageBegan { get; set; }

    public int? PageEnded { get; set; }

    public string Abstract { get; set; } = null!;

    public string Doi { get; set; } = null!;

    public virtual GcdStory StoryPtr { get; set; } = null!;
}
