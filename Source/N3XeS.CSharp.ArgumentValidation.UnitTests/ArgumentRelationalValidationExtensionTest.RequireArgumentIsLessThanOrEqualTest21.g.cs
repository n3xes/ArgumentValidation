using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest21.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentNullException517()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, (string)null, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException911()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest21599()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\0", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException715()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\0", new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest2196()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "Ā", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException56()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\t", default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest21ThrowsArgumentOutOfRangeException364()
{
	this.RequireArgumentIsLessThanOrEqualTest21(1, "\n\t", default(int?));
}
	}
}
