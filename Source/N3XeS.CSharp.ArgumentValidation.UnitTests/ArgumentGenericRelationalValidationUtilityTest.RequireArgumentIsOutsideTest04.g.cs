using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest04.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsOutsideTest04ThrowsArgumentNullException423()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(64), (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest04ThrowsArgumentOutOfRangeException859()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(1), "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest04ThrowsArgumentOutOfRangeException975()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(1), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest04996()
{
    this.RequireArgumentIsOutsideTest04<int>(default(int?), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest04639()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(0), "\0", 1, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest04ThrowsArgumentOutOfRangeException317()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(386), "\0", 386, 520);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest04ThrowsArgumentOutOfRangeException844()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(1), "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest04ThrowsArgumentOutOfRangeException823()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(1), "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest04ThrowsArgumentOutOfRangeException467()
{
    this.RequireArgumentIsOutsideTest04<int>(new int?(1), "\t\0", 0, 0);
}
	}
}
