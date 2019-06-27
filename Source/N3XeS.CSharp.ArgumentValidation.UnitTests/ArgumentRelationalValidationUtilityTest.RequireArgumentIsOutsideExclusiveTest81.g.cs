using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest81.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentNullException2()
{
	this.RequireArgumentIsOutsideExclusiveTest81
		(0uL, (string)null, 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentOutOfRangeException996()
{
	this.RequireArgumentIsOutsideExclusiveTest81(0uL, "", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentOutOfRangeException53()
{
	this.RequireArgumentIsOutsideExclusiveTest81(0uL, "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentOutOfRangeException942()
{
	this.RequireArgumentIsOutsideExclusiveTest81
		(9223372036854775808uL, "\0", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest814()
{
	this.RequireArgumentIsOutsideExclusiveTest81(2uL, "\0", 0uL, new ulong?(3uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentOutOfRangeException278()
{
	this.RequireArgumentIsOutsideExclusiveTest81(0uL, "Ā", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentOutOfRangeException713()
{
	this.RequireArgumentIsOutsideExclusiveTest81(0uL, "Ā", 0uL, default(ulong?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentOutOfRangeException517()
{
	this.RequireArgumentIsOutsideExclusiveTest81(0uL, "\t", 0uL, new ulong?(1uL));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest81ThrowsArgumentOutOfRangeException754()
{
	this.RequireArgumentIsOutsideExclusiveTest81(0uL, "\t\0", 0uL, new ulong?(1uL));
}
	}
}
