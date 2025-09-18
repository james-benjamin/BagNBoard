using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class TaggitTag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public virtual ICollection<TaggitTaggeditem> TaggitTaggeditems { get; set; } = new List<TaggitTaggeditem>();
}
