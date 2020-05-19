using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentNotApproximatelyEqualTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotApproximatelyEqualTest02ThrowsArgumentNullException429()
{
    this.RequireArgumentNotApproximatelyEqualTest02(0, new double?(0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest02ThrowsArgumentOutOfRangeException()
{
    this.RequireArgumentNotApproximatelyEqualTest02(0, new double?(0), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest02ThrowsArgumentOutOfRangeException295()
{
    this.RequireArgumentNotApproximatelyEqualTest02(0, new double?(0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotApproximatelyEqualTest02673()
{
    this.RequireArgumentNotApproximatelyEqualTest02(0, default(double?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest02ThrowsArgumentOutOfRangeException54()
{
    this.RequireArgumentNotApproximatelyEqualTest02(0, new double?(0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest02ThrowsArgumentOutOfRangeException749()
{
    this.RequireArgumentNotApproximatelyEqualTest02(0, new double?(0), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest02ThrowsArgumentOutOfRangeException206()
{
    this.RequireArgumentNotApproximatelyEqualTest02(0, new double?(0), "\t\t");
}
	}
}
