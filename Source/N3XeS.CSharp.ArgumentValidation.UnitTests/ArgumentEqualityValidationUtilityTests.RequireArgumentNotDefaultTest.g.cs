using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTests.RequireArgumentNotDefaultTest.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotDefaultTestThrowsArgumentNullException370()
{
    this.RequireArgumentNotDefaultTest<string>((string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultTestThrowsArgumentOutOfRangeException658()
{
    this.RequireArgumentNotDefaultTest<string>((string)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultTestThrowsArgumentOutOfRangeException859()
{
    this.RequireArgumentNotDefaultTest<string>((string)null, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentNotDefaultTest712()
{
    this.RequireArgumentNotDefaultTest<string>("", "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultTestThrowsArgumentOutOfRangeException583()
{
    this.RequireArgumentNotDefaultTest<string>((string)null, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultTestThrowsArgumentOutOfRangeException967()
{
    this.RequireArgumentNotDefaultTest<string>((string)null, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultTestThrowsArgumentOutOfRangeException506()
{
    this.RequireArgumentNotDefaultTest<string>((string)null, "\n\t");
}
	}
}
