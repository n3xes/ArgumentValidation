using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentNullException366()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>
        (0, (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException631()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(0, "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException356()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(0, "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest02524()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(4, "\0", new int?(1), 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException504()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(2, "\0", new int?(2), 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException56()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(0, "Ā", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest0224()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(4, "\0", default(int?), 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException49()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(0, "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest02ThrowsArgumentOutOfRangeException140()
{
    this.RequireArgumentIsBetweenExclusiveTest02<int>(0, "\t\0", new int?(1), 0);
}
	}
}
