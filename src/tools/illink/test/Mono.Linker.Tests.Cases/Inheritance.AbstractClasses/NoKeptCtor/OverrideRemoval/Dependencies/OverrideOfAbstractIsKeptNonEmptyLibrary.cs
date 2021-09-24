﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono.Linker.Tests.Cases.Inheritance.AbstractClasses.NoKeptCtor.OverrideRemoval.Dependencies
{
	public class OverrideOfAbstractIsKeptNonEmpty_UnusedType
	{
	}

	public abstract class OverrideOfAbstractIsKeptNonEmpty_BaseType
	{
		public abstract void Method ();
	}
}
