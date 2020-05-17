using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentNullException9()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(default(DateTime), (string)null, new DateTime?
											  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
										  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException630()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(default(DateTime), "", new DateTime?
									(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException119()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(default(DateTime), "\0", new DateTime?
									  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest02131()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), "\0", 
		 new DateTime?
			 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
		 new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException149()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(new DateTime(4611686018427387903L & 4611686018427387904L, 
					  (DateTimeKind)(4611686018427387904uL >> 62)), "\0", 
		 new DateTime?(default(DateTime)), 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException761()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(default(DateTime), "Ā", new DateTime?
									 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest0244()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), "\0", 
		 default(DateTime?), 
		 new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException481()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(default(DateTime), "\t", new DateTime?
									  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException243()
{
	this.RequireArgumentIsBetweenExclusiveTest02
		(default(DateTime), "\t\0", new DateTime?
										(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
									default(DateTime));
}
	}
}
