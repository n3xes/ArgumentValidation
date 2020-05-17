using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest60.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest60ThrowsArgumentNullException785()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)1), (string)null, (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest60ThrowsArgumentOutOfRangeException465()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)1), "", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest60ThrowsArgumentOutOfRangeException289()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)1), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest60511()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(default(sbyte?), "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest6034()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)2), "\0", (sbyte)0, (sbyte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest60ThrowsArgumentOutOfRangeException800()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)0), "\0", (sbyte)0, (sbyte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest60ThrowsArgumentOutOfRangeException947()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)1), "Ā", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest60ThrowsArgumentOutOfRangeException72()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)1), "\t", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest60ThrowsArgumentOutOfRangeException275()
{
	this.RequireArgumentIsBetweenExclusiveTest60
		(new sbyte?((sbyte)1), "\t\0", (sbyte)0, (sbyte)0);
}
	}
}
