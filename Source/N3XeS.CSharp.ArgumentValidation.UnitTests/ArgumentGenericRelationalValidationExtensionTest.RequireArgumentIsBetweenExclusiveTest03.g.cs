using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentNullException511()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, (string)null, default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException595()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest03698()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException56()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest03122()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\0", new int?(0), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException323()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (16, "\0", new int?(513), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest0338()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "Ā", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException717()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\t", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest03761()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\t\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException520()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (129, "\t\t", new int?(536), new int?(514));
}
	}
}
