using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest05.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsOutsideTest05ThrowsArgumentNullException807()
{
    this.RequireArgumentIsOutsideTest05<int>
        (default(int?), (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException672()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest05992()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest05503()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(0), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest05211()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(0), "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException571()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(1), "\0", 16, new int?(2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException481()
{
    this.RequireArgumentIsOutsideTest05<int>(new int?(512), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest05764()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "Ȁ", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest05ThrowsArgumentOutOfRangeException86()
{
    this.RequireArgumentIsOutsideTest05<int>(default(int?), "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest05229()
{
    this.RequireArgumentIsOutsideTest05<int>
        (default(int?), "\t\0", 1, default(int?));
}
	}
}
