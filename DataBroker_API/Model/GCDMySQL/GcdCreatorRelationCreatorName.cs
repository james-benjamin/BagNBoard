using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdCreatorRelationCreatorName
{
    public int Id { get; set; }

    public int CreatorrelationId { get; set; }

    public int CreatornamedetailId { get; set; }

    public virtual GcdCreatorNameDetail Creatornamedetail { get; set; } = null!;

    public virtual GcdCreatorRelation Creatorrelation { get; set; } = null!;
}
