using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdSchool
{
    public int Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public virtual ICollection<GcdCreatorDegree> GcdCreatorDegrees { get; set; } = new List<GcdCreatorDegree>();

    public virtual ICollection<GcdCreatorSchool> GcdCreatorSchools { get; set; } = new List<GcdCreatorSchool>();
}
