using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTests.RequireArgumentNotNullTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotNullTest01ThrowsArgumentNullException588()
{
    this.RequireArgumentNotNullTest01<int>(default(int?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotNullTest01ThrowsArgumentOutOfRangeException811()
{
    this.RequireArgumentNotNullTest01<int>(default(int?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentNotNullTest01ThrowsArgumentNullException560()
{
    this.RequireArgumentNotNullTest01<int>(default(int?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentNotNullTest01652()
{
    this.RequireArgumentNotNullTest01<int>(new int?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentNotNullTest01ThrowsArgumentNullException110()
{
    this.RequireArgumentNotNullTest01<int>(default(int?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotNullTest01ThrowsArgumentOutOfRangeException985()
{
    this.RequireArgumentNotNullTest01<int>(default(int?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotNullTest01ThrowsArgumentOutOfRangeException909()
{
    this.RequireArgumentNotNullTest01<int>(default(int?), "\t\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentNotNullTestThrowsArgumentNullException522()
{
    this.RequireArgumentNotNullTest<string>((string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotNullTestThrowsArgumentOutOfRangeException586()
{
    this.RequireArgumentNotNullTest<string>((string)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentNotNullTestThrowsArgumentNullException691()
{
    this.RequireArgumentNotNullTest<string>((string)null, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentNotNullTest712()
{
    this.RequireArgumentNotNullTest<string>("", "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentNotNullTestThrowsArgumentNullException270()
{
    this.RequireArgumentNotNullTest<string>((string)null, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotNullTestThrowsArgumentOutOfRangeException348()
{
    this.RequireArgumentNotNullTest<string>((string)null, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotNullTestThrowsArgumentOutOfRangeException61()
{
    this.RequireArgumentNotNullTest<string>((string)null, "\n\t");
}
	}
}
