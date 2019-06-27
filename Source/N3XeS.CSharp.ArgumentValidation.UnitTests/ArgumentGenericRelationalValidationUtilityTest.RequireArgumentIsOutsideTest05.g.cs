using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideTest05.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsOutsideTest05ThrowsArgumentNullException514()
{
    this.RequireArgumentIsOutsideTest05<int>
        (default(int?), (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException663()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest05551()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest05245()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(0), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest05639()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(0), "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException414()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(1), "\0", 16, new int?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException98()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(512), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest05786()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "Ȁ", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException474()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest05817()
{
    this.RequireArgumentIsOutsideTest05<int>
        (default(int?), "\t\0", 1, default(int?));
}
	}
}
