using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsBetweenTest02ThrowsArgumentNullException57()
{
    this.RequireArgumentIsBetweenTest02<int>(0, (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException349()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException780()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest02519()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\0", default(int?), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException915()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "Ā", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException568()
{
    this.RequireArgumentIsBetweenTest02<int>(4, "Ā", new int?(1), 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException451()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest02ThrowsArgumentOutOfRangeException616()
{
    this.RequireArgumentIsBetweenTest02<int>(0, "\t\0", new int?(1), 0);
}
	}
}
