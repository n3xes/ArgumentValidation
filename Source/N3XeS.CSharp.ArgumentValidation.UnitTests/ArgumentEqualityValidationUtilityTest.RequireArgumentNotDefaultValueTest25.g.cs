using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest25.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotDefaultValueTest25ThrowsArgumentNullException996()
{
    this.RequireArgumentNotDefaultValueTest25(default(ushort?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest25ThrowsArgumentOutOfRangeException77()
{
    this.RequireArgumentNotDefaultValueTest25(default(ushort?), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest25ThrowsArgumentOutOfRangeException748()
{
    this.RequireArgumentNotDefaultValueTest25(default(ushort?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotDefaultValueTest25652()
{
    this.RequireArgumentNotDefaultValueTest25(new ushort?((ushort)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest25ThrowsArgumentOutOfRangeException152()
{
    this.RequireArgumentNotDefaultValueTest25(default(ushort?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest25ThrowsArgumentOutOfRangeException448()
{
    this.RequireArgumentNotDefaultValueTest25(default(ushort?), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest25ThrowsArgumentOutOfRangeException875()
{
    this.RequireArgumentNotDefaultValueTest25(default(ushort?), "\t\t");
}
	}
}
