using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsGreaterThanOrEqualTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentGenericRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentNullException736()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>
        (new int?(1), (string)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException733()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>(new int?(1), "", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest02185()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>(new int?(1), "\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest02220()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>(default(int?), "\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException574()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>(new int?(0), "\0", 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest02304()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>(new int?(1), "Ā", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException790()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>(new int?(1), "\t", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest02ThrowsArgumentOutOfRangeException961()
{
    this.RequireArgumentIsGreaterThanOrEqualTest02<int>(new int?(1), "\t\t", 0);
}
	}
}
