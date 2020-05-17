using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest04.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentNullException864()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>
        (new int?(64), (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException462()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>(new int?(1), "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException971()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>(new int?(1), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest04367()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>(default(int?), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException34()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>(new int?(0), "\0", 0, 512);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException675()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>(new int?(1), "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException39()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>(new int?(1), "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest04ThrowsArgumentOutOfRangeException884()
{
    this.RequireArgumentIsOutsideExclusiveTest04<int>(new int?(1), "\t\0", 0, 0);
}
	}
}
