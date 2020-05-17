using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentEqualityValidationUtilityTest.RequireArgumentDefaultValueTest24.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentDefaultValueTest24ThrowsArgumentNullException200()
{
    this.RequireArgumentDefaultValueTest24((ushort)32, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest24ThrowsArgumentOutOfRangeException665()
{
    this.RequireArgumentDefaultValueTest24((ushort)32, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest24ThrowsArgumentOutOfRangeException637()
{
    this.RequireArgumentDefaultValueTest24((ushort)32, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentDefaultValueTest24652()
{
    this.RequireArgumentDefaultValueTest24((ushort)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest24ThrowsArgumentOutOfRangeException841()
{
    this.RequireArgumentDefaultValueTest24((ushort)32, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest24ThrowsArgumentOutOfRangeException61()
{
    this.RequireArgumentDefaultValueTest24((ushort)32, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest24ThrowsArgumentOutOfRangeException445()
{
    this.RequireArgumentDefaultValueTest24((ushort)32, "\t\t");
}
	}
}
