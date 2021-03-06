using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentNullException54()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 (string)null, default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException356()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException695()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\0", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest04414()
{
	this.RequireArgumentIsOutsideExclusiveTest04
		(default(DateTime?), "\0", default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest04131()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62))), "\0", 
												 default(DateTime), 
												 new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException631()
{
	this.RequireArgumentIsOutsideExclusiveTest04
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException122()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "Ā", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException417()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), "\t", 
												 default(DateTime), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException381()
{
	this.RequireArgumentIsOutsideExclusiveTest04(new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 "\t\0", default(DateTime), default(DateTime));
}
	}
}
