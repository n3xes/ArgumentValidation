using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest73.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTest73ThrowsArgumentNullException593()
{
	this.RequireArgumentIsBetweenTest73(1u, (string)null, 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest73ThrowsArgumentOutOfRangeException895()
{
	this.RequireArgumentIsBetweenTest73(1u, "", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest73642()
{
	this.RequireArgumentIsBetweenTest73(1u, "\0", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest73ThrowsArgumentOutOfRangeException681()
{
	this.RequireArgumentIsBetweenTest73(1u, "\0", 1u, new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest73ThrowsArgumentOutOfRangeException698()
{
	this.RequireArgumentIsBetweenTest73(2u, "\0", 3u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest73314()
{
	this.RequireArgumentIsBetweenTest73(1u, "Ā", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest73ThrowsArgumentOutOfRangeException138()
{
	this.RequireArgumentIsBetweenTest73(1u, "\t", 1u, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest73426()
{
	this.RequireArgumentIsBetweenTest73(1u, "\t\0", 1u, default(uint?));
}
	}
}
