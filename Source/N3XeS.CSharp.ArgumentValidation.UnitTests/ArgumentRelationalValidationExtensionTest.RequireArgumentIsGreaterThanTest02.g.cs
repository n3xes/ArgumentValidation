using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest02ThrowsArgumentNullException780()
{
	this.RequireArgumentIsGreaterThanTest02(new DateTime?
												(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
											(string)null, default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest02ThrowsArgumentOutOfRangeException499()
{
	this.RequireArgumentIsGreaterThanTest02(new DateTime?
												(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
											"", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest02664()
{
	this.RequireArgumentIsGreaterThanTest02(new DateTime?
												(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
											"\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest02784()
{
	this.RequireArgumentIsGreaterThanTest02
		(default(DateTime?), "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest02ThrowsArgumentOutOfRangeException822()
{
	this.RequireArgumentIsGreaterThanTest02(new DateTime?(default(DateTime)), 
											"\0", new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest02116()
{
	this.RequireArgumentIsGreaterThanTest02(new DateTime?
												(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
											"Ā", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest02ThrowsArgumentOutOfRangeException142()
{
	this.RequireArgumentIsGreaterThanTest02(new DateTime?
												(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
											"\t", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest02ThrowsArgumentOutOfRangeException56()
{
	this.RequireArgumentIsGreaterThanTest02(new DateTime?
												(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
											"\t\t", default(DateTime));
}
	}
}
