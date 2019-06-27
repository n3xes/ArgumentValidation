using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest75.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest75ThrowsArgumentNullException961()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, (string)null, default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest75ThrowsArgumentOutOfRangeException84()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, "", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest75358()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, "\0", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest75ThrowsArgumentOutOfRangeException667()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, "\0", default(uint?), new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest75579()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, "\0", new uint?(0u), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest75ThrowsArgumentOutOfRangeException321()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(32u, "\0", new uint?(32u), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest75365()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, "Ā", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest75ThrowsArgumentOutOfRangeException863()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, "\t", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest75860()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(1u, "\t\0", default(uint?), default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest75ThrowsArgumentOutOfRangeException518()
{
	this.RequireArgumentIsOutsideExclusiveTest75
		(0u, "\t\t", new uint?(1u), new uint?(1u));
}
	}
}
