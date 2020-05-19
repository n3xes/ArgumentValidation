using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest73.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTest73ThrowsArgumentNullException314()
{
	this.RequireArgumentIsBetweenExclusiveTest73
		(1u, (string)null, 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest73ThrowsArgumentOutOfRangeException577()
{
	this.RequireArgumentIsBetweenExclusiveTest73(1u, "", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest73ThrowsArgumentOutOfRangeException899()
{
	this.RequireArgumentIsBetweenExclusiveTest73(1u, "\0", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest73ThrowsArgumentOutOfRangeException378()
{
	this.RequireArgumentIsBetweenExclusiveTest73(1u, "\0", 1u, new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest73968()
{
	this.RequireArgumentIsBetweenExclusiveTest73(3u, "\0", 2u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest73ThrowsArgumentOutOfRangeException335()
{
	this.RequireArgumentIsBetweenExclusiveTest73(1u, "Ā", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest73ThrowsArgumentOutOfRangeException404()
{
	this.RequireArgumentIsBetweenExclusiveTest73(1u, "\t", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest73ThrowsArgumentOutOfRangeException456()
{
	this.RequireArgumentIsBetweenExclusiveTest73(1u, "\t\0", 1u, default(uint?));
}
	}
}
