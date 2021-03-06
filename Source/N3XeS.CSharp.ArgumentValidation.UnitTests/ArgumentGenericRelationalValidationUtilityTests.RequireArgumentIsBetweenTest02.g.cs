using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationUtilityTests.RequireArgumentIsBetweenTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenTest02ThrowsArgumentNullException961()
{
    this.RequireArgumentIsBetweenTest02<int>(0, (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException919()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException479()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest02575()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\0", default(int?), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException820()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "Ā", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException642()
{
    this.RequireArgumentIsBetweenTest02<int>(4, "Ā", new int?(1), 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException91()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException63()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\t\0", new int?(1), 0);
}
	}
}
