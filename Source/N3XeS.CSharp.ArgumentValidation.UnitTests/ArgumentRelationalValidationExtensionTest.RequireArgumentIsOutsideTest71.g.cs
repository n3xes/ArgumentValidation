using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest71.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest71ThrowsArgumentNullException31()
{
	this.RequireArgumentIsOutsideTest71
		(default(short?), (string)null, default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest71ThrowsArgumentOutOfRangeException667()
{
	this.RequireArgumentIsOutsideTest71
		(default(short?), "", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest71668()
{
	this.RequireArgumentIsOutsideTest71
		(default(short?), "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest71716()
{
	this.RequireArgumentIsOutsideTest71
		(new short?((short)0), "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest71460()
{
	this.RequireArgumentIsOutsideTest71
		(new short?((short)0), "\0", default(short?), new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest71ThrowsArgumentOutOfRangeException136()
{
	this.RequireArgumentIsOutsideTest71
		(new short?((short)32), "\0", default(short?), new short?((short)64));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest71158()
{
	this.RequireArgumentIsOutsideTest71
		(new short?((short)0), "\0", new short?((short)0), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest71480()
{
	this.RequireArgumentIsOutsideTest71
		(default(short?), "Ȁ", new short?((short)65), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest71ThrowsArgumentOutOfRangeException939()
{
	this.RequireArgumentIsOutsideTest71
		(new short?((short)48), "\0", new short?((short)0), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest71ThrowsArgumentOutOfRangeException457()
{
	this.RequireArgumentIsOutsideTest71
		(default(short?), "\t", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest71166()
{
	this.RequireArgumentIsOutsideTest71
		(default(short?), "\t\0", default(short?), default(short?));
}
	}
}
