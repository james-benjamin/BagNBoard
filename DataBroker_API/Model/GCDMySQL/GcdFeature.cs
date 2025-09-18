using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdFeature
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public string Name { get; set; } = null!;

    public string SortName { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public int? YearFirstPublished { get; set; }

    public bool YearFirstPublishedUncertain { get; set; }

    public string Notes { get; set; } = null!;

    public int FeatureTypeId { get; set; }

    public int LanguageId { get; set; }

    public string Disambiguation { get; set; } = null!;

    public virtual GcdFeatureType FeatureType { get; set; } = null!;

    public virtual ICollection<GcdFeatureLogo2Feature> GcdFeatureLogo2Features { get; set; } = new List<GcdFeatureLogo2Feature>();

    public virtual ICollection<GcdFeatureRelation> GcdFeatureRelationFromFeatures { get; set; } = new List<GcdFeatureRelation>();

    public virtual ICollection<GcdFeatureRelation> GcdFeatureRelationToFeatures { get; set; } = new List<GcdFeatureRelation>();

    public virtual ICollection<GcdStoryFeatureObject> GcdStoryFeatureObjects { get; set; } = new List<GcdStoryFeatureObject>();

    public virtual StddataLanguage Language { get; set; } = null!;
}
