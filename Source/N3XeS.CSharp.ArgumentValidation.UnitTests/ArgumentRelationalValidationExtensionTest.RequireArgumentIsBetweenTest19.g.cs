using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest19.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest19ThrowsArgumentNullException488()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), (string)null, new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest19ThrowsArgumentOutOfRangeException630()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), "", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest19112()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), "\0", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest19387()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), "\0", default(decimal?), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest19ThrowsArgumentOutOfRangeException432()
{
	this.RequireArgumentIsBetweenTest19(-76819052936496198642298613574e-19M, "\0", 
										new decimal?(1M), new decimal?(1965637706M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest19611()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), "Ā", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest19ThrowsArgumentOutOfRangeException934()
{
	this.RequireArgumentIsBetweenTest19
		(decimal.MaxValue, "Ā", new decimal?(0e-4M), new decimal?(2034639888M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest19ThrowsArgumentOutOfRangeException569()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), "\t", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest19852()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), "Ā", new decimal?(0e-4M), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest19388()
{
	this.RequireArgumentIsBetweenTest19
		(default(decimal), "\t\0", new decimal?(0e-4M), new decimal?(0e-4M));
}
	}
}
