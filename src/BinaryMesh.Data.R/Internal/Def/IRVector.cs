﻿// -----------------------------------------------------------------------
// <copyright file="IRVector.cs" company="Binary Mesh">
// Copyright © Binary Mesh. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryMesh.Data.R.Internal
{
    public interface IRVector : IRObject, IEnumerable
    {
        long Count { get; }

        object this[long index] { get; set; }
    }
}
