using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentNotApproximatelyDefaultValueTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentNullException526()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException720()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException853()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotApproximatelyDefaultValueTest01433()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)1, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException921()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException840()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyDefaultValueTest01ThrowsArgumentOutOfRangeException721()
{
    this.RequireArgumentNotApproximatelyDefaultValueTest01((float)0, "\t\t");
}
	}
}
