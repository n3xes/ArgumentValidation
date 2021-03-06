using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest03ThrowsArgumentNullException870()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(default(DateTime?), (string)null, default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest03ThrowsArgumentOutOfRangeException201()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(default(DateTime?), "", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest03468()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(default(DateTime?), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest03340()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(new DateTime?(default(DateTime)), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest03664()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(new DateTime?(default(DateTime)), "\0", new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest03ThrowsArgumentOutOfRangeException263()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(new DateTime?(default(DateTime)), "\0", new DateTime?(new DateTime
																   (4611686018427387903L & 2048L, (DateTimeKind)(2048uL >> 62))));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest03ThrowsArgumentOutOfRangeException560()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(default(DateTime?), "\t", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest03824()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(default(DateTime?), "Ā", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest03ThrowsArgumentOutOfRangeException892()
{
	this.RequireArgumentIsGreaterThanOrEqualTest03
		(default(DateTime?), "\t\t", default(DateTime?));
}
	}
}
