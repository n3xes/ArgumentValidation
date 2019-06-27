using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest03ThrowsArgumentNullException749()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 (string)null, default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest03ThrowsArgumentOutOfRangeException619()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest03910()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest03ThrowsArgumentOutOfRangeException128()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime?(default(DateTime)), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest0344()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 default(DateTime?), new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest03ThrowsArgumentOutOfRangeException230()
{
	this.RequireArgumentIsOutsideTest03
		(default(DateTime), "\0", default(DateTime?), new DateTime?
														  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest03443()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "Ā", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest03ThrowsArgumentOutOfRangeException849()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest03778()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t\0", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest03ThrowsArgumentOutOfRangeException700()
{
	this.RequireArgumentIsOutsideTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t\t", 
		 new DateTime?(new DateTime(4611686018427387903L & 2305843009213693952L, 
									(DateTimeKind)(2305843009213693952uL >> 62))), new DateTime?
																						 (new DateTime(4611686018427387903L & 16L, (DateTimeKind)(16uL >> 62))));
}
	}
}
