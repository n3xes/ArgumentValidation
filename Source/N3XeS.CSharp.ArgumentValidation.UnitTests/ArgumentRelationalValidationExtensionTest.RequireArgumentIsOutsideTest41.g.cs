using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest41.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest41ThrowsArgumentNullException682()
{
	this.RequireArgumentIsOutsideTest41(1, (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest41ThrowsArgumentOutOfRangeException580()
{
	this.RequireArgumentIsOutsideTest41(1, "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest41642()
{
	this.RequireArgumentIsOutsideTest41(1, "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest41ThrowsArgumentOutOfRangeException384()
{
	this.RequireArgumentIsOutsideTest41(3, "\0", 2, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest41806()
{
	this.RequireArgumentIsOutsideTest41(1, "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest41ThrowsArgumentOutOfRangeException281()
{
	this.RequireArgumentIsOutsideTest41(0, "\0", 2, new int?(3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest41314()
{
	this.RequireArgumentIsOutsideTest41(1, "Ā", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest41ThrowsArgumentOutOfRangeException459()
{
	this.RequireArgumentIsOutsideTest41(1, "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest41426()
{
	this.RequireArgumentIsOutsideTest41(1, "\t\0", 1, default(int?));
}
	}
}
