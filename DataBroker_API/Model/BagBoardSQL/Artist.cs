using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.BagBoardSQL;

public partial class Artist
{
    public int Id { get; set; }

    public int State { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
