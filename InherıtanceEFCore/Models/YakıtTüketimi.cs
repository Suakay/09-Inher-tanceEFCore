﻿using System;
using System.Collections.Generic;

namespace InherıtanceEFCore.Models;

public partial class YakıtTüketimi
{
    public int YakıtId { get; set; }

    public decimal? Şehiriçi { get; set; }

    public decimal? ŞehirDışı { get; set; }

    public decimal? YakıtDepoHacmi { get; set; }

    public string? YakıtTipi { get; set; }
}
