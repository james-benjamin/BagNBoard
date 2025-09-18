using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdReceivedAward
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public uint? ObjectId { get; set; }

    public string AwardName { get; set; } = null!;

    public bool NoAwardName { get; set; }

    public ushort? AwardYear { get; set; }

    public bool AwardYearUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public int? AwardId { get; set; }

    public int? ContentTypeId { get; set; }

    public virtual GcdAward? Award { get; set; }

    public virtual DjangoContentType? ContentType { get; set; }
}
