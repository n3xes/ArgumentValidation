using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest19.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest19ThrowsArgumentNullException287()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), (string)null, new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest19ThrowsArgumentOutOfRangeException833()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), "", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest19112()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), "\0", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest19505()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), "\0", new decimal?(0e-4M), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest19ThrowsArgumentOutOfRangeException545()
{
	this.RequireArgumentIsOutsideTest19(-76819052936496198642298613574e-19M, "\0", 
										new decimal?(1965637706M), new decimal?(1M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest19611()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), "Ā", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest19ThrowsArgumentOutOfRangeException491()
{
	this.RequireArgumentIsOutsideTest19
		(decimal.MaxValue, "Ā", new decimal?(2034639888M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest19ThrowsArgumentOutOfRangeException167()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), "\t", new decimal?(0e-4M), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest1955()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), "Ā", default(decimal?), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest19388()
{
	this.RequireArgumentIsOutsideTest19
		(default(decimal), "\t\0", new decimal?(0e-4M), new decimal?(0e-4M));
}
	}
}
