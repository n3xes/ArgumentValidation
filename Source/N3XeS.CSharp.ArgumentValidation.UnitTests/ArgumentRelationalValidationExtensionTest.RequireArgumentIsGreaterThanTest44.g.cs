using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest44.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanTest44ThrowsArgumentNullException610()
{
	this.RequireArgumentIsGreaterThanTest44((ushort)32, (string)null, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest44ThrowsArgumentOutOfRangeException809()
{
	this.RequireArgumentIsGreaterThanTest44((ushort)32, "", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest44ThrowsArgumentOutOfRangeException820()
{
	this.RequireArgumentIsGreaterThanTest44((ushort)32, "\0", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest44155()
{
	this.RequireArgumentIsGreaterThanTest44((ushort)33, "\0", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest44ThrowsArgumentOutOfRangeException814()
{
	this.RequireArgumentIsGreaterThanTest44((ushort)32, "Ā", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest44ThrowsArgumentOutOfRangeException915()
{
	this.RequireArgumentIsGreaterThanTest44((ushort)32, "\t", (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest44ThrowsArgumentOutOfRangeException36()
{
	this.RequireArgumentIsGreaterThanTest44((ushort)32, "\t\t", (ushort)32);
}
	}
}
