using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentEqualityValidationExtensionTest.RequireArgumentDefaultValueTest07.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentDefaultValueTest07ThrowsArgumentNullException847()
{
    this.RequireArgumentDefaultValueTest07(default(char?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest07ThrowsArgumentOutOfRangeException440()
{
    this.RequireArgumentDefaultValueTest07(default(char?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentDefaultValueTest07881()
{
    this.RequireArgumentDefaultValueTest07(default(char?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest07ThrowsArgumentOutOfRangeException238()
{
    this.RequireArgumentDefaultValueTest07(new char?('\0'), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentDefaultValueTest07583()
{
    this.RequireArgumentDefaultValueTest07(default(char?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest07ThrowsArgumentOutOfRangeException437()
{
    this.RequireArgumentDefaultValueTest07(default(char?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest07ThrowsArgumentOutOfRangeException493()
{
    this.RequireArgumentDefaultValueTest07(default(char?), "\t\t");
}
	}
}
