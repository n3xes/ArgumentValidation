using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest39.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentNullException243()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), (string)null, 
		 new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentOutOfRangeException908()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), "", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentOutOfRangeException590()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), "\0", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest39170()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), "\0", default(float?), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentOutOfRangeException433()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), "Ā", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentOutOfRangeException466()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), "Ā", new float?((float)1), default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentOutOfRangeException840()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), "\t", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest39795()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(default(float?), "Ā", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentOutOfRangeException849()
{
	this.RequireArgumentIsOutsideExclusiveTest39(new float?((float)(-1)), "Ā", 
												 new float?((float)1), new float?((float)(-7720)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest39ThrowsArgumentOutOfRangeException892()
{
	this.RequireArgumentIsOutsideExclusiveTest39
		(new float?((float)0), "\t\0", new float?((float)1), new float?((float)2));
}
	}
}
