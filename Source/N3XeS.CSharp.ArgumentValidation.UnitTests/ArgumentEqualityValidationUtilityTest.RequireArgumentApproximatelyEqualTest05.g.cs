using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest05.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentApproximatelyEqualTest05ThrowsArgumentNullException713()
{
    this.RequireArgumentApproximatelyEqualTest05
        (new float?((float)0), (float)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest05ThrowsArgumentOutOfRangeException736()
{
    this.RequireArgumentApproximatelyEqualTest05(new float?((float)0), (float)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentApproximatelyEqualTest05333()
{
    this.RequireArgumentApproximatelyEqualTest05
        (new float?((float)0), (float)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest05ThrowsArgumentOutOfRangeException959()
{
    this.RequireArgumentApproximatelyEqualTest05(default(float?), (float)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentApproximatelyEqualTest05391()
{
    this.RequireArgumentApproximatelyEqualTest05
        (new float?((float)0), (float)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest05ThrowsArgumentOutOfRangeException632()
{
    this.RequireArgumentApproximatelyEqualTest05
        (new float?((float)0), (float)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest05ThrowsArgumentOutOfRangeException795()
{
    this.RequireArgumentApproximatelyEqualTest05
        (new float?((float)0), (float)0, "\t\t");
}
	}
}
