using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest35.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentNullException80()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), (string)null, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException285()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest3597()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest3529()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(new short?((short)0), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest35817()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(new short?((short)0), "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException874()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(new short?((short)48), "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException378()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "\t", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsLessThanOrEqualTest35539()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "Ā", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException317()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "\t\t", default(short?));
}
	}
}
