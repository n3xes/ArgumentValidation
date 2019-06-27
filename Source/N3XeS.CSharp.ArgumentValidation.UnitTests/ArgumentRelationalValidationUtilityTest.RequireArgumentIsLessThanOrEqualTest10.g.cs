using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest10.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest10ThrowsArgumentNullException160()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(new decimal?(0e-4M), (string)null, default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest10ThrowsArgumentOutOfRangeException40()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(new decimal?(0e-4M), "", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest10611()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(new decimal?(0e-4M), "\0", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest10875()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(default(decimal?), "\0", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest10ThrowsArgumentOutOfRangeException723()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(new decimal?(decimal.MaxValue), "\0", 2034639888M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest10403()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(new decimal?(0e-4M), "䀀", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest10ThrowsArgumentOutOfRangeException187()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(new decimal?(0e-4M), "\t", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest10ThrowsArgumentOutOfRangeException838()
{
	this.RequireArgumentIsLessThanOrEqualTest10
		(new decimal?(0e-4M), "\t\t", default(decimal));
}
	}
}
