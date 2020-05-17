using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest04.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenTest04ThrowsArgumentNullException517()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(64), (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException816()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(1), "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException387()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(1), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest04367()
{
    this.RequireArgumentIsBetweenTest04<int>(default(int?), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest04815()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(0), "\0", 0, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException614()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(0), "\0", 4, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException336()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(1), "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException435()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(1), "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest04ThrowsArgumentOutOfRangeException929()
{
    this.RequireArgumentIsBetweenTest04<int>(new int?(1), "\t\0", 0, 0);
}
	}
}
