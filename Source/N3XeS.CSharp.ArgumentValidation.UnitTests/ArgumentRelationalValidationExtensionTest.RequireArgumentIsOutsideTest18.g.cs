using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest18.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest18ThrowsArgumentNullException194()
{
	this.RequireArgumentIsOutsideTest18
		(default(decimal), (string)null, new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest18ThrowsArgumentOutOfRangeException583()
{
	this.RequireArgumentIsOutsideTest18
		(default(decimal), "", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest18493()
{
	this.RequireArgumentIsOutsideTest18
		(default(decimal), "\0", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest18ThrowsArgumentOutOfRangeException489()
{
	this.RequireArgumentIsOutsideTest18
		(decimal.MaxValue, "\0", new decimal?(2034639888M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest18ThrowsArgumentOutOfRangeException95()
{
	this.RequireArgumentIsOutsideTest18
		(-76819052936496198642298613574e-19M, "\0", new decimal?(1965637706M), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest1820()
{
	this.RequireArgumentIsOutsideTest18
		(default(decimal), "Ā", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest18960()
{
	this.RequireArgumentIsOutsideTest18
		(default(decimal), "Ā", default(decimal?), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest18ThrowsArgumentOutOfRangeException768()
{
	this.RequireArgumentIsOutsideTest18
		(default(decimal), "\t", new decimal?(0e-8M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest18943()
{
	this.RequireArgumentIsOutsideTest18
		(default(decimal), "\t\0", new decimal?(0e-4M), default(decimal));
}
	}
}
