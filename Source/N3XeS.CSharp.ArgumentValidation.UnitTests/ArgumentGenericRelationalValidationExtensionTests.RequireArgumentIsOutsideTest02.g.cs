using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireArgumentIsOutsideTest02ThrowsArgumentNullException783()
{
    this.RequireArgumentIsOutsideTest02<int>(0, (string)null, new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException805()
{
    this.RequireArgumentIsOutsideTest02<int>(0, "", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest02211()
{
    this.RequireArgumentIsOutsideTest02<int>(0, "\0", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException811()
{
    this.RequireArgumentIsOutsideTest02<int>(4, "\0", new int?(0), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException261()
{
    this.RequireArgumentIsOutsideTest02<int>(0, "\0", new int?(1), 512);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest02350()
{
    this.RequireArgumentIsOutsideTest02<int>(0, "Ā", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest02106()
{
    this.RequireArgumentIsOutsideTest02<int>(0, "Ā", default(int?), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest02ThrowsArgumentOutOfRangeException751()
{
    this.RequireArgumentIsOutsideTest02<int>(0, "\t", new int?(1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentGenericRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest0229()
{
    this.RequireArgumentIsOutsideTest02<int>(0, "\t\0", new int?(1), 0);
}
	}
}
