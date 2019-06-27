using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest18.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest18ThrowsArgumentNullException355()
{
	this.RequireArgumentIsLessThanOrEqualTest18
		(new float?((float)0), (string)null, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest18ThrowsArgumentOutOfRangeException274()
{
	this.RequireArgumentIsLessThanOrEqualTest18(new float?((float)0), "", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest18817()
{
	this.RequireArgumentIsLessThanOrEqualTest18
		(new float?((float)0), "\0", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest18875()
{
	this.RequireArgumentIsLessThanOrEqualTest18(default(float?), "\0", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest18ThrowsArgumentOutOfRangeException847()
{
	this.RequireArgumentIsLessThanOrEqualTest18
		(new float?((float)(-1)), "\0", (float)(-2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest18370()
{
	this.RequireArgumentIsLessThanOrEqualTest18(new float?((float)0), "Ā", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest18ThrowsArgumentOutOfRangeException571()
{
	this.RequireArgumentIsLessThanOrEqualTest18
		(new float?((float)0), "\t", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest18ThrowsArgumentOutOfRangeException600()
{
	this.RequireArgumentIsLessThanOrEqualTest18
		(new float?((float)0), "\t\t", (float)0);
}
	}
}
