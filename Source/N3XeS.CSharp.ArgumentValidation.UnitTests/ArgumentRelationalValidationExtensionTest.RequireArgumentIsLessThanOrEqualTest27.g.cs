using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest27.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest27ThrowsArgumentNullException366()
{
	this.RequireArgumentIsLessThanOrEqualTest27
		(new long?(1L), (string)null, new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest27ThrowsArgumentOutOfRangeException662()
{
	this.RequireArgumentIsLessThanOrEqualTest27(new long?(1L), "", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest27709()
{
	this.RequireArgumentIsLessThanOrEqualTest27(new long?(1L), "\0", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest27599()
{
	this.RequireArgumentIsLessThanOrEqualTest27(new long?(1L), "\0", default(long?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest27ThrowsArgumentOutOfRangeException344()
{
	this.RequireArgumentIsLessThanOrEqualTest27(new long?(3L), "\0", new long?(2L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest27548()
{
	this.RequireArgumentIsLessThanOrEqualTest27(new long?(1L), "Ā", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest27639()
{
	this.RequireArgumentIsLessThanOrEqualTest27(default(long?), "Ā", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest27ThrowsArgumentOutOfRangeException330()
{
	this.RequireArgumentIsLessThanOrEqualTest27(new long?(1L), "\t", new long?(1L));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest27ThrowsArgumentOutOfRangeException890()
{
	this.RequireArgumentIsLessThanOrEqualTest27
		(new long?(1L), "\t\t", new long?(1L));
}
	}
}
