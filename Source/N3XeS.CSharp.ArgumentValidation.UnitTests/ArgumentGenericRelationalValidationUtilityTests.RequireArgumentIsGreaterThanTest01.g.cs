using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsGreaterThanTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsGreaterThanTest01ThrowsArgumentNullException463()
{
    this.RequireArgumentIsGreaterThanTest01<int>(1, (string)null, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest01ThrowsArgumentOutOfRangeException866()
{
    this.RequireArgumentIsGreaterThanTest01<int>(1, "", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest01780()
{
    this.RequireArgumentIsGreaterThanTest01<int>(1, "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest01185()
{
    this.RequireArgumentIsGreaterThanTest01<int>(1, "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest01ThrowsArgumentOutOfRangeException914()
{
    this.RequireArgumentIsGreaterThanTest01<int>(0, "\0", new int?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest01705()
{
    this.RequireArgumentIsGreaterThanTest01<int>(1, "Ā", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest01ThrowsArgumentOutOfRangeException605()
{
    this.RequireArgumentIsGreaterThanTest01<int>(1, "\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest01ThrowsArgumentOutOfRangeException223()
{
    this.RequireArgumentIsGreaterThanTest01<int>(1, "\n\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentNullException223()
{
    this.RequireArgumentIsGreaterThanTest<int>(0, (string)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException363()
{
    this.RequireArgumentIsGreaterThanTest<int>(0, "", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException931()
{
    this.RequireArgumentIsGreaterThanTest<int>(0, "\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest713()
{
    this.RequireArgumentIsGreaterThanTest<int>(20, "\0", 9);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException432()
{
    this.RequireArgumentIsGreaterThanTest<int>(0, "Ā", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException966()
{
    this.RequireArgumentIsGreaterThanTest<int>(0, "\t", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTestThrowsArgumentOutOfRangeException973()
{
    this.RequireArgumentIsGreaterThanTest<int>(0, "\t\t", 0);
}
	}
}
