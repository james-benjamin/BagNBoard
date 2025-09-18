using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdIssueIndiciaPrinter
{
    public int Id { get; set; }

    public int IssueId { get; set; }

    public int IndiciaprinterId { get; set; }

    public virtual GcdIndiciaPrinter Indiciaprinter { get; set; } = null!;

    public virtual GcdIssue Issue { get; set; } = null!;
}
