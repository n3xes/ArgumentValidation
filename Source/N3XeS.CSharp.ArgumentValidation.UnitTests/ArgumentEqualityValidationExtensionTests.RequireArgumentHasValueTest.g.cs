using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentHasValueTest.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentHasValueTestThrowsArgumentNullException974()
{
    this.RequireArgumentHasValueTest((string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasValueTestThrowsArgumentOutOfRangeException213()
{
    this.RequireArgumentHasValueTest((string)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentHasValueTestThrowsArgumentNullException770()
{
    this.RequireArgumentHasValueTest((string)null, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentHasValueTest712()
{
    this.RequireArgumentHasValueTest("", "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasValueTestThrowsArgumentOutOfRangeException83()
{
    this.RequireArgumentHasValueTest("", "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentHasValueTestThrowsArgumentNullException334()
{
    this.RequireArgumentHasValueTest((string)null, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasValueTestThrowsArgumentOutOfRangeException457()
{
    this.RequireArgumentHasValueTest((string)null, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentHasValueTestThrowsArgumentOutOfRangeException388()
{
    this.RequireArgumentHasValueTest((string)null, "\n\t");
}
	}
}
