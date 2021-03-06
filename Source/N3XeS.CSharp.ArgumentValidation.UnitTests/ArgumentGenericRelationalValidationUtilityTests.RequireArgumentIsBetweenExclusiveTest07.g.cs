using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest07.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentNullException678()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (default(int?), (string)null, default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException690()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (default(int?), "", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest07794()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (default(int?), "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest07587()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (new int?(0), "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException245()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (new int?(0), "\0", new int?(0), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException242()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (new int?(0), "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest07100()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (default(int?), "Ā", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest07ThrowsArgumentOutOfRangeException932()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (default(int?), "\t", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest07666()
{
    this.RequireArgumentIsBetweenExclusiveTest07<int>
        (default(int?), "\t\0", default(int?), default(int?));
}
	}
}
