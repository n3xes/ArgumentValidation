using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest27.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentEqualityValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentDefaultValueTest27ThrowsArgumentNullException545()
{
    this.RequireArgumentDefaultValueTest27<int>(default(int?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest27ThrowsArgumentOutOfRangeException581()
{
    this.RequireArgumentDefaultValueTest27<int>(default(int?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentDefaultValueTest27881()
{
    this.RequireArgumentDefaultValueTest27<int>(default(int?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest27ThrowsArgumentOutOfRangeException192()
{
    this.RequireArgumentDefaultValueTest27<int>(new int?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentDefaultValueTest27583()
{
    this.RequireArgumentDefaultValueTest27<int>(default(int?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest27ThrowsArgumentOutOfRangeException676()
{
    this.RequireArgumentDefaultValueTest27<int>(default(int?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest27ThrowsArgumentOutOfRangeException846()
{
    this.RequireArgumentDefaultValueTest27<int>(default(int?), "\t\t");
}
	}
}
