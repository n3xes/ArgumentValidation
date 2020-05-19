using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest60.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest60ThrowsArgumentNullException299()
{
	this.RequireArgumentIsOutsideTest60
		(new sbyte?((sbyte)1), (string)null, (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest60ThrowsArgumentOutOfRangeException()
{
	this.RequireArgumentIsOutsideTest60
		(new sbyte?((sbyte)1), "", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest60ThrowsArgumentOutOfRangeException731()
{
	this.RequireArgumentIsOutsideTest60
		(new sbyte?((sbyte)1), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest60511()
{
	this.RequireArgumentIsOutsideTest60(default(sbyte?), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest60ThrowsArgumentOutOfRangeException189()
{
	this.RequireArgumentIsOutsideTest60
		(new sbyte?((sbyte)(-127)), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest60ThrowsArgumentOutOfRangeException213()
{
	this.RequireArgumentIsOutsideTest60
		(new sbyte?((sbyte)1), "Ā", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest60ThrowsArgumentOutOfRangeException99()
{
	this.RequireArgumentIsOutsideTest60
		(new sbyte?((sbyte)1), "\t", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest60ThrowsArgumentOutOfRangeException476()
{
	this.RequireArgumentIsOutsideTest60
		(new sbyte?((sbyte)1), "\t\0", (sbyte)0, (sbyte)0);
}
	}
}
