using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTests.RequireArgumentDefaultValueTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentDefaultValueTest03ThrowsArgumentNullException606()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentDefaultValueTest03(new Guid?(s0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest03ThrowsArgumentOutOfRangeException950()
{
    Guid s0 = new Guid(1, (short)32, (short)32, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentDefaultValueTest03(new Guid?(s0), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest03ThrowsArgumentOutOfRangeException45()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentDefaultValueTest03(new Guid?(s0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
public void RequireArgumentDefaultValueTest03881()
{
    this.RequireArgumentDefaultValueTest03(default(Guid?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest03ThrowsArgumentOutOfRangeException408()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentDefaultValueTest03(new Guid?(s0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest03ThrowsArgumentOutOfRangeException550()
{
    Guid s0 = new Guid(1, (short)32, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentDefaultValueTest03(new Guid?(s0), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentDefaultValueTest03ThrowsArgumentOutOfRangeException725()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentDefaultValueTest03(new Guid?(s0), "\t\t");
}
	}
}
