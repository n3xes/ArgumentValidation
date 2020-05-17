using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest17.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotDefaultValueTest17ThrowsArgumentNullException77()
{
    this.RequireArgumentNotDefaultValueTest17(new sbyte?((sbyte)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest17ThrowsArgumentOutOfRangeException664()
{
    this.RequireArgumentNotDefaultValueTest17(new sbyte?((sbyte)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentNotDefaultValueTest17133()
{
    this.RequireArgumentNotDefaultValueTest17(new sbyte?((sbyte)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest17ThrowsArgumentOutOfRangeException36()
{
    this.RequireArgumentNotDefaultValueTest17(default(sbyte?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentNotDefaultValueTest17911()
{
    this.RequireArgumentNotDefaultValueTest17(new sbyte?((sbyte)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest17ThrowsArgumentOutOfRangeException246()
{
    this.RequireArgumentNotDefaultValueTest17(new sbyte?((sbyte)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest17ThrowsArgumentOutOfRangeException825()
{
    this.RequireArgumentNotDefaultValueTest17(new sbyte?((sbyte)1), "\t\t");
}
	}
}
