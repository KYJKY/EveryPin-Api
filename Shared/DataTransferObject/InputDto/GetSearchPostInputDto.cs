﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject.InputDto;

public class GetSearchPostInputDto
{
    public double x { get; set; }
    public double y { get; set; }
    public double range { get; set; }
}
