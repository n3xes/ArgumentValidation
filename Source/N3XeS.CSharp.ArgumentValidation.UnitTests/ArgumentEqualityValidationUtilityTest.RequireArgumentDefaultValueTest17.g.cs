using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest17.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentDefaultValueTest17ThrowsArgumentNullException871()
{
    this.RequireArgumentDefaultValueTest17(new sbyte?((sbyte)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest17ThrowsArgumentOutOfRangeException311()
{
    this.RequireArgumentDefaultValueTest17(new sbyte?((sbyte)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest17ThrowsArgumentOutOfRangeException176()
{
    this.RequireArgumentDefaultValueTest17(new sbyte?((sbyte)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentDefaultValueTest17881()
{
    this.RequireArgumentDefaultValueTest17(default(sbyte?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest17ThrowsArgumentOutOfRangeException239()
{
    this.RequireArgumentDefaultValueTest17(new sbyte?((sbyte)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest17ThrowsArgumentOutOfRangeException982()
{
    this.RequireArgumentDefaultValueTest17(new sbyte?((sbyte)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest17ThrowsArgumentOutOfRangeException757()
{
    this.RequireArgumentDefaultValueTest17(new sbyte?((sbyte)1), "\t\t");
}
	}
}
