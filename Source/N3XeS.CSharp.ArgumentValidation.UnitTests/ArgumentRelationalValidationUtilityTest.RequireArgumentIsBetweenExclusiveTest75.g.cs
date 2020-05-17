using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest75.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest75ThrowsArgumentNullException737()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, (string)null, default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest75ThrowsArgumentOutOfRangeException342()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, "", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest75358()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, "\0", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest75ThrowsArgumentOutOfRangeException510()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, "\0", default(uint?), new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest75579()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, "\0", new uint?(0u), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest75ThrowsArgumentOutOfRangeException319()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(32u, "\0", new uint?(32u), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest75365()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, "Ā", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest75ThrowsArgumentOutOfRangeException919()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, "\t", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest75860()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(1u, "\t\0", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest75ThrowsArgumentOutOfRangeException600()
{
	this.RequireArgumentIsBetweenExclusiveTest75
		(0u, "\t\t", new uint?(1u), new uint?(1u));
}
	}
}
