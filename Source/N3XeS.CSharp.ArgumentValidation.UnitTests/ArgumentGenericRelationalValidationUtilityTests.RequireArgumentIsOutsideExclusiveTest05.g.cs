using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsOutsideExclusiveTest05.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class ArgumentGenericRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentNullException404()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (default(int?), (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException858()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (default(int?), "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest05551()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (default(int?), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException614()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (new int?(0), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest05786()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (default(int?), "Ȁ", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException117()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (new int?(0), "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException269()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (default(int?), "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideExclusiveTest05817()
{
    this.RequireArgumentIsOutsideExclusiveTest05<int>
        (default(int?), "\t\0", 1, default(int?));
}
	}
}
