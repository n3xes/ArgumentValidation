using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest61.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest61ThrowsArgumentNullException960()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)1), (string)null, (sbyte)0, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest61ThrowsArgumentOutOfRangeException628()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)1), "", (sbyte)0, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest61ThrowsArgumentOutOfRangeException532()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)1), "\0", (sbyte)0, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest61132()
{
	this.RequireArgumentIsOutsideTest61
		(default(sbyte?), "\0", (sbyte)0, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest61578()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)1), "\0", (sbyte)64, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest61ThrowsArgumentOutOfRangeException172()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)(-127)), "\0", (sbyte)0, new sbyte?((sbyte)(-126)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest61ThrowsArgumentOutOfRangeException422()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)1), "Ā", (sbyte)0, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest61ThrowsArgumentOutOfRangeException574()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)1), "\t", (sbyte)0, new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest61ThrowsArgumentOutOfRangeException666()
{
	this.RequireArgumentIsOutsideTest61
		(new sbyte?((sbyte)1), "\t\0", (sbyte)0, new sbyte?((sbyte)1));
}
	}
}
