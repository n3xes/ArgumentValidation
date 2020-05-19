using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsGreaterThanOrEqualTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest01ThrowsArgumentNullException378()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>
        (1, (string)null, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest01ThrowsArgumentOutOfRangeException279()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>(1, "", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest01780()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>(1, "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest01185()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>(1, "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest01ThrowsArgumentOutOfRangeException586()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>(128, "\0", new int?(513));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest01705()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>(1, "Ā", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest01ThrowsArgumentOutOfRangeException510()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>(1, "\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest01ThrowsArgumentOutOfRangeException123()
{
    this.RequireArgumentIsGreaterThanOrEqualTest01<int>(1, "\n\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanOrEqualTestThrowsArgumentNullException466()
{
    this.RequireArgumentIsGreaterThanOrEqualTest<int>(0, (string)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTestThrowsArgumentOutOfRangeException624()
{
    this.RequireArgumentIsGreaterThanOrEqualTest<int>(0, "", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest823()
{
    this.RequireArgumentIsGreaterThanOrEqualTest<int>(0, "\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTestThrowsArgumentOutOfRangeException186()
{
    this.RequireArgumentIsGreaterThanOrEqualTest<int>(16, "\0", 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest592()
{
    this.RequireArgumentIsGreaterThanOrEqualTest<int>(0, "Ā", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTestThrowsArgumentOutOfRangeException117()
{
    this.RequireArgumentIsGreaterThanOrEqualTest<int>(0, "\t", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTestThrowsArgumentOutOfRangeException572()
{
    this.RequireArgumentIsGreaterThanOrEqualTest<int>(0, "\t\t", 0);
}
	}
}
