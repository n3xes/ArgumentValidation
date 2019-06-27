using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentNullException334()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 (string)null, default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException258()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException131()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\0", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest04414()
{
	this.RequireArgumentIsOutsideExclusiveTest04
		(default(DateTime?), "\0", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest04131()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62))), "\0", 
												 default(DateTime), 
												 new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException855()
{
	this.RequireArgumentIsOutsideExclusiveTest04
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException919()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "Ā", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException65()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\t", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException880()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 "\t\0", default(DateTime), default(DateTime));
}
	}
}
