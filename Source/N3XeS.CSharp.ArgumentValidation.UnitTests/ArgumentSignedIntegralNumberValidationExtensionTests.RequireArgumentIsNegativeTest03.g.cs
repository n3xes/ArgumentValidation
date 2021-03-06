using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsNegativeTest03ThrowsArgumentNullException763()
{
	this.RequireArgumentIsNegativeTest03(default(int?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest03ThrowsArgumentOutOfRangeException980()
{
	this.RequireArgumentIsNegativeTest03(default(int?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsNegativeTest03912()
{
	this.RequireArgumentIsNegativeTest03(default(int?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsNegativeTest03705()
{
	this.RequireArgumentIsNegativeTest03(new int?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest03ThrowsArgumentOutOfRangeException209()
{
	this.RequireArgumentIsNegativeTest03(new int?(2), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsNegativeTest03894()
{
	this.RequireArgumentIsNegativeTest03(default(int?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest03ThrowsArgumentOutOfRangeException814()
{
	this.RequireArgumentIsNegativeTest03(default(int?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest03ThrowsArgumentOutOfRangeException879()
{
	this.RequireArgumentIsNegativeTest03(default(int?), "\t\t");
}
	}
}
