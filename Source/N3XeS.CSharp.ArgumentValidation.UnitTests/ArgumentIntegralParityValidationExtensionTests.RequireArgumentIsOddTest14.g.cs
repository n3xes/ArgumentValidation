using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentIntegralParityValidationExtensionTests.RequireArgumentIsOddTest14.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOddTest14ThrowsArgumentNullException941()
{
	this.RequireArgumentIsOddTest14(0uL, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest14ThrowsArgumentOutOfRangeException204()
{
	this.RequireArgumentIsOddTest14(0uL, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest14ThrowsArgumentOutOfRangeException310()
{
	this.RequireArgumentIsOddTest14(0uL, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
public void RequireArgumentIsOddTest14428()
{
	this.RequireArgumentIsOddTest14(1uL, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest14ThrowsArgumentOutOfRangeException706()
{
	this.RequireArgumentIsOddTest14(0uL, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest14ThrowsArgumentOutOfRangeException83()
{
	this.RequireArgumentIsOddTest14(0uL, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest14ThrowsArgumentOutOfRangeException295()
{
	this.RequireArgumentIsOddTest14(0uL, "\t\t");
}
	}
}
