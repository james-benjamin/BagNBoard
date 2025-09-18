using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdNonComicWorkYear
{
    public int Id { get; set; }

    public ushort? WorkYear { get; set; }

    public bool WorkYearUncertain { get; set; }

    public int NonComicWorkId { get; set; }

    public virtual GcdCreatorNonComicWork NonComicWork { get; set; } = null!;
}
