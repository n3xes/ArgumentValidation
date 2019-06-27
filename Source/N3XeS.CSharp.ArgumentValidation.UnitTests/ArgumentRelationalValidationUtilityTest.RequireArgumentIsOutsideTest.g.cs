using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTestThrowsArgumentNullException915()
{
	this.RequireArgumentIsOutsideTest
		(default(DateTime), (string)null, default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTestThrowsArgumentOutOfRangeException768()
{
	this.RequireArgumentIsOutsideTest
		(default(DateTime), "", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest131()
{
	this.RequireArgumentIsOutsideTest
		(default(DateTime), "\0", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTestThrowsArgumentOutOfRangeException758()
{
	this.RequireArgumentIsOutsideTest
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTestThrowsArgumentOutOfRangeException525()
{
	this.RequireArgumentIsOutsideTest
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 2305843009213693952L, 
					  (DateTimeKind)(2305843009213693952uL >> 62)), 
		 new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest834()
{
	this.RequireArgumentIsOutsideTest
		(default(DateTime), "Ā", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTestThrowsArgumentOutOfRangeException769()
{
	this.RequireArgumentIsOutsideTest
		(default(DateTime), "\t", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest225()
{
	this.RequireArgumentIsOutsideTest
		(default(DateTime), "\t\0", default(DateTime), default(DateTime));
}
	}
}
