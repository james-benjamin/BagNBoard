using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class DjangoContentType
{
    public int Id { get; set; }

    public string AppLabel { get; set; } = null!;

    public string Model { get; set; } = null!;

    public virtual ICollection<GcdReceivedAward> GcdReceivedAwards { get; set; } = new List<GcdReceivedAward>();

    public virtual ICollection<TaggitTaggeditem> TaggitTaggeditems { get; set; } = new List<TaggitTaggeditem>();
}
