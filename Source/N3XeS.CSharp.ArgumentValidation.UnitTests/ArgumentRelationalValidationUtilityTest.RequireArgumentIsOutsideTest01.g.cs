using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest01ThrowsArgumentNullException391()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 (string)null, 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest01ThrowsArgumentOutOfRangeException770()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest01427()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest01ThrowsArgumentOutOfRangeException745()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest01131()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest01ThrowsArgumentOutOfRangeException761()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 2305843009213693952L, 
					  (DateTimeKind)(2305843009213693952uL >> 62)), new DateTime?
																		  (new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62))));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest01696()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "Ā", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest01ThrowsArgumentOutOfRangeException660()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest0195()
{
	this.RequireArgumentIsOutsideTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}
	}
}
