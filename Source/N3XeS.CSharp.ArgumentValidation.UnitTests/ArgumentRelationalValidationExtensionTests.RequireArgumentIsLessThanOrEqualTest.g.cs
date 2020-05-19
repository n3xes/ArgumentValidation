using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTestThrowsArgumentNullException192()
{
	this.RequireArgumentIsLessThanOrEqualTest
		(default(DateTime), (string)null, default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTestThrowsArgumentOutOfRangeException953()
{
	this.RequireArgumentIsLessThanOrEqualTest
		(default(DateTime), "", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest719()
{
	this.RequireArgumentIsLessThanOrEqualTest
		(default(DateTime), "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTestThrowsArgumentOutOfRangeException179()
{
	this.RequireArgumentIsLessThanOrEqualTest
		(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 "\0", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest427()
{
	this.RequireArgumentIsLessThanOrEqualTest
		(default(DateTime), "Ā", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTestThrowsArgumentOutOfRangeException238()
{
	this.RequireArgumentIsLessThanOrEqualTest
		(default(DateTime), "\t", default(DateTime));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTestThrowsArgumentOutOfRangeException750()
{
	this.RequireArgumentIsLessThanOrEqualTest
		(default(DateTime), "\t\t", default(DateTime));
}
	}
}
