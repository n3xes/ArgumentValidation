using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationUtilityTests.RequireArgumentIsNegativeTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsNegativeTest01ThrowsArgumentNullException775()
{
	this.RequireArgumentIsNegativeTest01(new decimal?(0e-4M), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest01ThrowsArgumentOutOfRangeException979()
{
	this.RequireArgumentIsNegativeTest01(new decimal?(0e-4M), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsNegativeTest0183()
{
	this.RequireArgumentIsNegativeTest01(new decimal?(0e-4M), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsNegativeTest01912()
{
	this.RequireArgumentIsNegativeTest01(default(decimal?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest01ThrowsArgumentOutOfRangeException229()
{
	this.RequireArgumentIsNegativeTest01(new decimal?(1M), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
public void RequireArgumentIsNegativeTest01965()
{
	this.RequireArgumentIsNegativeTest01(new decimal?(0e-4M), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest01ThrowsArgumentOutOfRangeException235()
{
	this.RequireArgumentIsNegativeTest01(new decimal?(0e-4M), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest01ThrowsArgumentOutOfRangeException476()
{
	this.RequireArgumentIsNegativeTest01(new decimal?(0e-4M), "\t\t");
}
	}
}
