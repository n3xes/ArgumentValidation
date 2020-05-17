using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest01ThrowsArgumentNullException235()
{
	this.RequireArgumentIsLessThanTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 (string)null, default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest01ThrowsArgumentOutOfRangeException273()
{
	this.RequireArgumentIsLessThanTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest01905()
{
	this.RequireArgumentIsLessThanTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest01ThrowsArgumentOutOfRangeException560()
{
	this.RequireArgumentIsLessThanTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "\0", new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest01171()
{
	this.RequireArgumentIsLessThanTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "Ā", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest01ThrowsArgumentOutOfRangeException292()
{
	this.RequireArgumentIsLessThanTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "\t", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest01ThrowsArgumentOutOfRangeException310()
{
	this.RequireArgumentIsLessThanTest01
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "\t\t", default(DateTime?));
}
	}
}
