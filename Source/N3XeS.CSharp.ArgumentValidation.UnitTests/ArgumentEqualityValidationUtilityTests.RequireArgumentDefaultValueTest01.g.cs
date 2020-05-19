using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTests.RequireArgumentDefaultValueTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentEqualityValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentDefaultValueTest01ThrowsArgumentNullException252()
{
    this.RequireArgumentDefaultValueTest01(default(DateTime?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest01ThrowsArgumentOutOfRangeException388()
{
    this.RequireArgumentDefaultValueTest01(default(DateTime?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentDefaultValueTest01881()
{
    this.RequireArgumentDefaultValueTest01(default(DateTime?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest01ThrowsArgumentOutOfRangeException41()
{
    this.RequireArgumentDefaultValueTest01(new DateTime?(default(DateTime)), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentDefaultValueTest01583()
{
    this.RequireArgumentDefaultValueTest01(default(DateTime?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest01ThrowsArgumentOutOfRangeException947()
{
    this.RequireArgumentDefaultValueTest01(default(DateTime?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest01ThrowsArgumentOutOfRangeException211()
{
    this.RequireArgumentDefaultValueTest01(default(DateTime?), "\t\t");
}
	}
}
