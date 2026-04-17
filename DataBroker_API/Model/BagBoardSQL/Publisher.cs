using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.BagBoardSQL;

public partial class Publisher
{
    public int Id { get; set; }

    public int State { get; set; }

    public string Company { get; set; } = null!;

    public DateOnly DateCreated { get; set; }
}
