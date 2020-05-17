using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest06.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsOutsideTest06ThrowsArgumentNullException477()
{
    this.RequireArgumentIsOutsideTest06<int>
        (new int?(512), (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest06ThrowsArgumentOutOfRangeException603()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(1), "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest06441()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(1), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest06ThrowsArgumentOutOfRangeException491()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(1), "\0", new int?(0), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest06ThrowsArgumentOutOfRangeException486()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(1), "\0", new int?(512), 4);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest06ThrowsArgumentOutOfRangeException475()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(2), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest06673()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(2), "耀", default(int?), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest06ThrowsArgumentOutOfRangeException600()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(1), "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest06258()
{
    this.RequireArgumentIsOutsideTest06<int>(default(int?), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest06794()
{
    this.RequireArgumentIsOutsideTest06<int>(new int?(1), "\t\0", new int?(1), 0);
}
	}
}
