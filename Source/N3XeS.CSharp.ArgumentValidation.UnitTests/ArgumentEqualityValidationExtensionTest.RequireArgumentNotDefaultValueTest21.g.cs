using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest21.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotDefaultValueTest21ThrowsArgumentNullException265()
{
    this.RequireArgumentNotDefaultValueTest21(default(uint?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest21ThrowsArgumentOutOfRangeException372()
{
    this.RequireArgumentNotDefaultValueTest21(default(uint?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest21ThrowsArgumentOutOfRangeException61()
{
    this.RequireArgumentNotDefaultValueTest21(default(uint?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentNotDefaultValueTest21652()
{
    this.RequireArgumentNotDefaultValueTest21(new uint?(0u), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest21ThrowsArgumentOutOfRangeException242()
{
    this.RequireArgumentNotDefaultValueTest21(default(uint?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest21ThrowsArgumentOutOfRangeException466()
{
    this.RequireArgumentNotDefaultValueTest21(default(uint?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest21ThrowsArgumentOutOfRangeException592()
{
    this.RequireArgumentNotDefaultValueTest21(default(uint?), "\t\t");
}
	}
}
