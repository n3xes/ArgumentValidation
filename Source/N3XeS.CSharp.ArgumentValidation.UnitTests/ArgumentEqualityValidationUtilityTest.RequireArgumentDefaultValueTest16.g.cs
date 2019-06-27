using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest16.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentDefaultValueTest16ThrowsArgumentNullException782()
{
    this.RequireArgumentDefaultValueTest16((sbyte)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest16ThrowsArgumentOutOfRangeException126()
{
    this.RequireArgumentDefaultValueTest16((sbyte)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentDefaultValueTest16976()
{
    this.RequireArgumentDefaultValueTest16((sbyte)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest16ThrowsArgumentOutOfRangeException332()
{
    this.RequireArgumentDefaultValueTest16((sbyte)1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentDefaultValueTest16408()
{
    this.RequireArgumentDefaultValueTest16((sbyte)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest16ThrowsArgumentOutOfRangeException117()
{
    this.RequireArgumentDefaultValueTest16((sbyte)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest16ThrowsArgumentOutOfRangeException893()
{
    this.RequireArgumentDefaultValueTest16((sbyte)0, "\t\t");
}
	}
}
