using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentNotDefaultValueTest23.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotDefaultValueTest23ThrowsArgumentNullException75()
{
    this.RequireArgumentNotDefaultValueTest23(new ulong?(1uL), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest23ThrowsArgumentOutOfRangeException80()
{
    this.RequireArgumentNotDefaultValueTest23(new ulong?(1uL), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotDefaultValueTest23433()
{
    this.RequireArgumentNotDefaultValueTest23(new ulong?(1uL), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest23ThrowsArgumentOutOfRangeException620()
{
    this.RequireArgumentNotDefaultValueTest23(default(ulong?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentNotDefaultValueTest23589()
{
    this.RequireArgumentNotDefaultValueTest23(new ulong?(1uL), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest23ThrowsArgumentOutOfRangeException832()
{
    this.RequireArgumentNotDefaultValueTest23(new ulong?(1uL), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest23ThrowsArgumentOutOfRangeException917()
{
    this.RequireArgumentNotDefaultValueTest23(new ulong?(1uL), "\t\t");
}
	}
}
