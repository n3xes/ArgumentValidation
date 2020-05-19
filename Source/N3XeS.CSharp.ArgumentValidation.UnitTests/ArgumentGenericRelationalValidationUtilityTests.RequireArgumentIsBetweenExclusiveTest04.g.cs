using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest04.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentNullException942()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>
        (new int?(64), (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException72()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>(new int?(1), "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException232()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>(new int?(1), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest04996()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>(default(int?), "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException221()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>(new int?(0), "\0", 0, 512);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException765()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>(new int?(1), "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException503()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>(new int?(1), "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest04ThrowsArgumentOutOfRangeException177()
{
    this.RequireArgumentIsBetweenExclusiveTest04<int>(new int?(1), "\t\0", 0, 0);
}
	}
}
