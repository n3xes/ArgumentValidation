using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest27.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest27ThrowsArgumentNullException540()
{
	this.RequireArgumentIsOutsideTest27
		(0, (string)null, new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest27ThrowsArgumentOutOfRangeException862()
{
	this.RequireArgumentIsOutsideTest27(0, "", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest27ThrowsArgumentOutOfRangeException416()
{
	this.RequireArgumentIsOutsideTest27(0, "\0", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest27158()
{
	this.RequireArgumentIsOutsideTest27(0, "\0", new double?(0), default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest27ThrowsArgumentOutOfRangeException830()
{
	this.RequireArgumentIsOutsideTest27(0, "Ā", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest27ThrowsArgumentOutOfRangeException861()
{
	this.RequireArgumentIsOutsideTest27(0, "Ā", new double?(-1), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest27ThrowsArgumentOutOfRangeException237()
{
	this.RequireArgumentIsOutsideTest27(0, "\t", new double?(0), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest27ThrowsArgumentOutOfRangeException617()
{
	this.RequireArgumentIsOutsideTest27(0, "Ā", default(double?), new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest27ThrowsArgumentOutOfRangeException745()
{
	this.RequireArgumentIsOutsideTest27(0, "\t\0", new double?(0), new double?(1));
}
	}
}
