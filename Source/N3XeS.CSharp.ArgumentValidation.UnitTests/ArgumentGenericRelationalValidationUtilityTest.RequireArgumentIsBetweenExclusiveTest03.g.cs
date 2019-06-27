using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentNullException712()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, (string)null, default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException597()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest03494()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException667()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest03249()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\0", new int?(0), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException753()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (16, "\0", new int?(513), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest03833()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "Ā", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException413()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\t", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest03442()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (1, "\t\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest03ThrowsArgumentOutOfRangeException480()
{
    this.RequireArgumentIsBetweenExclusiveTest03<int>
        (129, "\t\t", new int?(536), new int?(514));
}
	}
}
