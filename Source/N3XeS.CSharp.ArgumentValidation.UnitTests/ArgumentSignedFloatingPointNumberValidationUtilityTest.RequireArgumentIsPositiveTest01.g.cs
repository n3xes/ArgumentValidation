using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentSignedFloatingPointNumberValidationUtilityTest.RequireArgumentIsPositiveTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedFloatingPointNumberValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentNullException999()
{
	this.RequireArgumentIsPositiveTest01(new double?(0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException68()
{
	this.RequireArgumentIsPositiveTest01(new double?(0), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
public void RequireArgumentIsPositiveTest01705()
{
	this.RequireArgumentIsPositiveTest01(new double?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
public void RequireArgumentIsPositiveTest01912()
{
	this.RequireArgumentIsPositiveTest01(default(double?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException454()
{
	this.RequireArgumentIsPositiveTest01(new double?(-1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
public void RequireArgumentIsPositiveTest01253()
{
	this.RequireArgumentIsPositiveTest01(new double?(0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException351()
{
	this.RequireArgumentIsPositiveTest01(new double?(0), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest01ThrowsArgumentOutOfRangeException952()
{
	this.RequireArgumentIsPositiveTest01(new double?(0), "\t\t");
}
	}
}
