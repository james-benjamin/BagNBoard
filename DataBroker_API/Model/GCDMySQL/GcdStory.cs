using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdStory
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool TitleInferred { get; set; }

    public string Feature { get; set; } = null!;

    public int SequenceNumber { get; set; }

    public decimal? PageCount { get; set; }

    public int IssueId { get; set; }

    public string Script { get; set; } = null!;

    public string Pencils { get; set; } = null!;

    public string Inks { get; set; } = null!;

    public string Colors { get; set; } = null!;

    public string Letters { get; set; } = null!;

    public string Editing { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public string Characters { get; set; } = null!;

    public string Synopsis { get; set; } = null!;

    public string ReprintNotes { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Notes { get; set; } = null!;

    public bool NoScript { get; set; }

    public bool NoPencils { get; set; }

    public bool NoInks { get; set; }

    public bool NoColors { get; set; }

    public bool NoLetters { get; set; }

    public bool NoEditing { get; set; }

    public bool PageCountUncertain { get; set; }

    public int TypeId { get; set; }

    public string JobNumber { get; set; } = null!;

    public bool Deleted { get; set; }

    public string FirstLine { get; set; } = null!;

    public virtual GcdBiblioEntry? GcdBiblioEntry { get; set; }

    public virtual ICollection<GcdGroupCharacter> GcdGroupCharacters { get; set; } = new List<GcdGroupCharacter>();

    public virtual ICollection<GcdReprint> GcdReprintOrigins { get; set; } = new List<GcdReprint>();

    public virtual ICollection<GcdReprint> GcdReprintTargets { get; set; } = new List<GcdReprint>();

    public virtual ICollection<GcdStoryCharacter> GcdStoryCharacters { get; set; } = new List<GcdStoryCharacter>();

    public virtual ICollection<GcdStoryCredit> GcdStoryCredits { get; set; } = new List<GcdStoryCredit>();

    public virtual ICollection<GcdStoryFeatureLogo> GcdStoryFeatureLogos { get; set; } = new List<GcdStoryFeatureLogo>();

    public virtual ICollection<GcdStoryFeatureObject> GcdStoryFeatureObjects { get; set; } = new List<GcdStoryFeatureObject>();

    public virtual GcdIssue Issue { get; set; } = null!;

    public virtual GcdStoryType Type { get; set; } = null!;
}
