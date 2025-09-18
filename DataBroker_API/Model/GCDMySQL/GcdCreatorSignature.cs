using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorSignature
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool Generic { get; set; }

    public int CreatorId { get; set; }

    public virtual GcdCreator Creator { get; set; } = null!;

    public virtual ICollection<GcdStoryCredit> GcdStoryCredits { get; set; } = new List<GcdStoryCredit>();
}
