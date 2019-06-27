using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest18.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest18ThrowsArgumentNullException81()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(default(decimal), (string)null, new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest18ThrowsArgumentOutOfRangeException256()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(default(decimal), "", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest18ThrowsArgumentOutOfRangeException433()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(default(decimal), "\0", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest18ThrowsArgumentOutOfRangeException717()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(-76819052936496198642298613574e-19M, "\0", new decimal?(0e-4M), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest18183()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(177519435M, "\0", new decimal?(1e-1M), 47783165704927611543839379711e-17M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest18ThrowsArgumentOutOfRangeException299()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(default(decimal), "Ā", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest18342()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(-76819052936496198642298613574e-19M, "\0", default(decimal?), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest18ThrowsArgumentOutOfRangeException449()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(default(decimal), "\t", new decimal?(0e-8M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest18ThrowsArgumentOutOfRangeException979()
{
	this.RequireArgumentIsOutsideExclusiveTest18
		(default(decimal), "\t\0", new decimal?(0e-4M), default(decimal));
}
	}
}
