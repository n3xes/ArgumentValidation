using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationExtensionTest.RequireArgumentNotDefaultValueTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentEqualityValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentNotDefaultValueTest03ThrowsArgumentNullException127()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest03(new Guid?(s0), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest03ThrowsArgumentOutOfRangeException866()
{
    Guid s0 = new Guid(1, (short)32, (short)32, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest03(new Guid?(s0), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentNotDefaultValueTest03689()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest03(new Guid?(s0), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest03ThrowsArgumentOutOfRangeException689()
{
    this.RequireArgumentNotDefaultValueTest03(default(Guid?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
public void RequireArgumentNotDefaultValueTest03767()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest03(new Guid?(s0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest03ThrowsArgumentOutOfRangeException216()
{
    Guid s0 = new Guid(1, (short)32, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest03(new Guid?(s0), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest03ThrowsArgumentOutOfRangeException473()
{
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest03(new Guid?(s0), "\t\t");
}
	}
}
