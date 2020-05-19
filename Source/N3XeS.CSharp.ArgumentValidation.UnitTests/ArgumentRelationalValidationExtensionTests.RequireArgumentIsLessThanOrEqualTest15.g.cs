using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentNullException274()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), (string)null, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException411()
{
	this.RequireArgumentIsLessThanOrEqualTest15(new double?(0), "", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest15511()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\0", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest1529()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\0", default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException978()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(-1), "\0", new double?(-2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest15394()
{
	this.RequireArgumentIsLessThanOrEqualTest15(new double?(0), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest15639()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(default(double?), "Ā", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException872()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\t", new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest15ThrowsArgumentOutOfRangeException469()
{
	this.RequireArgumentIsLessThanOrEqualTest15
		(new double?(0), "\t\t", new double?(1));
}
	}
}
