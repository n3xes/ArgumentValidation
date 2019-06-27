using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest17ThrowsArgumentNullException636()
{
	this.RequireArgumentIsBetweenTest17
		(default(decimal), (string)null, default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest17ThrowsArgumentOutOfRangeException429()
{
	this.RequireArgumentIsBetweenTest17
		(default(decimal), "", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest17753()
{
	this.RequireArgumentIsBetweenTest17
		(default(decimal), "\0", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest17ThrowsArgumentOutOfRangeException678()
{
	this.RequireArgumentIsBetweenTest17
		(decimal.MaxValue, "\0", default(decimal), new decimal?(2034639888M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest17ThrowsArgumentOutOfRangeException40()
{
	this.RequireArgumentIsBetweenTest17
		(-76819052936496198642298613574e-19M, "\0", 1M, new decimal?(1965637706M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest17206()
{
	this.RequireArgumentIsBetweenTest17
		(default(decimal), "Ā", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest17697()
{
	this.RequireArgumentIsBetweenTest17
		(default(decimal), "Ā", default(decimal), default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest17ThrowsArgumentOutOfRangeException218()
{
	this.RequireArgumentIsBetweenTest17
		(default(decimal), "\t", default(decimal), new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest17632()
{
	this.RequireArgumentIsBetweenTest17
		(default(decimal), "\t\0", default(decimal), new decimal?(0e-4M));
}
	}
}
