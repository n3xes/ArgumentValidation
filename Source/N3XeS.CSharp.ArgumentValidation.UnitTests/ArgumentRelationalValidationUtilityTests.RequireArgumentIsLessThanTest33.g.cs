using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanTest33.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest33ThrowsArgumentNullException479()
{
	this.RequireArgumentIsLessThanTest33((short)65, (string)null, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest33ThrowsArgumentOutOfRangeException976()
{
	this.RequireArgumentIsLessThanTest33((short)65, "", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanTest33787()
{
	this.RequireArgumentIsLessThanTest33((short)65, "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest33ThrowsArgumentOutOfRangeException675()
{
	this.RequireArgumentIsLessThanTest33((short)65, "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanTest33857()
{
	this.RequireArgumentIsLessThanTest33((short)65, "Ā", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest33ThrowsArgumentOutOfRangeException60()
{
	this.RequireArgumentIsLessThanTest33((short)65, "\t", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest33ThrowsArgumentOutOfRangeException814()
{
	this.RequireArgumentIsLessThanTest33((short)65, "\n\t", default(short?));
}
	}
}
