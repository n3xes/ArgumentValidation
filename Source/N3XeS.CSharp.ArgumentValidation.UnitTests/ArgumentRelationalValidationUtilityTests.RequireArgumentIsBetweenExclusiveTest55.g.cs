using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest55.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest55ThrowsArgumentNullException261()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), (string)null, new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest55ThrowsArgumentOutOfRangeException180()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), "", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest55ThrowsArgumentOutOfRangeException715()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), "\0", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest55ThrowsArgumentOutOfRangeException193()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), "\0", new long?(1L), default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest55615()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(2L), "\0", new long?(1L), new long?(3L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest55358()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), "\0", default(long?), default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest55ThrowsArgumentOutOfRangeException929()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), "\t", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest5544()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(default(long?), "\0", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest55ThrowsArgumentOutOfRangeException775()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), "Ā", new long?(1L), new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest55ThrowsArgumentOutOfRangeException714()
{
	this.RequireArgumentIsBetweenExclusiveTest55
		(new long?(1L), "\t\0", new long?(1L), new long?(1L));
}
	}
}
