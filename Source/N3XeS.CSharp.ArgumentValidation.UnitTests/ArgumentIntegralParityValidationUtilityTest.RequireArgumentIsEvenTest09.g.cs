using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest09.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentIntegralParityValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsEvenTest09ThrowsArgumentNullException454()
{
	this.RequireArgumentIsEvenTest09(new sbyte?((sbyte)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest09912()
{
	this.RequireArgumentIsEvenTest09(default(sbyte?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest09ThrowsArgumentOutOfRangeException628()
{
	this.RequireArgumentIsEvenTest09(default(sbyte?), "\n");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest09632()
{
	this.RequireArgumentIsEvenTest09(new sbyte?((sbyte)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest09ThrowsArgumentOutOfRangeException202()
{
	this.RequireArgumentIsEvenTest09(new sbyte?((sbyte)(-1)), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest09894()
{
	this.RequireArgumentIsEvenTest09(default(sbyte?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest09ThrowsArgumentOutOfRangeException423()
{
	this.RequireArgumentIsEvenTest09(default(sbyte?), "\n\n");
}
	}
}
