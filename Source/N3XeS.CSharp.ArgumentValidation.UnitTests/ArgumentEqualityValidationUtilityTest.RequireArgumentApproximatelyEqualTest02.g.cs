using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentApproximatelyEqualTest02ThrowsArgumentNullException131()
{
    this.RequireArgumentApproximatelyEqualTest02(0, new double?(0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest02ThrowsArgumentOutOfRangeException615()
{
    this.RequireArgumentApproximatelyEqualTest02(0, new double?(0), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentApproximatelyEqualTest02333()
{
    this.RequireArgumentApproximatelyEqualTest02(0, new double?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest02ThrowsArgumentOutOfRangeException823()
{
    this.RequireArgumentApproximatelyEqualTest02(0, default(double?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentApproximatelyEqualTest02391()
{
    this.RequireArgumentApproximatelyEqualTest02(0, new double?(0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest02ThrowsArgumentOutOfRangeException802()
{
    this.RequireArgumentApproximatelyEqualTest02(0, new double?(0), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest02ThrowsArgumentOutOfRangeException29()
{
    this.RequireArgumentApproximatelyEqualTest02(0, new double?(0), "\t\t");
}
	}
}
