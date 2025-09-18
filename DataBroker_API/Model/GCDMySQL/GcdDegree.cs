using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdDegree
{
    public int Id { get; set; }

    public string DegreeName { get; set; } = null!;

    public virtual ICollection<GcdCreatorDegree> GcdCreatorDegrees { get; set; } = new List<GcdCreatorDegree>();
}
