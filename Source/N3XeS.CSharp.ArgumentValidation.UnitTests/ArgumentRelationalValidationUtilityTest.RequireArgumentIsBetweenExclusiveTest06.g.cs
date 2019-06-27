using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest06.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentNullException443()
{
	this.RequireArgumentIsBetweenExclusiveTest06
		(new DateTime?(new DateTime(4611686018427387903L & 281474976710656L, 
									(DateTimeKind)(281474976710656uL >> 62))), (string)null, new DateTime?
																								   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																							   default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException568()
{
	this.RequireArgumentIsBetweenExclusiveTest06
		(new DateTime?(new DateTime(4611686018427387903L & 140737488355328L, 
									(DateTimeKind)(140737488355328uL >> 62))), "", new DateTime?
																						 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																					 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException46()
{
	this.RequireArgumentIsBetweenExclusiveTest06(new DateTime?(new DateTime
																   (4611686018427387903L & 2048L, (DateTimeKind)(2048uL >> 62))), "\0", 
												 new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest06414()
{
	this.RequireArgumentIsBetweenExclusiveTest06
		(default(DateTime?), "\0", new DateTime?
									   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
								   default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException972()
{
	this.RequireArgumentIsBetweenExclusiveTest06
		(new DateTime?(default(DateTime)), "\0", new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException824()
{
	this.RequireArgumentIsBetweenExclusiveTest06(new DateTime?
													 (new DateTime(4611686018427387903L & 128L, (DateTimeKind)(128uL >> 62))
													 ), "Ѐ", new DateTime?
																																	   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																																   default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException562()
{
	this.RequireArgumentIsBetweenExclusiveTest06(new DateTime?
													 (new DateTime(4611686018427387903L & 4L, (DateTimeKind)(4uL >> 62))), "\t", 
												 new DateTime?
													 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException826()
{
	this.RequireArgumentIsBetweenExclusiveTest06(new DateTime?
													 (new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62))), 
												 "\t\0", new DateTime?
																																 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																															 default(DateTime));
}
	}
}
