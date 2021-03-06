using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest80.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest80ThrowsArgumentNullException331()
{
	this.RequireArgumentIsBetweenExclusiveTest80(0uL, (string)null, 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest80ThrowsArgumentOutOfRangeException225()
{
	this.RequireArgumentIsBetweenExclusiveTest80(0uL, "", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest80ThrowsArgumentOutOfRangeException733()
{
	this.RequireArgumentIsBetweenExclusiveTest80(0uL, "\0", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest80ThrowsArgumentOutOfRangeException635()
{
	this.RequireArgumentIsBetweenExclusiveTest80(0uL, "\0", 0uL, 1uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest804()
{
	this.RequireArgumentIsBetweenExclusiveTest80(2uL, "\0", 0uL, 3uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest80ThrowsArgumentOutOfRangeException898()
{
	this.RequireArgumentIsBetweenExclusiveTest80(0uL, "Ā", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest80ThrowsArgumentOutOfRangeException557()
{
	this.RequireArgumentIsBetweenExclusiveTest80(0uL, "\t", 0uL, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest80ThrowsArgumentOutOfRangeException614()
{
	this.RequireArgumentIsBetweenExclusiveTest80(0uL, "\t\0", 0uL, 0uL);
}
	}
}
