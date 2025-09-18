using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdStoryType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int SortCode { get; set; }

    public virtual ICollection<GcdStory> GcdStories { get; set; } = new List<GcdStory>();
}
