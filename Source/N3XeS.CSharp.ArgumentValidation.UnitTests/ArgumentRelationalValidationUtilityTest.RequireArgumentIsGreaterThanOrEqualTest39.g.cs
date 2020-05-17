using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest39.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest39ThrowsArgumentNullException171()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(default(uint?), (string)null, default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest39ThrowsArgumentOutOfRangeException437()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(default(uint?), "", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest39468()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(default(uint?), "\0", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest39120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(new uint?(0u), "\0", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest39563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(new uint?(0u), "\0", new uint?(0u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest39ThrowsArgumentOutOfRangeException135()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(new uint?(0u), "\0", new uint?(1u));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest39ThrowsArgumentOutOfRangeException811()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(default(uint?), "\t", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest39824()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(default(uint?), "Ā", default(uint?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest39ThrowsArgumentOutOfRangeException63()
{
	this.RequireArgumentIsGreaterThanOrEqualTest39
		(default(uint?), "\t\t", default(uint?));
}
	}
}
