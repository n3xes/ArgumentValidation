using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentHasNoValueTest.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentEqualityValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentHasNoValueTestThrowsArgumentNullException151()
{
    this.RequireArgumentHasNoValueTest((string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNoValueTestThrowsArgumentOutOfRangeException674()
{
    this.RequireArgumentHasNoValueTest((string)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentHasNoValueTest881()
{
    this.RequireArgumentHasNoValueTest((string)null, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNoValueTestThrowsArgumentOutOfRangeException366()
{
    this.RequireArgumentHasNoValueTest("", "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentHasNoValueTest583()
{
    this.RequireArgumentHasNoValueTest((string)null, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNoValueTestThrowsArgumentOutOfRangeException595()
{
    this.RequireArgumentHasNoValueTest((string)null, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNoValueTestThrowsArgumentOutOfRangeException673()
{
    this.RequireArgumentHasNoValueTest((string)null, "\n\t");
}
	}
}
