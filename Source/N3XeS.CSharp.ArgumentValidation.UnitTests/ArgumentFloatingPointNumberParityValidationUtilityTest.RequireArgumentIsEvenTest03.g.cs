using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentFloatingPointNumberParityValidationUtilityTest.RequireArgumentIsEvenTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentFloatingPointNumberParityValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsEvenTest03ThrowsArgumentNullException577()
{
	this.RequireArgumentIsEvenTest03(new float?((float)0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest03705()
{
	this.RequireArgumentIsEvenTest03(new float?((float)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest03912()
{
	this.RequireArgumentIsEvenTest03(default(float?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest03ThrowsArgumentOutOfRangeException997()
{
	this.RequireArgumentIsEvenTest03(new float?((float)3), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest03ThrowsArgumentOutOfRangeException999()
{
	this.RequireArgumentIsEvenTest03(default(float?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest03894()
{
	this.RequireArgumentIsEvenTest03(default(float?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest03ThrowsArgumentOutOfRangeException233()
{
	this.RequireArgumentIsEvenTest03(default(float?), "\t\t");
}
	}
}
