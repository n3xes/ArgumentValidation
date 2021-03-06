using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest02ThrowsArgumentNullException601()
{
	this.RequireArgumentIsBetweenTest02
		(default(DateTime), (string)null, new DateTime?
											  (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
										  default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException347()
{
	this.RequireArgumentIsBetweenTest02(default(DateTime), "", new DateTime?
																   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
															   default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException232()
{
	this.RequireArgumentIsBetweenTest02(default(DateTime), "\0", new DateTime?
																	 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest0244()
{
	this.RequireArgumentIsBetweenTest02
		(default(DateTime), "\0", default(DateTime?), default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException53()
{
	this.RequireArgumentIsBetweenTest02(default(DateTime), "Ā", new DateTime?
																	(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException307()
{
	this.RequireArgumentIsBetweenTest02
		(new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)), "Ā", 
		 new DateTime?
			 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
		 new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException285()
{
	this.RequireArgumentIsBetweenTest02(default(DateTime), "\t", new DateTime?
																	 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																 default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException915()
{
	this.RequireArgumentIsBetweenTest02(default(DateTime), "\t\0", new DateTime?
																	   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
																   default(DateTime));
}
	}
}
