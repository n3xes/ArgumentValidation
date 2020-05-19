using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTests.RequireArgumentApproximatelyEqualTest07.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentNullException522()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentOutOfRangeException658()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentOutOfRangeException815()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentOutOfRangeException194()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), default(float?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentApproximatelyEqualTest07333()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), new float?((float)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentOutOfRangeException946()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentOutOfRangeException296()
{
    this.RequireArgumentApproximatelyEqualTest07
        (default(float?), new float?((float)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentOutOfRangeException48()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentApproximatelyEqualTest0769()
{
    this.RequireArgumentApproximatelyEqualTest07
        (default(float?), default(float?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest07ThrowsArgumentOutOfRangeException224()
{
    this.RequireArgumentApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\t\t");
}
	}
}
