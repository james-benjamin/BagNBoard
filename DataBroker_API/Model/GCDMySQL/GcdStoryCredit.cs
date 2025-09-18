using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdStoryCredit
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool Deleted { get; set; }

    public bool IsCredited { get; set; }

    public bool IsSigned { get; set; }

    public bool Uncertain { get; set; }

    public string SignedAs { get; set; } = null!;

    public string CreditedAs { get; set; } = null!;

    public string CreditName { get; set; } = null!;

    public int CreatorId { get; set; }

    public int CreditTypeId { get; set; }

    public int StoryId { get; set; }

    public int? SignatureId { get; set; }

    public bool IsSourced { get; set; }

    public string SourcedBy { get; set; } = null!;

    public virtual GcdCreatorNameDetail Creator { get; set; } = null!;

    public virtual GcdCreditType CreditType { get; set; } = null!;

    public virtual GcdCreatorSignature? Signature { get; set; }

    public virtual GcdStory Story { get; set; } = null!;
}
