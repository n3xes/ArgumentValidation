using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest49.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentNullException712()
{
	this.RequireArgumentIsOutsideExclusiveTest49
		(0L, (string)null, 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException950()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException203()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "\0", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException895()
{
	this.RequireArgumentIsOutsideExclusiveTest49
		(0L, "\0", 0L, new long?(-9223372036854775807L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest49661()
{
	this.RequireArgumentIsOutsideExclusiveTest49
		(0L, "\0", long.MinValue, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException806()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "Ā", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException797()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "Ā", 0L, default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException752()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "\t", 0L, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest49ThrowsArgumentOutOfRangeException309()
{
	this.RequireArgumentIsOutsideExclusiveTest49(0L, "\t\0", 0L, new long?(1L));
}
	}
}
