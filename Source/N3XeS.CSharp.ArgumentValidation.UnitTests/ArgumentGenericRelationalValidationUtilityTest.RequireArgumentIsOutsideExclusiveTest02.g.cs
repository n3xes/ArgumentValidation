using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentNullException443()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>
        (0, (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException728()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(0, "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException913()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(0, "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest02524()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(4, "\0", new int?(1), 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException848()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(2, "\0", new int?(2), 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException731()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(0, "Ā", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest0224()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(4, "\0", default(int?), 513);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException491()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(0, "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest02ThrowsArgumentOutOfRangeException828()
{
    this.RequireArgumentIsOutsideExclusiveTest02<int>(0, "\t\0", new int?(1), 0);
}
	}
}
