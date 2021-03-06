using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsLessThanOrEqualTest02ThrowsArgumentNullException334()
{
	this.RequireArgumentIsLessThanOrEqualTest02(new DateTime?
													(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												(string)null, default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest02ThrowsArgumentOutOfRangeException73()
{
	this.RequireArgumentIsLessThanOrEqualTest02(new DateTime?
													(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												"", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest02ThrowsArgumentOutOfRangeException378()
{
	this.RequireArgumentIsLessThanOrEqualTest02(new DateTime?
													(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												"\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest02439()
{
	this.RequireArgumentIsLessThanOrEqualTest02
		(default(DateTime?), "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest02ThrowsArgumentOutOfRangeException175()
{
	this.RequireArgumentIsLessThanOrEqualTest02(new DateTime?
													(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												"Ā", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest02ThrowsArgumentOutOfRangeException221()
{
	this.RequireArgumentIsLessThanOrEqualTest02(new DateTime?
													(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												"\t", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest02ThrowsArgumentOutOfRangeException744()
{
	this.RequireArgumentIsLessThanOrEqualTest02(new DateTime?
													(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												"\t\t", default(DateTime));
}
	}
}
