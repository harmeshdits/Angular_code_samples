﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
////Optional
//[assembly: CollectionBehavior(DisableTestParallelization = true)]
//Optional
[assembly: TestCaseOrderer("Xunit.Extensions.Ordering.TestCaseOrderer", "Xunit.Extensions.Ordering")]
//Optional
[assembly: TestCollectionOrderer("Xunit.Extensions.Ordering.CollectionOrderer", "Xunit.Extensions.Ordering")]

namespace TT.Camp.Tests
{
    class AssemblyInfo
    {
    }
}
