using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest32.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentNullException98()
{
	this.RequireArgumentIsOutsideExclusiveTest32
		((float)0, (string)null, (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException608()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException487()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "\0", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException599()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "\0", (float)0, (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest32372()
{
	this.RequireArgumentIsOutsideExclusiveTest32
		((float)0, "\0", (float)(-1), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException573()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "Ā", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException648()
{
	this.RequireArgumentIsOutsideExclusiveTest32((float)0, "\t", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest32ThrowsArgumentOutOfRangeException345()
{
	this.RequireArgumentIsOutsideExclusiveTest32
		((float)0, "\t\0", (float)0, (float)0);
}
	}
}
