using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest37.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest37ThrowsArgumentNullException662()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)0), (string)null, (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest37ThrowsArgumentOutOfRangeException789()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)0), "", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest37ThrowsArgumentOutOfRangeException692()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)0), "\0", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest37158()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)0), "\0", (float)0, default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest37ThrowsArgumentOutOfRangeException335()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)0), "Ā", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest37ThrowsArgumentOutOfRangeException209()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)(-1)), "Ā", (float)(-2), new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest37ThrowsArgumentOutOfRangeException67()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)0), "\t", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest37876()
{
	this.RequireArgumentIsOutsideTest37
		(default(float?), "Ā", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest37ThrowsArgumentOutOfRangeException402()
{
	this.RequireArgumentIsOutsideTest37
		(new float?((float)0), "\t\0", (float)0, new float?((float)1));
}
	}
}
