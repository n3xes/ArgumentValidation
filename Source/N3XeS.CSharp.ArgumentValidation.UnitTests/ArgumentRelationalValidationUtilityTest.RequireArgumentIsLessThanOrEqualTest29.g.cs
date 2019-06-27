using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest29.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsLessThanOrEqualTest29ThrowsArgumentNullException377()
{
	this.RequireArgumentIsLessThanOrEqualTest29
		((sbyte)0, (string)null, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest29ThrowsArgumentOutOfRangeException671()
{
	this.RequireArgumentIsLessThanOrEqualTest29((sbyte)0, "", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest29843()
{
	this.RequireArgumentIsLessThanOrEqualTest29
		((sbyte)0, "\0", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest29359()
{
	this.RequireArgumentIsLessThanOrEqualTest29((sbyte)0, "\0", default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest29ThrowsArgumentOutOfRangeException192()
{
	this.RequireArgumentIsLessThanOrEqualTest29
		((sbyte)3, "\0", new sbyte?((sbyte)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest29801()
{
	this.RequireArgumentIsLessThanOrEqualTest29((sbyte)0, "Ā", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest29ThrowsArgumentOutOfRangeException540()
{
	this.RequireArgumentIsLessThanOrEqualTest29
		((sbyte)0, "\t", new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest29ThrowsArgumentOutOfRangeException548()
{
	this.RequireArgumentIsLessThanOrEqualTest29
		((sbyte)0, "\t\t", new sbyte?((sbyte)1));
}
	}
}
