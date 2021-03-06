using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest76.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentNullException750()
{
	this.RequireArgumentIsOutsideExclusiveTest76
		(new uint?(64u), (string)null, 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException531()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException236()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest76760()
{
	this.RequireArgumentIsOutsideExclusiveTest76(default(uint?), "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest76824()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(16u), "\0", 0u, 17u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException411()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(0u), "\0", 1u, 1u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException4()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "Ā", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException457()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "\t", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest76ThrowsArgumentOutOfRangeException341()
{
	this.RequireArgumentIsOutsideExclusiveTest76(new uint?(1u), "\t\0", 0u, 0u);
}
	}
}
