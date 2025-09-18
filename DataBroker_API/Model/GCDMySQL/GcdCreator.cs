using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreator
{
    public int Id { get; set; }

    public string GcdOfficialName { get; set; } = null!;

    public string? WhosWho { get; set; }

    public bool BirthCountryUncertain { get; set; }

    public string BirthProvince { get; set; } = null!;

    public bool BirthProvinceUncertain { get; set; }

    public string BirthCity { get; set; } = null!;

    public bool BirthCityUncertain { get; set; }

    public bool DeathCountryUncertain { get; set; }

    public string DeathProvince { get; set; } = null!;

    public bool DeathProvinceUncertain { get; set; }

    public string DeathCity { get; set; } = null!;

    public bool DeathCityUncertain { get; set; }

    public string Bio { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public int? BirthCountryId { get; set; }

    public int? BirthDateId { get; set; }

    public int? DeathCountryId { get; set; }

    public int? DeathDateId { get; set; }

    public string SortName { get; set; } = null!;

    public string Disambiguation { get; set; } = null!;

    public virtual StddataCountry? BirthCountry { get; set; }

    public virtual StddataDate? BirthDate { get; set; }

    public virtual StddataCountry? DeathCountry { get; set; }

    public virtual StddataDate? DeathDate { get; set; }

    public virtual ICollection<GcdCreatorArtInfluence> GcdCreatorArtInfluenceCreators { get; set; } = new List<GcdCreatorArtInfluence>();

    public virtual ICollection<GcdCreatorArtInfluence> GcdCreatorArtInfluenceInfluenceLinks { get; set; } = new List<GcdCreatorArtInfluence>();

    public virtual ICollection<GcdCreatorDegree> GcdCreatorDegrees { get; set; } = new List<GcdCreatorDegree>();

    public virtual ICollection<GcdCreatorMembership> GcdCreatorMemberships { get; set; } = new List<GcdCreatorMembership>();

    public virtual ICollection<GcdCreatorNameDetail> GcdCreatorNameDetails { get; set; } = new List<GcdCreatorNameDetail>();

    public virtual ICollection<GcdCreatorNonComicWork> GcdCreatorNonComicWorks { get; set; } = new List<GcdCreatorNonComicWork>();

    public virtual ICollection<GcdCreatorRelation> GcdCreatorRelationFromCreators { get; set; } = new List<GcdCreatorRelation>();

    public virtual ICollection<GcdCreatorRelation> GcdCreatorRelationToCreators { get; set; } = new List<GcdCreatorRelation>();

    public virtual ICollection<GcdCreatorSchool> GcdCreatorSchools { get; set; } = new List<GcdCreatorSchool>();

    public virtual ICollection<GcdCreatorSignature> GcdCreatorSignatures { get; set; } = new List<GcdCreatorSignature>();
}
