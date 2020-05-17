using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest04ThrowsArgumentNullException720()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
										(string)null, default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException123()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "", 
										default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException524()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\0", 
										default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest04414()
{
	this.RequireArgumentIsBetweenTest04
		(default(DateTime?), "\0", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest04561()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\0", 
										default(DateTime), 
										new DateTime(4611686018427387903L & 2305843009213693952L, 
													 (DateTimeKind)(2305843009213693952uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException457()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\0", 
										new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), 
										new DateTime(4611686018427387903L & 2305843009213693952L, 
													 (DateTimeKind)(2305843009213693952uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException241()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "Ā", 
										default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException748()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\t", 
										default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException137()
{
	this.RequireArgumentIsBetweenTest04(new DateTime?
											(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
										"\t\0", default(DateTime), default(DateTime));
}
	}
}
