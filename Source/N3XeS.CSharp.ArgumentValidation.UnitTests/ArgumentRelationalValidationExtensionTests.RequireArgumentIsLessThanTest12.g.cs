using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanTest12.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsLessThanTest12ThrowsArgumentNullException711()
{
	this.RequireArgumentIsLessThanTest12(0, (string)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest12ThrowsArgumentOutOfRangeException446()
{
	this.RequireArgumentIsLessThanTest12(0, "", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest12ThrowsArgumentOutOfRangeException175()
{
	this.RequireArgumentIsLessThanTest12(0, "\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanTest12511()
{
	this.RequireArgumentIsLessThanTest12(0, "\0", 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest12ThrowsArgumentOutOfRangeException605()
{
	this.RequireArgumentIsLessThanTest12(0, "Ā", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest12ThrowsArgumentOutOfRangeException79()
{
	this.RequireArgumentIsLessThanTest12(0, "\t", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest12ThrowsArgumentOutOfRangeException680()
{
	this.RequireArgumentIsLessThanTest12(0, "\t\t", 0);
}
	}
}
