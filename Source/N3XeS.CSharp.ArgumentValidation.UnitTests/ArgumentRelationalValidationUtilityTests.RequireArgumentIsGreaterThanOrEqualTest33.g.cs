using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsGreaterThanOrEqualTest33.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest33ThrowsArgumentNullException255()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33
		((short)65, (string)null, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest33ThrowsArgumentOutOfRangeException456()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33((short)65, "", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest33208()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33((short)65, "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest33933()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33
		((short)65, "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest33ThrowsArgumentOutOfRangeException725()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33
		((short)32, "\0", new short?((short)34));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsGreaterThanOrEqualTest33884()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33((short)65, "Ā", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest33ThrowsArgumentOutOfRangeException388()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33((short)65, "\t", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest33ThrowsArgumentOutOfRangeException723()
{
	this.RequireArgumentIsGreaterThanOrEqualTest33
		((short)65, "\n\t", default(short?));
}
	}
}
