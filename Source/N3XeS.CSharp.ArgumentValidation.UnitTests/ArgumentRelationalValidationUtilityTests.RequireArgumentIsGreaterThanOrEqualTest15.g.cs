using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanOrEqualTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentNullException695()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), (string)null, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException800()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException962()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\0", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest15120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\0", default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException746()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest15469()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(default(double?), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException811()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\t", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException693()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\t\t", new double?(1));
}
	}
}
