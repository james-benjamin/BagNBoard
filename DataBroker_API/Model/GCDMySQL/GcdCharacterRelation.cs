using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCharacterRelation
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Notes { get; set; } = null!;

    public int FromCharacterId { get; set; }

    public int RelationTypeId { get; set; }

    public int ToCharacterId { get; set; }

    public virtual GcdCharacter FromCharacter { get; set; } = null!;

    public virtual GcdCharacterRelationType RelationType { get; set; } = null!;

    public virtual GcdCharacter ToCharacter { get; set; } = null!;
}
