using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest25.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest25ThrowsArgumentNullException848()
{
	this.RequireArgumentIsOutsideTest25(0, (string)null, 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest25ThrowsArgumentOutOfRangeException237()
{
	this.RequireArgumentIsOutsideTest25(0, "", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest25582()
{
	this.RequireArgumentIsOutsideTest25(0, "\0", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest25158()
{
	this.RequireArgumentIsOutsideTest25(0, "\0", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest25ThrowsArgumentOutOfRangeException962()
{
	this.RequireArgumentIsOutsideTest25(-2, "\0", 0, new double?(-1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest25915()
{
	this.RequireArgumentIsOutsideTest25(0, "Ā", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest25ThrowsArgumentOutOfRangeException203()
{
	this.RequireArgumentIsOutsideTest25(1, "Ā", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest25ThrowsArgumentOutOfRangeException100()
{
	this.RequireArgumentIsOutsideTest25(0, "\t", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest25623()
{
	this.RequireArgumentIsOutsideTest25(0, "\n\0", 0, new double?(0));
}
	}
}
