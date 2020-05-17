using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest58.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest58ThrowsArgumentNullException308()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, (string)null, new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException712()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException607()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "\0", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest58723()
{
	this.RequireArgumentIsBetweenTest58((sbyte)0, "\0", default(sbyte?), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException724()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "Ā", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException288()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)1, "Ā", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException747()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "\t", new sbyte?((sbyte)1), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest58ThrowsArgumentOutOfRangeException791()
{
	this.RequireArgumentIsBetweenTest58
		((sbyte)0, "\t\0", new sbyte?((sbyte)1), (sbyte)0);
}
	}
}
