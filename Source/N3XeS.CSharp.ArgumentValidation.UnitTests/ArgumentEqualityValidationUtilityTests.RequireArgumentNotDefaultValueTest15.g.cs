using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTests.RequireArgumentNotDefaultValueTest15.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotDefaultValueTest15ThrowsArgumentNullException847()
{
    this.RequireArgumentNotDefaultValueTest15(new long?(1L), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest15ThrowsArgumentOutOfRangeException805()
{
    this.RequireArgumentNotDefaultValueTest15(new long?(1L), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentNotDefaultValueTest15433()
{
    this.RequireArgumentNotDefaultValueTest15(new long?(1L), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest15ThrowsArgumentOutOfRangeException690()
{
    this.RequireArgumentNotDefaultValueTest15(default(long?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentNotDefaultValueTest15589()
{
    this.RequireArgumentNotDefaultValueTest15(new long?(1L), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest15ThrowsArgumentOutOfRangeException280()
{
    this.RequireArgumentNotDefaultValueTest15(new long?(1L), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest15ThrowsArgumentOutOfRangeException208()
{
    this.RequireArgumentNotDefaultValueTest15(new long?(1L), "\t\t");
}
	}
}
