using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdSeries
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SortName { get; set; } = null!;

    public string Format { get; set; } = null!;

    public int YearBegan { get; set; }

    public bool YearBeganUncertain { get; set; }

    public int? YearEnded { get; set; }

    public bool YearEndedUncertain { get; set; }

    public string PublicationDates { get; set; } = null!;

    public int? FirstIssueId { get; set; }

    public int? LastIssueId { get; set; }

    public bool IsCurrent { get; set; }

    public int PublisherId { get; set; }

    public int CountryId { get; set; }

    public int LanguageId { get; set; }

    public string TrackingNotes { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool HasGallery { get; set; }

    public int IssueCount { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public bool? HasIndiciaFrequency { get; set; }

    public bool? HasIsbn { get; set; }

    public bool? HasBarcode { get; set; }

    public bool HasIssueTitle { get; set; }

    public bool? HasVolume { get; set; }

    public bool? IsComicsPublication { get; set; }

    public string Color { get; set; } = null!;

    public string Dimensions { get; set; } = null!;

    public string PaperStock { get; set; } = null!;

    public string Binding { get; set; } = null!;

    public string PublishingFormat { get; set; } = null!;

    public bool HasRating { get; set; }

    public int? PublicationTypeId { get; set; }

    public bool IsSingleton { get; set; }

    public bool HasAboutComics { get; set; }

    public bool HasIndiciaPrinter { get; set; }

    public bool HasPublisherCodeNumber { get; set; }

    public virtual StddataCountry Country { get; set; } = null!;

    public virtual GcdIssue? FirstIssue { get; set; }

    public virtual ICollection<GcdIssue> GcdIssues { get; set; } = new List<GcdIssue>();

    public virtual ICollection<GcdSeriesBond> GcdSeriesBondOrigins { get; set; } = new List<GcdSeriesBond>();

    public virtual ICollection<GcdSeriesBond> GcdSeriesBondTargets { get; set; } = new List<GcdSeriesBond>();

    public virtual StddataLanguage Language { get; set; } = null!;

    public virtual GcdIssue? LastIssue { get; set; }

    public virtual GcdSeriesPublicationType? PublicationType { get; set; }

    public virtual GcdPublisher Publisher { get; set; } = null!;
}
