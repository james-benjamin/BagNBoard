using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.BagBoardSQL;

public partial class VirtualBox
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string HeroImage { get; set; } = null!;

    public int ComicCount { get; set; }

    public DateOnly DateCreated { get; set; }
}
