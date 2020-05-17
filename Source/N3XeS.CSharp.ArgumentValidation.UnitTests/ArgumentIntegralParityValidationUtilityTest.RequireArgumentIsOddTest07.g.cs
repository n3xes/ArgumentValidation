using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOddTest07ThrowsArgumentNullException389()
{
	this.RequireArgumentIsOddTest07(new long?(1L), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsOddTest07912()
{
	this.RequireArgumentIsOddTest07(default(long?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest07ThrowsArgumentOutOfRangeException759()
{
	this.RequireArgumentIsOddTest07(default(long?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest07ThrowsArgumentOutOfRangeException633()
{
	this.RequireArgumentIsOddTest07(new long?(0L), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsOddTest07894()
{
	this.RequireArgumentIsOddTest07(default(long?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest07ThrowsArgumentOutOfRangeException342()
{
	this.RequireArgumentIsOddTest07(default(long?), "\t\t");
}
	}
}
