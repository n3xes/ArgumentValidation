using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentNotApproximatelyEqualTest07.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentNullException664()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException274()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotApproximatelyEqualTest0747()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotApproximatelyEqualTest07673()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), default(float?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException223()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotApproximatelyEqualTest07277()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotApproximatelyEqualTest07327()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (default(float?), new float?((float)1), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException310()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException870()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (default(float?), default(float?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotApproximatelyEqualTest07ThrowsArgumentOutOfRangeException349()
{
    this.RequireArgumentNotApproximatelyEqualTest07
        (new float?((float)0), new float?((float)1), "\t\t");
}
	}
}
