using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest31.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest31ThrowsArgumentNullException78()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)1), (string)null, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest31ThrowsArgumentOutOfRangeException829()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)1), "", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest3197()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest31783()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)1), "\0", default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest31ThrowsArgumentOutOfRangeException600()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)2), "\0", new sbyte?((sbyte)3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest3181()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)1), "Ā", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest31998()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(default(sbyte?), "Ā", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest31ThrowsArgumentOutOfRangeException461()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)1), "\t", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest31ThrowsArgumentOutOfRangeException418()
{
	this.RequireArgumentIsGreaterThanOrEqualTest31
		(new sbyte?((sbyte)1), "\t\t", new sbyte?((sbyte)1));
}
	}
}
