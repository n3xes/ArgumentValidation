using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentFloatingPointNumberParityValidationExtensionTests.RequireArgumentIsEvenTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentFloatingPointNumberParityValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentNullException237()
{
	this.RequireArgumentIsEvenTest01(new double?(0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTests))]
public void RequireArgumentIsEvenTest01705()
{
	this.RequireArgumentIsEvenTest01(new double?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTests))]
public void RequireArgumentIsEvenTest01912()
{
	this.RequireArgumentIsEvenTest01(default(double?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException375()
{
	this.RequireArgumentIsEvenTest01(default(double?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException28501()
{
	this.RequireArgumentIsEvenTest01(new double?(3), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTests))]
public void RequireArgumentIsEvenTest01894()
{
	this.RequireArgumentIsEvenTest01(default(double?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest01ThrowsArgumentOutOfRangeException771()
{
	this.RequireArgumentIsEvenTest01(default(double?), "\t\t");
}
	}
}
