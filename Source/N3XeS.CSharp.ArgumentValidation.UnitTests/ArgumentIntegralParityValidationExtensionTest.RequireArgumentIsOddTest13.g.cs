using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest13.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOddTest13ThrowsArgumentNullException86()
{
	this.RequireArgumentIsOddTest13(default(uint?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest13ThrowsArgumentOutOfRangeException171()
{
	this.RequireArgumentIsOddTest13(default(uint?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsOddTest13912()
{
	this.RequireArgumentIsOddTest13(default(uint?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest13ThrowsArgumentOutOfRangeException203()
{
	this.RequireArgumentIsOddTest13(new uint?(0u), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsOddTest13894()
{
	this.RequireArgumentIsOddTest13(default(uint?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest13ThrowsArgumentOutOfRangeException817()
{
	this.RequireArgumentIsOddTest13(default(uint?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest13ThrowsArgumentOutOfRangeException753()
{
	this.RequireArgumentIsOddTest13(default(uint?), "\t\t");
}
	}
}
