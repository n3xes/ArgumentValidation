using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentNullException369()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>
        (1, (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException445()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>(1, "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException516()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>(1, "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException687()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>(1, "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest01815()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>(4, "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException15()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>(1, "Ā", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException93()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>(1, "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest01ThrowsArgumentOutOfRangeException872()
{
    this.RequireArgumentIsBetweenExclusiveTest01<int>(1, "\t\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTestThrowsArgumentNullException326()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(0, (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTestThrowsArgumentOutOfRangeException935()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(0, "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTestThrowsArgumentOutOfRangeException975()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(0, "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest219()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(4, "\0", 0, 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTestThrowsArgumentOutOfRangeException860()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(32, "\0", 544, 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTestThrowsArgumentOutOfRangeException461()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(0, "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTestThrowsArgumentOutOfRangeException371()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(0, "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTestThrowsArgumentOutOfRangeException596()
{
    this.RequireArgumentIsBetweenExclusiveTest<int>(0, "\t\0", 0, 0);
}
	}
}
