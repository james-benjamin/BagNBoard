using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class TaggitTaggeditem
{
    public int Id { get; set; }

    public int TagId { get; set; }

    public int ObjectId { get; set; }

    public int ContentTypeId { get; set; }

    public virtual DjangoContentType ContentType { get; set; } = null!;

    public virtual TaggitTag Tag { get; set; } = null!;
}
