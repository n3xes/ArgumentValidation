using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest62.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest62ThrowsArgumentNullException16()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)1), (string)null, new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest62ThrowsArgumentOutOfRangeException608()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)1), "", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest62ThrowsArgumentOutOfRangeException521()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest62373()
{
	this.RequireArgumentIsBetweenTest62
		(default(sbyte?), "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest62221()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)1), "\0", new sbyte?((sbyte)1), (sbyte)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest62ThrowsArgumentOutOfRangeException929()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)(-127)), "\0", new sbyte?((sbyte)(-126)), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest62ThrowsArgumentOutOfRangeException891()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)1), "Ā", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest62ThrowsArgumentOutOfRangeException273()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)1), "\t", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest62ThrowsArgumentOutOfRangeException373()
{
	this.RequireArgumentIsBetweenTest62
		(new sbyte?((sbyte)1), "\t\0", new sbyte?((sbyte)1), (sbyte)0);
}
	}
}
