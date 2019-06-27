using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTest.RequireArgumentNotApproximatelyEqualTest07.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentNullException884()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException170()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotApproximatelyEqualTest0747()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotApproximatelyEqualTest07673()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), default(float?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException825()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotApproximatelyEqualTest07277()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotApproximatelyEqualTest07327()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (default(float?), new float?((float)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException677()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException895()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (default(float?), default(float?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException691()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\t\t");
}
	}
}
