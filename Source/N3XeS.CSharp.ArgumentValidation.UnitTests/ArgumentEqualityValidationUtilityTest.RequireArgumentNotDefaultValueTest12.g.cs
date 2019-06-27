using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest12.g.cs">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	public partial class ArgumentEqualityValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentNotDefaultValueTest12ThrowsArgumentNullException71()
{
    this.RequireArgumentNotDefaultValueTest12(0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest12ThrowsArgumentOutOfRangeException997()
{
    this.RequireArgumentNotDefaultValueTest12(0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest12ThrowsArgumentOutOfRangeException337()
{
    this.RequireArgumentNotDefaultValueTest12(0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotDefaultValueTest12433()
{
    this.RequireArgumentNotDefaultValueTest12(1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest12ThrowsArgumentOutOfRangeException108()
{
    this.RequireArgumentNotDefaultValueTest12(0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest12ThrowsArgumentOutOfRangeException95()
{
    this.RequireArgumentNotDefaultValueTest12(0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest12ThrowsArgumentOutOfRangeException252()
{
    this.RequireArgumentNotDefaultValueTest12(0, "\t\t");
}
	}
}
