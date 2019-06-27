using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentNullException484()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(default(DateTime?), (string)null, default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException545()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(default(DateTime?), "", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest0397()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(default(DateTime?), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest03905()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(new DateTime?(default(DateTime)), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest03719()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(new DateTime?(default(DateTime)), "\0", new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException914()
{
	this.RequireArgumentIsLessThanOrEqualTest03(new DateTime?(new DateTime
																  (4611686018427387903L & 2048L, (DateTimeKind)(2048uL >> 62))), 
												"\0", new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException908()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(default(DateTime?), "\t", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest03539()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(default(DateTime?), "Ā", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest03ThrowsArgumentOutOfRangeException76()
{
	this.RequireArgumentIsLessThanOrEqualTest03
		(default(DateTime?), "\t\t", default(DateTime?));
}
	}
}
