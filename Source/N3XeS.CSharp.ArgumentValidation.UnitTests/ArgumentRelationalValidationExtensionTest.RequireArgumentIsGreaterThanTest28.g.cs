using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest28.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest28ThrowsArgumentNullException565()
{
	this.RequireArgumentIsGreaterThanTest28((sbyte)0, (string)null, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest28ThrowsArgumentOutOfRangeException482()
{
	this.RequireArgumentIsGreaterThanTest28((sbyte)0, "", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest28ThrowsArgumentOutOfRangeException892()
{
	this.RequireArgumentIsGreaterThanTest28((sbyte)0, "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest28411()
{
	this.RequireArgumentIsGreaterThanTest28((sbyte)1, "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest28ThrowsArgumentOutOfRangeException103()
{
	this.RequireArgumentIsGreaterThanTest28((sbyte)0, "Ā", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest28ThrowsArgumentOutOfRangeException762()
{
	this.RequireArgumentIsGreaterThanTest28((sbyte)0, "\t", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest28ThrowsArgumentOutOfRangeException726()
{
	this.RequireArgumentIsGreaterThanTest28((sbyte)0, "\t\t", (sbyte)0);
}
	}
}
