using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest06.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentGenericRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest06ThrowsArgumentNullException784()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (new int?(512), (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest06ThrowsArgumentOutOfRangeException686()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (new int?(1), "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest06ThrowsArgumentOutOfRangeException918()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (new int?(1), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest0648()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (default(int?), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest06ThrowsArgumentOutOfRangeException268()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (new int?(0), "\0", new int?(1), 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest06ThrowsArgumentOutOfRangeException23()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (new int?(2), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest06ThrowsArgumentOutOfRangeException629()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (new int?(1), "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest06ThrowsArgumentOutOfRangeException785()
{
    this.RequireArgumentIsOutsideExclusiveTest06<int>
        (new int?(1), "\t\0", new int?(1), 0);
}
	}
}
