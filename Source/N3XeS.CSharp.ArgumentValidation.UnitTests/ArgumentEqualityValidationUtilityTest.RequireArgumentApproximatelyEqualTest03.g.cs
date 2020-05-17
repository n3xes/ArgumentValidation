using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentEqualityValidationUtilityTest.RequireArgumentApproximatelyEqualTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentNullException501()
{
    this.RequireArgumentApproximatelyEqualTest03
        (new double?(0), new double?(1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentOutOfRangeException629()
{
    this.RequireArgumentApproximatelyEqualTest03(new double?(0), new double?(1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentOutOfRangeException441()
{
    this.RequireArgumentApproximatelyEqualTest03
        (new double?(0), new double?(1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentOutOfRangeException713()
{
    this.RequireArgumentApproximatelyEqualTest03
        (new double?(0), default(double?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentApproximatelyEqualTest03945()
{
    this.RequireArgumentApproximatelyEqualTest03
        (new double?(double.Epsilon), new double?(9.88131291682493E-324), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentOutOfRangeException884()
{
    this.RequireArgumentApproximatelyEqualTest03
        (new double?(0), new double?(1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentOutOfRangeException390()
{
    this.RequireArgumentApproximatelyEqualTest03
        (default(double?), new double?(1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentOutOfRangeException90()
{
    this.RequireArgumentApproximatelyEqualTest03
        (new double?(0), new double?(1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentApproximatelyEqualTest0369()
{
    this.RequireArgumentApproximatelyEqualTest03
        (default(double?), default(double?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentApproximatelyEqualTest03ThrowsArgumentOutOfRangeException354()
{
    this.RequireArgumentApproximatelyEqualTest03
        (new double?(0), new double?(1), "\t\t");
}
	}
}
