using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest30.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest30ThrowsArgumentNullException524()
{
	this.RequireArgumentIsLessThanTest30
		(new sbyte?((sbyte)1), (string)null, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest30ThrowsArgumentOutOfRangeException230()
{
	this.RequireArgumentIsLessThanTest30(new sbyte?((sbyte)1), "", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest30ThrowsArgumentOutOfRangeException465()
{
	this.RequireArgumentIsLessThanTest30(new sbyte?((sbyte)1), "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanTest30904()
{
	this.RequireArgumentIsLessThanTest30(default(sbyte?), "\0", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest30ThrowsArgumentOutOfRangeException987()
{
	this.RequireArgumentIsLessThanTest30(new sbyte?((sbyte)1), "Ā", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest30ThrowsArgumentOutOfRangeException949()
{
	this.RequireArgumentIsLessThanTest30(new sbyte?((sbyte)1), "\t", (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest30ThrowsArgumentOutOfRangeException109()
{
	this.RequireArgumentIsLessThanTest30(new sbyte?((sbyte)1), "\t\t", (sbyte)0);
}
	}
}
