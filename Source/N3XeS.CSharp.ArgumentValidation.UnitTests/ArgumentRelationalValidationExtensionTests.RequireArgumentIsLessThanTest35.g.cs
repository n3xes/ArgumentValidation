using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanTest35.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest35ThrowsArgumentNullException167()
{
	this.RequireArgumentIsLessThanTest35
		(default(short?), (string)null, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest35ThrowsArgumentOutOfRangeException766()
{
	this.RequireArgumentIsLessThanTest35(default(short?), "", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanTest3597()
{
	this.RequireArgumentIsLessThanTest35(default(short?), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanTest3529()
{
	this.RequireArgumentIsLessThanTest35
		(new short?((short)0), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest35ThrowsArgumentOutOfRangeException193()
{
	this.RequireArgumentIsLessThanTest35
		(new short?((short)0), "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest35ThrowsArgumentOutOfRangeException873()
{
	this.RequireArgumentIsLessThanTest35(default(short?), "\t", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanTest35539()
{
	this.RequireArgumentIsLessThanTest35(default(short?), "Ā", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest35ThrowsArgumentOutOfRangeException735()
{
	this.RequireArgumentIsLessThanTest35(default(short?), "\t\t", default(short?));
}
	}
}
