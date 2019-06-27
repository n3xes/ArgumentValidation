using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentNullException236()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), (string)null, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException78()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException164()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\0", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest15120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\0", default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException383()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest15469()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(default(double?), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException16401()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\t", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest15ThrowsArgumentOutOfRangeException118()
{
	this.RequireArgumentIsGreaterThanOrEqualTest15
		(new double?(0), "\t\t", new double?(1));
}
	}
}
