using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentNullException204()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 (string)null, 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException494()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException240()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException503()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest01427()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)), "\0", 
		 new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException604()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "Ā", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException793()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException702()
{
	this.RequireArgumentIsBetweenExclusiveTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}
	}
}
