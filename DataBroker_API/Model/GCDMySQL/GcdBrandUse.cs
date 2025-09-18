using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdBrandUse
{
    public int Id { get; set; }

    public int PublisherId { get; set; }

    public int EmblemId { get; set; }

    public int? YearBegan { get; set; }

    public int? YearEnded { get; set; }

    public bool YearBeganUncertain { get; set; }

    public bool YearEndedUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual GcdBrand Emblem { get; set; } = null!;

    public virtual GcdPublisher Publisher { get; set; } = null!;
}
