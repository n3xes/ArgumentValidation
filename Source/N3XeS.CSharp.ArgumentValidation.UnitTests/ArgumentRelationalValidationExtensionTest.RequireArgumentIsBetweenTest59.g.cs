using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest59.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest59ThrowsArgumentNullException769()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, (string)null, new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest59ThrowsArgumentOutOfRangeException25()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, "", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest59ThrowsArgumentOutOfRangeException547()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, "\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest598()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, "\0", default(sbyte?), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest59ThrowsArgumentOutOfRangeException854()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, "Ā", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest59ThrowsArgumentOutOfRangeException633()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)3, "Ā", new sbyte?((sbyte)1), new sbyte?((sbyte)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest59ThrowsArgumentOutOfRangeException421()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, "\t", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest59ThrowsArgumentOutOfRangeException357()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, "Ā", new sbyte?((sbyte)1), default(sbyte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest59ThrowsArgumentOutOfRangeException667()
{
	this.RequireArgumentIsBetweenTest59
		((sbyte)0, "\t\0", new sbyte?((sbyte)1), new sbyte?((sbyte)1));
}
	}
}
