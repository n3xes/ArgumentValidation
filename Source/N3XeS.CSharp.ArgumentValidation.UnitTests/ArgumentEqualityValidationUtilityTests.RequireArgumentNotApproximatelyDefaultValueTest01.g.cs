using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTests.RequireArgumentNotApproximatelyDefaultValueTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentNullException638()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException640()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException657()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
public void RequireArgumentNotApproximatelyDefaultValueTest01433()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException757()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException608()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException930()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "\t\t");
}
	}
}
