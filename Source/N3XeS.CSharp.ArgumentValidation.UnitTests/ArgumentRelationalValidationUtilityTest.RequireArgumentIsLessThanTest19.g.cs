using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanTest19.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest19ThrowsArgumentNullException395()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)0), (string)null, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest19ThrowsArgumentOutOfRangeException248()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)0), "", new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest19511()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)0), "\0", new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest1929()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)0), "\0", default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest19ThrowsArgumentOutOfRangeException629()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)(-1)), "\0", new float?((float)(-7720)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest19394()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)0), "Ā", new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest19639()
{
	this.RequireArgumentIsLessThanTest19(default(float?), "Ā", new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest19ThrowsArgumentOutOfRangeException814()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)0), "\t", new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest19ThrowsArgumentOutOfRangeException946()
{
	this.RequireArgumentIsLessThanTest19
		(new float?((float)0), "\t\t", new float?((float)1));
}
	}
}
