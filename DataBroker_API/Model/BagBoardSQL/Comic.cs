using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.BagBoardSQL;

public partial class Comic
{
    public int Id { get; set; }

    public int State { get; set; }

    public string Title { get; set; } = null!;

    public string? PrintRun { get; set; }

    public int CoverArtist { get; set; }

    public string CoverImage { get; set; } = null!;

    public int Writer { get; set; }

    public int PublisherId { get; set; }

    public string ComicImage { get; set; } = null!;

    public string? Notes { get; set; }

    public int? BarCode { get; set; }

    public DateOnly DateAdded { get; set; }

    public virtual ICollection<Variant> Variants { get; set; } = new List<Variant>();
}
