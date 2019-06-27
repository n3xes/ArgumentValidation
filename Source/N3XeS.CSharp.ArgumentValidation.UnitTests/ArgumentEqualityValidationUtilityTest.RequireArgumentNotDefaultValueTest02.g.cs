using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentEqualityValidationUtilityTest.RequireArgumentNotDefaultValueTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentNotDefaultValueTest02ThrowsArgumentNullException543()
{
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest02(s0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest02ThrowsArgumentOutOfRangeException44()
{
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest02(s0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotDefaultValueTest02912()
{
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest02(s0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest02ThrowsArgumentOutOfRangeException500()
{
    this.RequireArgumentNotDefaultValueTest02(default(Guid), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
public void RequireArgumentNotDefaultValueTest02848()
{
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest02(s0, "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest02ThrowsArgumentOutOfRangeException317()
{
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest02(s0, "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentEqualityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentNotDefaultValueTest02ThrowsArgumentOutOfRangeException18()
{
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    this.RequireArgumentNotDefaultValueTest02(s0, "\t\t");
}
	}
}
