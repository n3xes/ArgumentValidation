using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentFloatingPointNumberParityValidationExtensionTest.RequireArgumentIsOddTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentFloatingPointNumberParityValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOddTest03ThrowsArgumentNullException897()
{
	this.RequireArgumentIsOddTest03(new float?((float)0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTest))]
public void RequireArgumentIsOddTest03912()
{
	this.RequireArgumentIsOddTest03(default(float?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException490()
{
	this.RequireArgumentIsOddTest03(default(float?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException63301()
{
	this.RequireArgumentIsOddTest03(new float?((float)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTest))]
public void RequireArgumentIsOddTest03894()
{
	this.RequireArgumentIsOddTest03(default(float?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentFloatingPointNumberParityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOddTest03ThrowsArgumentOutOfRangeException803()
{
	this.RequireArgumentIsOddTest03(default(float?), "\t\t");
}
	}
}
