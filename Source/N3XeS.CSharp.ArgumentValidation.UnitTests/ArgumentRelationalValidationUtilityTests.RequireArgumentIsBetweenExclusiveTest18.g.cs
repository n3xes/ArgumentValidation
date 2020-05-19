using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenExclusiveTest18.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTest18ThrowsArgumentNullException559()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(default(decimal), (string)null, new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest18ThrowsArgumentOutOfRangeException393()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(default(decimal), "", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest18ThrowsArgumentOutOfRangeException182()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(default(decimal), "\0", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest18ThrowsArgumentOutOfRangeException625()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(-76819052936496198642298613574e-19M, "\0", new decimal?(0e-4M), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest18183()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(177519435M, "\0", new decimal?(1e-1M), 47783165704927611543839379711e-17M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest18ThrowsArgumentOutOfRangeException992()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(default(decimal), "Ā", new decimal?(0e-4M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenExclusiveTest18342()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(-76819052936496198642298613574e-19M, "\0", default(decimal?), 1M);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest18ThrowsArgumentOutOfRangeException247()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(default(decimal), "\t", new decimal?(0e-8M), default(decimal));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest18ThrowsArgumentOutOfRangeException829()
{
	this.RequireArgumentIsBetweenExclusiveTest18
		(default(decimal), "\t\0", new decimal?(0e-4M), default(decimal));
}
	}
}
