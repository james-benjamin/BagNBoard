using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.BagBoardSQL;

public partial class Variant
{
    public int Id { get; set; }

    public int State { get; set; }

    public int Type { get; set; }

    public int ComicId { get; set; }

    public int CoverArtist { get; set; }

    public string CoverImage { get; set; } = null!;

    public string? Notes { get; set; }

    public int? BarCodes { get; set; }

    public DateOnly DateAdded { get; set; }

    public virtual Comic Comic { get; set; } = null!;
}
