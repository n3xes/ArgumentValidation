using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest06.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentNullException999()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (new int?(512), (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException826()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (new int?(1), "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException302()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (new int?(1), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest06731()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (default(int?), "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException917()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (new int?(0), "\0", new int?(1), 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException644()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (new int?(2), "耀", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException551()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (new int?(1), "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest06ThrowsArgumentOutOfRangeException649()
{
    this.RequireArgumentIsBetweenExclusiveTest06<int>
        (new int?(1), "\t\0", new int?(1), 0);
}
	}
}
