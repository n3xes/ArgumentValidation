using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentNullException708()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, (string)null, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException696()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest17563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "\0", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest17120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17((float)0, "\0", default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException476()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)(-2), "\0", new float?((float)(-1)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest1734()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "Ā", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException628()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "\t", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException549()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "\t\t", new float?((float)0));
}
	}
}
