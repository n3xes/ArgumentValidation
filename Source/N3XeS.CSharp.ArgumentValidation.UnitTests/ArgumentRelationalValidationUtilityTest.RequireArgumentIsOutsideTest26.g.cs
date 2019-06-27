using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest26.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideTest26ThrowsArgumentNullException913()
{
	this.RequireArgumentIsOutsideTest26(0, (string)null, new double?(0), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest26ThrowsArgumentOutOfRangeException632()
{
	this.RequireArgumentIsOutsideTest26(0, "", new double?(0), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest26582()
{
	this.RequireArgumentIsOutsideTest26(0, "\0", new double?(0), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest26ThrowsArgumentOutOfRangeException129()
{
	this.RequireArgumentIsOutsideTest26(0, "\0", new double?(-1), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest26ThrowsArgumentOutOfRangeException487()
{
	this.RequireArgumentIsOutsideTest26(0, "\0", new double?(0), 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest26915()
{
	this.RequireArgumentIsOutsideTest26(0, "Ā", new double?(0), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest26960()
{
	this.RequireArgumentIsOutsideTest26(0, "Ā", default(double?), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest26ThrowsArgumentOutOfRangeException245()
{
	this.RequireArgumentIsOutsideTest26(0, "\t", new double?(0), 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest26623()
{
	this.RequireArgumentIsOutsideTest26(0, "\n\0", new double?(0), 0);
}
	}
}
