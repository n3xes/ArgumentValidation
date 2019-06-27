using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsEvenTest17ThrowsArgumentNullException650()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentOutOfRangeException944()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsEvenTest17912()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsEvenTest17705()
{
	this.RequireArgumentIsEvenTest17(new ushort?((ushort)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentOutOfRangeException142()
{
	this.RequireArgumentIsEvenTest17(new ushort?((ushort)33), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
public void RequireArgumentIsEvenTest17894()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentOutOfRangeException875()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest17ThrowsArgumentOutOfRangeException752()
{
	this.RequireArgumentIsEvenTest17(default(ushort?), "\t\t");
}
	}
}
