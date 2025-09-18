using System;
using System.Collections.Generic;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdBrandEmblemGroup
{
    public int Id { get; set; }

    public int BrandId { get; set; }

    public int BrandgroupId { get; set; }

    public virtual GcdBrand Brand { get; set; } = null!;

    public virtual GcdBrandGroup Brandgroup { get; set; } = null!;
}
