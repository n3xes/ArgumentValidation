using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentNullException269()
{
	this.RequireArgumentIsBetweenExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 (string)null, default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException778()
{
	this.RequireArgumentIsBetweenExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException267()
{
	this.RequireArgumentIsBetweenExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\0", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest04414()
{
	this.RequireArgumentIsBetweenExclusiveTest04
		(default(DateTime?), "\0", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest04131()
{
	this.RequireArgumentIsBetweenExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62))), "\0", 
												 default(DateTime), 
												 new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException35()
{
	this.RequireArgumentIsBetweenExclusiveTest04
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException240()
{
	this.RequireArgumentIsBetweenExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "Ā", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException15()
{
	this.RequireArgumentIsBetweenExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\t", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException484()
{
	this.RequireArgumentIsBetweenExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 "\t\0", default(DateTime), default(DateTime));
}
	}
}
