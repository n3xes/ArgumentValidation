using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest63.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentNullException403()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), (string)null, 
		 new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException638()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException120()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException570()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest63451()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)2), "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest6352()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\0", default(sbyte?), default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException924()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\t", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest63930()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(default(sbyte?), "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException575()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "Ā", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest63ThrowsArgumentOutOfRangeException776()
{
	this.RequireArgumentIsBetweenExclusiveTest63
		(new sbyte?((sbyte)1), "\t\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}
	}
}
