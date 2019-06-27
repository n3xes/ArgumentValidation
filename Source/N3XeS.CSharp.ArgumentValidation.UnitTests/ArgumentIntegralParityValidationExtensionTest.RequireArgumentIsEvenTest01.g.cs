using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsEvenTest01ThrowsArgumentNullException813()
{
	this.RequireArgumentIsEvenTest01(new byte?((byte)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException926()
{
	this.RequireArgumentIsEvenTest01(new byte?((byte)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException486()
{
	this.RequireArgumentIsEvenTest01(new byte?((byte)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsEvenTest01912()
{
	this.RequireArgumentIsEvenTest01(default(byte?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException291()
{
	this.RequireArgumentIsEvenTest01(new byte?((byte)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException132()
{
	this.RequireArgumentIsEvenTest01(new byte?((byte)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException156()
{
	this.RequireArgumentIsEvenTest01(new byte?((byte)1), "\t\t");
}
	}
}
