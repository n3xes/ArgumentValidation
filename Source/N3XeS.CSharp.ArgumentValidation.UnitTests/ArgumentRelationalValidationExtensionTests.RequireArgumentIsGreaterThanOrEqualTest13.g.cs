using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest13.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest13ThrowsArgumentNullException345()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(0, (string)null, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest13ThrowsArgumentOutOfRangeException110()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(0, "", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest13563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(0, "\0", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest13120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(0, "\0", default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest13ThrowsArgumentOutOfRangeException849()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(-2, "\0", new double?(-1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanOrEqualTest1334()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(0, "Ā", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest13ThrowsArgumentOutOfRangeException673()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(0, "\t", new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest13ThrowsArgumentOutOfRangeException860()
{
	this.RequireArgumentIsGreaterThanOrEqualTest13(0, "\t\t", new double?(0));
}
	}
}
