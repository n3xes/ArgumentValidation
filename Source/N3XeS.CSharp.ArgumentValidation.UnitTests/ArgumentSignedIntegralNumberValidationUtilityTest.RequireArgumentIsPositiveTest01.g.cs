using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentSignedIntegralNumberValidationUtilityTest.RequireArgumentIsPositiveTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentNullException97()
{
	this.RequireArgumentIsPositiveTest01(new decimal?(0e-4M), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException696()
{
	this.RequireArgumentIsPositiveTest01(new decimal?(0e-4M), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
public void RequireArgumentIsPositiveTest0183()
{
	this.RequireArgumentIsPositiveTest01(new decimal?(0e-4M), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
public void RequireArgumentIsPositiveTest01912()
{
	this.RequireArgumentIsPositiveTest01(default(decimal?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException405()
{
	this.RequireArgumentIsPositiveTest01
		(new decimal?(-76819052936496198642298613574e-19M), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
public void RequireArgumentIsPositiveTest01965()
{
	this.RequireArgumentIsPositiveTest01(new decimal?(0e-4M), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException457()
{
	this.RequireArgumentIsPositiveTest01(new decimal?(0e-4M), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException134()
{
	this.RequireArgumentIsPositiveTest01(new decimal?(0e-4M), "\t\t");
}
	}
}
