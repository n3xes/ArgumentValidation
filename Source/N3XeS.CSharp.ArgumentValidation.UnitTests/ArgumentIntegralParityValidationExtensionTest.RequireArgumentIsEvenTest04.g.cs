using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsEvenTest04ThrowsArgumentNullException151()
{
	this.RequireArgumentIsEvenTest04(0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest04ThrowsArgumentOutOfRangeException460()
{
	this.RequireArgumentIsEvenTest04(0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsEvenTest04705()
{
	this.RequireArgumentIsEvenTest04(0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest04ThrowsArgumentOutOfRangeException65()
{
	this.RequireArgumentIsEvenTest04(763, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsEvenTest04253()
{
	this.RequireArgumentIsEvenTest04(0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest04ThrowsArgumentOutOfRangeException231()
{
	this.RequireArgumentIsEvenTest04(0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest04ThrowsArgumentOutOfRangeException199()
{
	this.RequireArgumentIsEvenTest04(0, "\t\t");
}
	}
}
