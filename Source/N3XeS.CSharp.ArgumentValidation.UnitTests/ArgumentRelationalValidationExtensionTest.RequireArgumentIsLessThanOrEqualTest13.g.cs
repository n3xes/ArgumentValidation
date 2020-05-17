using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest13.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest13ThrowsArgumentNullException84()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, (string)null, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest13ThrowsArgumentOutOfRangeException517()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, "", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest13817()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, "\0", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest1329()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, "\0", default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest13ThrowsArgumentOutOfRangeException405()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, "\0", new double?(-1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest13370()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, "Ā", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest13ThrowsArgumentOutOfRangeException51701()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, "\t", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest13ThrowsArgumentOutOfRangeException497()
{
	this.RequireArgumentIsLessThanOrEqualTest13(0, "\t\t", new double?(0));
}
	}
}
