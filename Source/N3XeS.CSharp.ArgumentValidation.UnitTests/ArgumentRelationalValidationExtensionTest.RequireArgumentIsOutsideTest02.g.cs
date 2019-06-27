using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest02ThrowsArgumentNullException758()
{
	this.RequireArgumentIsOutsideTest02
		(default(DateTime), (string)null, new DateTime?
											  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
										  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException941()
{
	this.RequireArgumentIsOutsideTest02(default(DateTime), "", new DateTime?
																   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
															   default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest02131()
{
	this.RequireArgumentIsOutsideTest02(default(DateTime), "\0", new DateTime?
																	 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException23()
{
	this.RequireArgumentIsOutsideTest02
		(new DateTime(4611686018427387903L & 257L, (DateTimeKind)(257uL >> 62)), 
		 "\0", new DateTime?
																					   (new DateTime(4611686018427387903L & 256L, (DateTimeKind)(256uL >> 62))
																					   ), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException300()
{
	this.RequireArgumentIsOutsideTest02
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime?(new DateTime(4611686018427387903L & 2305843009213693952L, 
									(DateTimeKind)(2305843009213693952uL >> 62))), 
		 new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest02834()
{
	this.RequireArgumentIsOutsideTest02(default(DateTime), "Ā", new DateTime?
																	(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest02991()
{
	this.RequireArgumentIsOutsideTest02
		(default(DateTime), "Ā", default(DateTime?), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException267()
{
	this.RequireArgumentIsOutsideTest02(default(DateTime), "\t", new DateTime?
																	 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest02225()
{
	this.RequireArgumentIsOutsideTest02(default(DateTime), "\t\0", new DateTime?
																	   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																   default(DateTime));
}
	}
}
