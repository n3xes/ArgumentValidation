using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest34.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentNullException595()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, (string)null, new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException646()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException640()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException690()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", new float?((float)0), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest34372()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", new float?((float)(-1)), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException97()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "Ā", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest34504()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", default(float?), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException983()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\t", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException855()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\n\0", new float?((float)0), (float)0);
}
	}
}
