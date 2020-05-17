using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentNullException542()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02(new DateTime?
													   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												   (string)null, default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException883()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02(new DateTime?
													   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												   "", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest02664()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02(new DateTime?
													   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												   "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest02784()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02
		(default(DateTime?), "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException579()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02
		(new DateTime?(default(DateTime)), 
		 "\0", new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest02116()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02(new DateTime?
													   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												   "Ā", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException638()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02(new DateTime?
													   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												   "\t", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException310()
{
	this.RequireArgumentIsGreaterThanOrEqualTest02(new DateTime?
													   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												   "\t\t", default(DateTime));
}
	}
}
