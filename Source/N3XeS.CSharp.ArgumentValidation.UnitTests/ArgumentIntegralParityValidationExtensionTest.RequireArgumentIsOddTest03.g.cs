using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentIntegralParityValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOddTest03ThrowsArgumentNullException646()
{
	this.RequireArgumentIsOddTest03(new decimal?(0e-4M), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException686()
{
	this.RequireArgumentIsOddTest03(new decimal?(0e-4M), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException732()
{
	this.RequireArgumentIsOddTest03(new decimal?(0e-4M), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsOddTest0334()
{
	this.RequireArgumentIsOddTest03
		(new decimal?(-76819052936496198642298613574e-19M), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException270()
{
	this.RequireArgumentIsOddTest03(new decimal?(0e-4M), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsOddTest03894()
{
	this.RequireArgumentIsOddTest03(default(decimal?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException387()
{
	this.RequireArgumentIsOddTest03(new decimal?(0e-4M), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException355()
{
	this.RequireArgumentIsOddTest03(new decimal?(0e-4M), "\t\t");
}
	}
}
