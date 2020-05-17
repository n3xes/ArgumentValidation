using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest35.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest35ThrowsArgumentNullException29()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(default(short?), (string)null, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest35ThrowsArgumentOutOfRangeException889()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(default(short?), "", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest35468()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(default(short?), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest35120()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(new short?((short)0), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest35563()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(new short?((short)0), "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest35ThrowsArgumentOutOfRangeException153()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(new short?((short)0), "\0", new short?((short)64));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest35ThrowsArgumentOutOfRangeException877()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(default(short?), "\t", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanOrEqualTest35824()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(default(short?), "Ā", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest35ThrowsArgumentOutOfRangeException229()
{
	this.RequireArgumentIsGreaterThanOrEqualTest35
		(default(short?), "\t\t", default(short?));
}
	}
}
