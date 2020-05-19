using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest32.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest32ThrowsArgumentNullException368()
{
	this.RequireArgumentIsOutsideTest32((float)0, (string)null, (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest32ThrowsArgumentOutOfRangeException300()
{
	this.RequireArgumentIsOutsideTest32((float)0, "", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest32582()
{
	this.RequireArgumentIsOutsideTest32((float)0, "\0", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest32ThrowsArgumentOutOfRangeException279()
{
	this.RequireArgumentIsOutsideTest32((float)1, "\0", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest32ThrowsArgumentOutOfRangeException65()
{
	this.RequireArgumentIsOutsideTest32((float)0, "\0", (float)0, (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest32915()
{
	this.RequireArgumentIsOutsideTest32((float)0, "Ā", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest32ThrowsArgumentOutOfRangeException965()
{
	this.RequireArgumentIsOutsideTest32((float)0, "\t", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest32867()
{
	this.RequireArgumentIsOutsideTest32((float)0, "\t\0", (float)0, (float)0);
}
	}
}
