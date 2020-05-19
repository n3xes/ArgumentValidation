using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideTest29.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideTest29ThrowsArgumentNullException425()
{
	this.RequireArgumentIsOutsideTest29
		(new double?(0), (string)null, 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest29ThrowsArgumentOutOfRangeException720()
{
	this.RequireArgumentIsOutsideTest29(new double?(0), "", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest29ThrowsArgumentOutOfRangeException896()
{
	this.RequireArgumentIsOutsideTest29(new double?(0), "\0", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest29158()
{
	this.RequireArgumentIsOutsideTest29(new double?(0), "\0", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest29ThrowsArgumentOutOfRangeException590()
{
	this.RequireArgumentIsOutsideTest29(new double?(0), "Ā", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest29ThrowsArgumentOutOfRangeException711()
{
	this.RequireArgumentIsOutsideTest29(new double?(-1), "Ā", -2, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest29ThrowsArgumentOutOfRangeException81()
{
	this.RequireArgumentIsOutsideTest29(new double?(0), "\t", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest29876()
{
	this.RequireArgumentIsOutsideTest29(default(double?), "Ā", 0, new double?(1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest29ThrowsArgumentOutOfRangeException830()
{
	this.RequireArgumentIsOutsideTest29(new double?(0), "\t\0", 0, new double?(1));
}
	}
}
