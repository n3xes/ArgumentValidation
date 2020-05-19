using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanTest27.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest27ThrowsArgumentNullException266()
{
	this.RequireArgumentIsGreaterThanTest27
		(new long?(1L), (string)null, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest27ThrowsArgumentOutOfRangeException978()
{
	this.RequireArgumentIsGreaterThanTest27(new long?(1L), "", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest27ThrowsArgumentOutOfRangeException977()
{
	this.RequireArgumentIsGreaterThanTest27(new long?(1L), "\0", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest27452()
{
	this.RequireArgumentIsGreaterThanTest27(new long?(1L), "\0", default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest27ThrowsArgumentOutOfRangeException621()
{
	this.RequireArgumentIsGreaterThanTest27(new long?(1L), "Ā", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanTest27469()
{
	this.RequireArgumentIsGreaterThanTest27(default(long?), "Ā", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest27ThrowsArgumentOutOfRangeException868()
{
	this.RequireArgumentIsGreaterThanTest27(new long?(1L), "\t", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest27ThrowsArgumentOutOfRangeException255()
{
	this.RequireArgumentIsGreaterThanTest27(new long?(1L), "\t\t", new long?(1L));
}
	}
}
