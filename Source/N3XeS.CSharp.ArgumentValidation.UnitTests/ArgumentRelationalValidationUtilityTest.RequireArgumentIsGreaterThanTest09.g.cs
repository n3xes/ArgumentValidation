using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest09.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsGreaterThanTest09ThrowsArgumentNullException414()
{
	this.RequireArgumentIsGreaterThanTest09
		(default(decimal), (string)null, new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest09ThrowsArgumentOutOfRangeException152()
{
	this.RequireArgumentIsGreaterThanTest09
		(default(decimal), "", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest09ThrowsArgumentOutOfRangeException837()
{
	this.RequireArgumentIsGreaterThanTest09
		(default(decimal), "\0", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanTest09120()
{
	this.RequireArgumentIsGreaterThanTest09
		(default(decimal), "\0", default(decimal?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest09ThrowsArgumentOutOfRangeException744()
{
	this.RequireArgumentIsGreaterThanTest09
		(default(decimal), "Ā", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest09ThrowsArgumentOutOfRangeException503()
{
	this.RequireArgumentIsGreaterThanTest09
		(default(decimal), "\t", new decimal?(0e-4M));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest09ThrowsArgumentOutOfRangeException155()
{
	this.RequireArgumentIsGreaterThanTest09
		(default(decimal), "\t\t", new decimal?(0e-4M));
}
	}
}
