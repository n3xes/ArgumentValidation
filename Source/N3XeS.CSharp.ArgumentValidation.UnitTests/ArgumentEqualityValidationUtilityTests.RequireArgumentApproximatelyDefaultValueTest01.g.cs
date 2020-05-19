using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTests.RequireArgumentApproximatelyDefaultValueTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentApproximatelyDefaultValueTest01ThrowsArgumentNullException813()
{
    this.RequireArgumentApproximatelyDefaultValueTest01((float)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException17()
{
    this.RequireArgumentApproximatelyDefaultValueTest01((float)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentApproximatelyDefaultValueTest01652()
{
    this.RequireArgumentApproximatelyDefaultValueTest01((float)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException934()
{
    this.RequireArgumentApproximatelyDefaultValueTest01
        ((float)0.93272614479064941, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentApproximatelyDefaultValueTest01388()
{
    this.RequireArgumentApproximatelyDefaultValueTest01((float)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException672()
{
    this.RequireArgumentApproximatelyDefaultValueTest01((float)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException809()
{
    this.RequireArgumentApproximatelyDefaultValueTest01((float)0, "\t\t");
}
	}
}
