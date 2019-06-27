using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentNullException454()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(default(DateTime), (string)null, new DateTime?
											  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
										  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException171()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(default(DateTime), "", new DateTime?
									(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException480()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(default(DateTime), "\0", new DateTime?
									  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest02131()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), "\0", 
		 new DateTime?
			 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
		 new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException473()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(new DateTime(4611686018427387903L & 4611686018427387904L, 
					  (DateTimeKind)(4611686018427387904uL >> 62)), "\0", 
		 new DateTime?(default(DateTime)), 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException632()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(default(DateTime), "Ā", new DateTime?
									 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest0244()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), "\0", 
		 default(DateTime?), 
		 new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException186()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(default(DateTime), "\t", new DateTime?
									  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException609()
{
	this.RequireArgumentIsOutsideExclusiveTest02
		(default(DateTime), "\t\0", new DateTime?
										(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
									default(DateTime));
}
	}
}
