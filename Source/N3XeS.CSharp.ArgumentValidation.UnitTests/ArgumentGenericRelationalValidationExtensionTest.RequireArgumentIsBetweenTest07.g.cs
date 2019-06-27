using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest07.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentGenericRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentNullException360()
{
    this.RequireArgumentIsBetweenTest07<int>
        (default(int?), (string)null, default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException110()
{
    this.RequireArgumentIsBetweenTest07<int>
        (default(int?), "", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07322()
{
    this.RequireArgumentIsBetweenTest07<int>
        (default(int?), "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07883()
{
    this.RequireArgumentIsBetweenTest07<int>
        (new int?(0), "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07293()
{
    this.RequireArgumentIsBetweenTest07<int>
        (new int?(0), "\0", new int?(0), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException267()
{
    this.RequireArgumentIsBetweenTest07<int>
        (new int?(1), "\0", new int?(24), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07519()
{
    this.RequireArgumentIsBetweenTest07<int>
        (new int?(0), "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07690()
{
    this.RequireArgumentIsBetweenTest07<int>
        (default(int?), "Ā", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException621()
{
    this.RequireArgumentIsBetweenTest07<int>
        (new int?(256), "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException408()
{
    this.RequireArgumentIsBetweenTest07<int>
        (default(int?), "\t", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07707()
{
    this.RequireArgumentIsBetweenTest07<int>
        (default(int?), "\t\0", default(int?), default(int?));
}
	}
}
