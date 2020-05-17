using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentNullException741()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, (string)null, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException823()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest17563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "\0", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest17120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17((float)0, "\0", default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException757()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)(-2), "\0", new float?((float)(-1)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest1734()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "Ā", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException541()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "\t", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest17ThrowsArgumentOutOfRangeException390()
{
	this.RequireArgumentIsGreaterThanOrEqualTest17
		((float)0, "\t\t", new float?((float)0));
}
	}
}
