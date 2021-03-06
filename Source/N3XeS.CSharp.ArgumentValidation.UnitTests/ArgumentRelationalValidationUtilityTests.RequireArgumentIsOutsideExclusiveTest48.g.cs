using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest48.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentNullException943()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, (string)null, 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException680()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException590()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException224()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\0", 0L, 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest48661()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\0", long.MinValue, 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException916()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "Ā", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException205()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\t", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest48ThrowsArgumentOutOfRangeException487()
{
	this.RequireArgumentIsOutsideExclusiveTest48(0L, "\t\0", 0L, 0L);
}
	}
}
