using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentNullException13()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), (string)null, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException78()
{
	this.RequireArgumentIsLessThanOrEqualTest15(new double?(0), "", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest15511()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\0", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest1529()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\0", default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException532()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(-1), "\0", new double?(-2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest15394()
{
	this.RequireArgumentIsLessThanOrEqualTest15(new double?(0), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest15639()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(default(double?), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException844()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\t", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException817()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\t\t", new double?(1));
}
	}
}
