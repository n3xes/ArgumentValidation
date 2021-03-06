using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanTest10.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest10ThrowsArgumentNullException645()
{
	this.RequireArgumentIsLessThanTest10
		(new decimal?(0e-4M), (string)null, default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest10ThrowsArgumentOutOfRangeException639()
{
	this.RequireArgumentIsLessThanTest10(new decimal?(0e-4M), "", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest10ThrowsArgumentOutOfRangeException94()
{
	this.RequireArgumentIsLessThanTest10
		(new decimal?(0e-4M), "\0", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanTest10875()
{
	this.RequireArgumentIsLessThanTest10(default(decimal?), "\0", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest10ThrowsArgumentOutOfRangeException101()
{
	this.RequireArgumentIsLessThanTest10(new decimal?(0e-4M), "䀀", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest10ThrowsArgumentOutOfRangeException834()
{
	this.RequireArgumentIsLessThanTest10
		(new decimal?(0e-4M), "\t", default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest10ThrowsArgumentOutOfRangeException654()
{
	this.RequireArgumentIsLessThanTest10
		(new decimal?(0e-4M), "\t\t", default(decimal));
}
	}
}
