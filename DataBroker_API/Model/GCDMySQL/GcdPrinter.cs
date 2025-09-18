using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdPrinter
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public int? YearBegan { get; set; }

    public int? YearEnded { get; set; }

    public bool YearBeganUncertain { get; set; }

    public bool YearEndedUncertain { get; set; }

    public int? YearOverallBegan { get; set; }

    public int? YearOverallEnded { get; set; }

    public bool YearOverallBeganUncertain { get; set; }

    public bool YearOverallEndedUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int IndiciaPrinterCount { get; set; }

    public int IssueCount { get; set; }

    public int CountryId { get; set; }

    public virtual StddataCountry Country { get; set; } = null!;

    public virtual ICollection<GcdIndiciaPrinter> GcdIndiciaPrinters { get; set; } = new List<GcdIndiciaPrinter>();
}
