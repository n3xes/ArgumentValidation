using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationExtensionTests.RequireArgumentIsOddTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentIntegralParityValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOddTest01ThrowsArgumentNullException660()
{
	this.RequireArgumentIsOddTest01(new byte?((byte)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest01ThrowsArgumentOutOfRangeException341()
{
	this.RequireArgumentIsOddTest01(new byte?((byte)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest01652()
{
	this.RequireArgumentIsOddTest01(new byte?((byte)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest01912()
{
	this.RequireArgumentIsOddTest01(default(byte?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest01ThrowsArgumentOutOfRangeException278()
{
	this.RequireArgumentIsOddTest01(new byte?((byte)2), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest01814()
{
	this.RequireArgumentIsOddTest01(new byte?((byte)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest01ThrowsArgumentOutOfRangeException488()
{
	this.RequireArgumentIsOddTest01(new byte?((byte)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest01ThrowsArgumentOutOfRangeException54()
{
	this.RequireArgumentIsOddTest01(new byte?((byte)1), "\t\t");
}
	}
}
