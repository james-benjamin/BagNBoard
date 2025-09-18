using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorNonComicWork
{
    public int Id { get; set; }

    public string PublicationTitle { get; set; } = null!;

    public string EmployerName { get; set; } = null!;

    public string WorkTitle { get; set; } = null!;

    public string WorkUrls { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int CreatorId { get; set; }

    public int? WorkRoleId { get; set; }

    public int WorkTypeId { get; set; }

    public virtual GcdCreator Creator { get; set; } = null!;

    public virtual ICollection<GcdNonComicWorkYear> GcdNonComicWorkYears { get; set; } = new List<GcdNonComicWorkYear>();

    public virtual GcdNonComicWorkRole? WorkRole { get; set; }

    public virtual GcdNonComicWorkType WorkType { get; set; } = null!;
}
