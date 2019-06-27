using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest20.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest20ThrowsArgumentNullException164()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(0e-4M), (string)null, default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest20ThrowsArgumentOutOfRangeException46()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(0e-4M), "", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest20500()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(0e-4M), "\0", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest20ThrowsArgumentOutOfRangeException699()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(decimal.MaxValue), "\0", default(decimal), 2034639888M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest20ThrowsArgumentOutOfRangeException215()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(0e-4M), "\0", 2251799813685248M, default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest2078()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(0e-4M), "Ā", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest20856()
{
	this.RequireArgumentIsBetweenTest20
		(default(decimal?), "Ā", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest20ThrowsArgumentOutOfRangeException390()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(0e-4M), "\t", default(decimal), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest20309()
{
	this.RequireArgumentIsBetweenTest20
		(new decimal?(0e-4M), "\t\0", default(decimal), default(decimal));
}
	}
}
