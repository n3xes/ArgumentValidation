using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsLessThanOrEqualTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentNullException669()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>
        (default(int?), (string)null, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException595()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>
        (default(int?), "", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest03308()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>
        (default(int?), "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest0345()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>
        (new int?(0), "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest03625()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>(new int?(0), "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException177()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>(new int?(1), "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException41()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>
        (default(int?), "\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanOrEqualTest03887()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>
        (default(int?), "Ā", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException467()
{
    this.RequireArgumentIsLessThanOrEqualTest03<int>
        (default(int?), "\t\t", default(int?));
}
	}
}
