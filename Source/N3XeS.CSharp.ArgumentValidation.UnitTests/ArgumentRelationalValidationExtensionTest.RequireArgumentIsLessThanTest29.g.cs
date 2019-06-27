using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest29.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest29ThrowsArgumentNullException236()
{
	this.RequireArgumentIsLessThanTest29
		((sbyte)0, (string)null, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest29ThrowsArgumentOutOfRangeException3()
{
	this.RequireArgumentIsLessThanTest29((sbyte)0, "", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanTest29843()
{
	this.RequireArgumentIsLessThanTest29((sbyte)0, "\0", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanTest29359()
{
	this.RequireArgumentIsLessThanTest29((sbyte)0, "\0", default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest29ThrowsArgumentOutOfRangeException367()
{
	this.RequireArgumentIsLessThanTest29((sbyte)0, "\0", new sbyte?((sbyte)(-127)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanTest29801()
{
	this.RequireArgumentIsLessThanTest29((sbyte)0, "Ā", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest29ThrowsArgumentOutOfRangeException329()
{
	this.RequireArgumentIsLessThanTest29((sbyte)0, "\t", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest29ThrowsArgumentOutOfRangeException474()
{
	this.RequireArgumentIsLessThanTest29((sbyte)0, "\t\t", new sbyte?((sbyte)1));
}
	}
}
