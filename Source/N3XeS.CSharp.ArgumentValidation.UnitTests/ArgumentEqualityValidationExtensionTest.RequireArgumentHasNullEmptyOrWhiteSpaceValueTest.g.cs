using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentEqualityValidationExtensionTest.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTestThrowsArgumentNullException798()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest
        ((string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTestThrowsArgumentOutOfRangeException993()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest((string)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTest881()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest((string)null, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTestThrowsArgumentOutOfRangeException749()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest("", "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTest493()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest("\t", "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTest583()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest((string)null, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTestThrowsArgumentOutOfRangeException614()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest((string)null, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTestThrowsArgumentOutOfRangeException944()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest("Ā", "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTestThrowsArgumentOutOfRangeException270()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest((string)null, "\n\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTestThrowsArgumentOutOfRangeException361()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest("\tĀ", "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentHasNullEmptyOrWhiteSpaceValueTest286()
{
    this.RequireArgumentHasNullEmptyOrWhiteSpaceValueTest("\t\t", "");
}
	}
}
