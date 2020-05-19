using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsPositiveTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedFloatingPointNumberValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsPositiveTest03ThrowsArgumentNullException652()
{
	this.RequireArgumentIsPositiveTest03(new float?((float)0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest03ThrowsArgumentOutOfRangeException583()
{
	this.RequireArgumentIsPositiveTest03(new float?((float)0), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
public void RequireArgumentIsPositiveTest03705()
{
	this.RequireArgumentIsPositiveTest03(new float?((float)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
public void RequireArgumentIsPositiveTest03912()
{
	this.RequireArgumentIsPositiveTest03(default(float?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest03ThrowsArgumentOutOfRangeException123()
{
	this.RequireArgumentIsPositiveTest03(new float?((float)(-1)), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
public void RequireArgumentIsPositiveTest03253()
{
	this.RequireArgumentIsPositiveTest03(new float?((float)0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest03ThrowsArgumentOutOfRangeException609()
{
	this.RequireArgumentIsPositiveTest03(new float?((float)0), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedFloatingPointNumberValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsPositiveTest03ThrowsArgumentOutOfRangeException388()
{
	this.RequireArgumentIsPositiveTest03(new float?((float)0), "\t\t");
}
	}
}
