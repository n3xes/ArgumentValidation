using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentNullException650()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 (string)null, default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException808()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest03910()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException518()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 default(DateTime?), new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest03427()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\0", 
		 new DateTime?(default(DateTime)), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException812()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 4611686018427387904L, 
					  (DateTimeKind)(4611686018427387904uL >> 62)), "\0", 
		 new DateTime?(default(DateTime)), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest03443()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "Ā", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException893()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest03778()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), "\t\0", 
		 default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException933()
{
	this.RequireArgumentIsBetweenExclusiveTest03
		(new DateTime(4611686018427387903L & 4611686018427387904L, 
					  (DateTimeKind)(4611686018427387904uL >> 62)), "\t\t", 
		 new DateTime?(default(DateTime)), new DateTime?
											   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))));
}
	}
}
