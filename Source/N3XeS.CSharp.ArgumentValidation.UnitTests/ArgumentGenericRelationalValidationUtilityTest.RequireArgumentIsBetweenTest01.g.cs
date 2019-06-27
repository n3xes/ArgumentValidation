using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentGenericRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentNullException8()
{
    this.RequireArgumentIsBetweenTest01<int>(1, (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException521()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest01748()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException235()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException70()
{
    this.RequireArgumentIsBetweenTest01<int>(4, "\0", 513, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest01261()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "Ā", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException117()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest01394()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\t\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTestThrowsArgumentNullException624()
{
    this.RequireArgumentIsBetweenTest<int>(0, (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException163()
{
    this.RequireArgumentIsBetweenTest<int>(0, "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest818()
{
    this.RequireArgumentIsBetweenTest<int>(0, "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException825()
{
    this.RequireArgumentIsBetweenTest<int>(4, "\0", 0, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException311()
{
    this.RequireArgumentIsBetweenTest<int>(256, "\0", 512, 256);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest191()
{
    this.RequireArgumentIsBetweenTest<int>(0, "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException570()
{
    this.RequireArgumentIsBetweenTest<int>(0, "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest272()
{
    this.RequireArgumentIsBetweenTest<int>(0, "\t\0", 0, 0);
}
	}
}
