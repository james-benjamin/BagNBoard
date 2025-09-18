using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdIssue
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public string Volume { get; set; } = null!;

    public bool NoVolume { get; set; }

    public bool DisplayVolumeWithNumber { get; set; }

    public int SeriesId { get; set; }

    public int? IndiciaPublisherId { get; set; }

    public bool IndiciaPubNotPrinted { get; set; }

    public int? BrandId { get; set; }

    public bool NoBrand { get; set; }

    public string PublicationDate { get; set; } = null!;

    public string KeyDate { get; set; } = null!;

    public int SortCode { get; set; }

    public string Price { get; set; } = null!;

    public decimal? PageCount { get; set; }

    public bool PageCountUncertain { get; set; }

    public string IndiciaFrequency { get; set; } = null!;

    public bool NoIndiciaFrequency { get; set; }

    public string Editing { get; set; } = null!;

    public bool NoEditing { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public bool IsIndexed { get; set; }

    public string Isbn { get; set; } = null!;

    public string ValidIsbn { get; set; } = null!;

    public bool NoIsbn { get; set; }

    public int? VariantOfId { get; set; }

    public string VariantName { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public bool NoBarcode { get; set; }

    public string Title { get; set; } = null!;

    public bool NoTitle { get; set; }

    public string OnSaleDate { get; set; } = null!;

    public bool OnSaleDateUncertain { get; set; }

    public string Rating { get; set; } = null!;

    public bool NoRating { get; set; }

    public bool VolumeNotPrinted { get; set; }

    public bool NoIndiciaPrinter { get; set; }

    public int VariantCoverStatus { get; set; }

    public virtual GcdBrand? Brand { get; set; }

    public virtual ICollection<GcdIssueCredit> GcdIssueCredits { get; set; } = new List<GcdIssueCredit>();

    public virtual ICollection<GcdIssueIndiciaPrinter> GcdIssueIndiciaPrinters { get; set; } = new List<GcdIssueIndiciaPrinter>();

    public virtual ICollection<GcdReprint> GcdReprintOriginIssues { get; set; } = new List<GcdReprint>();

    public virtual ICollection<GcdReprint> GcdReprintTargetIssues { get; set; } = new List<GcdReprint>();

    public virtual ICollection<GcdSeriesBond> GcdSeriesBondOriginIssues { get; set; } = new List<GcdSeriesBond>();

    public virtual ICollection<GcdSeriesBond> GcdSeriesBondTargetIssues { get; set; } = new List<GcdSeriesBond>();

    public virtual ICollection<GcdSeries> GcdSeriesFirstIssues { get; set; } = new List<GcdSeries>();

    public virtual ICollection<GcdSeries> GcdSeriesLastIssues { get; set; } = new List<GcdSeries>();

    public virtual ICollection<GcdStory> GcdStories { get; set; } = new List<GcdStory>();

    public virtual GcdIndiciaPublisher? IndiciaPublisher { get; set; }

    public virtual ICollection<GcdIssue> InverseVariantOf { get; set; } = new List<GcdIssue>();

    public virtual GcdSeries Series { get; set; } = null!;

    public virtual GcdIssue? VariantOf { get; set; }
}
