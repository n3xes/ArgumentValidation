using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentNullException915()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), (string)null, default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException212()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest08817()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "\0", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException605()
{
	this.RequireArgumentIsLessThanOrEqualTest08(decimal.MaxValue, "\0", 2034639888M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest08370()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "Ā", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException594()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "\t", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest08ThrowsArgumentOutOfRangeException512()
{
	this.RequireArgumentIsLessThanOrEqualTest08
		(default(decimal), "\t\t", default(decimal));
}
	}
}
