using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class StddataCountry
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<GcdCreator> GcdCreatorBirthCountries { get; set; } = new List<GcdCreator>();

    public virtual ICollection<GcdCreator> GcdCreatorDeathCountries { get; set; } = new List<GcdCreator>();

    public virtual ICollection<GcdIndiciaPrinter> GcdIndiciaPrinters { get; set; } = new List<GcdIndiciaPrinter>();

    public virtual ICollection<GcdIndiciaPublisher> GcdIndiciaPublishers { get; set; } = new List<GcdIndiciaPublisher>();

    public virtual ICollection<GcdPrinter> GcdPrinters { get; set; } = new List<GcdPrinter>();

    public virtual ICollection<GcdPublisher> GcdPublishers { get; set; } = new List<GcdPublisher>();

    public virtual ICollection<GcdSeries> GcdSeries { get; set; } = new List<GcdSeries>();
}
