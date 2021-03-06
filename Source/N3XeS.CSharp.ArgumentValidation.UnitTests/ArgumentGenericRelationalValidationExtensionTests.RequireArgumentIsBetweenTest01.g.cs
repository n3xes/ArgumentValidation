using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest01.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenTest01ThrowsArgumentNullException102()
{
    this.RequireArgumentIsBetweenTest01<int>(1, (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException236()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest01277()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException486()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException836()
{
    this.RequireArgumentIsBetweenTest01<int>(4, "\0", 513, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest01879()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "Ā", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest01ThrowsArgumentOutOfRangeException259()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest01486()
{
    this.RequireArgumentIsBetweenTest01<int>(1, "\t\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTestThrowsArgumentNullException483()
{
    this.RequireArgumentIsBetweenTest<int>(0, (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException803()
{
    this.RequireArgumentIsBetweenTest<int>(0, "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest329()
{
    this.RequireArgumentIsBetweenTest<int>(0, "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException626()
{
    this.RequireArgumentIsBetweenTest<int>(4, "\0", 0, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException938()
{
    this.RequireArgumentIsBetweenTest<int>(256, "\0", 512, 256);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest81()
{
    this.RequireArgumentIsBetweenTest<int>(0, "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTestThrowsArgumentOutOfRangeException462()
{
    this.RequireArgumentIsBetweenTest<int>(0, "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest826()
{
    this.RequireArgumentIsBetweenTest<int>(0, "\t\0", 0, 0);
}
	}
}
