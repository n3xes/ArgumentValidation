using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest11.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest11ThrowsArgumentNullException574()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(1152921504606846976M), (string)null, new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest11ThrowsArgumentOutOfRangeException308()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(1152921504606846976M), "", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest11518()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(134217728M), "\0", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest11497()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(134217728M), "\0", default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest11ThrowsArgumentOutOfRangeException944()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(0M), "\0", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest11744()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(32768M), "Ā", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest11671()
{
	this.RequireArgumentIsGreaterThanTest11
		(default(decimal?), "Ā", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest11ThrowsArgumentOutOfRangeException282()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(19342813113834066795298816M), "\t", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest11ThrowsArgumentOutOfRangeException157()
{
	this.RequireArgumentIsGreaterThanTest11
		(new decimal?(0e-8M), "\n\t", new decimal?(0e-4M));
}
	}
}
