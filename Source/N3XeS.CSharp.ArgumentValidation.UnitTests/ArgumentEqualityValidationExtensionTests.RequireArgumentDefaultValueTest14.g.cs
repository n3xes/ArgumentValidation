using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentDefaultValueTest14.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentDefaultValueTest14ThrowsArgumentNullException723()
{
    this.RequireArgumentDefaultValueTest14(0L, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest14ThrowsArgumentOutOfRangeException792()
{
    this.RequireArgumentDefaultValueTest14(0L, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentDefaultValueTest14652()
{
    this.RequireArgumentDefaultValueTest14(0L, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest14ThrowsArgumentOutOfRangeException339()
{
    this.RequireArgumentDefaultValueTest14(1L, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentDefaultValueTest14388()
{
    this.RequireArgumentDefaultValueTest14(0L, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest14ThrowsArgumentOutOfRangeException22()
{
    this.RequireArgumentDefaultValueTest14(0L, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest14ThrowsArgumentOutOfRangeException246()
{
    this.RequireArgumentDefaultValueTest14(0L, "\t\t");
}
	}
}
