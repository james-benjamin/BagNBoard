using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class StddataDate
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string Day { get; set; } = null!;

    public bool YearUncertain { get; set; }

    public bool MonthUncertain { get; set; }

    public bool DayUncertain { get; set; }

    public virtual ICollection<GcdCreator> GcdCreatorBirthDates { get; set; } = new List<GcdCreator>();

    public virtual ICollection<GcdCreator> GcdCreatorDeathDates { get; set; } = new List<GcdCreator>();
}
