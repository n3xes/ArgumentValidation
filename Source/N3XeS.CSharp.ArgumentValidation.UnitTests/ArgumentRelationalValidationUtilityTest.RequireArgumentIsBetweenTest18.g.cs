using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest18.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest18ThrowsArgumentNullException642()
{
	this.RequireArgumentIsBetweenTest18
		(default(decimal), (string)null, new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest18ThrowsArgumentOutOfRangeException237()
{
	this.RequireArgumentIsBetweenTest18
		(default(decimal), "", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest18493()
{
	this.RequireArgumentIsBetweenTest18
		(default(decimal), "\0", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest18460()
{
	this.RequireArgumentIsBetweenTest18
		(default(decimal), "\0", default(decimal?), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest18ThrowsArgumentOutOfRangeException978()
{
	this.RequireArgumentIsBetweenTest18
		(-76819052936496198642298613574e-19M, "\0", new decimal?(1M), 1965637706M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest1820()
{
	this.RequireArgumentIsBetweenTest18
		(default(decimal), "Ā", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest18ThrowsArgumentOutOfRangeException66()
{
	this.RequireArgumentIsBetweenTest18
		(decimal.MaxValue, "Ā", new decimal?(0e-4M), 2034639888M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest18ThrowsArgumentOutOfRangeException550()
{
	this.RequireArgumentIsBetweenTest18
		(default(decimal), "\t", new decimal?(0e-8M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest18943()
{
	this.RequireArgumentIsBetweenTest18
		(default(decimal), "\t\0", new decimal?(0e-4M), default(decimal));
}
	}
}
