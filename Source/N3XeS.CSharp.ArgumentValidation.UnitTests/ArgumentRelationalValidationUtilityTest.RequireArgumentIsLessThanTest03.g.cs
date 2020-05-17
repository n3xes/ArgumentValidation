using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest03ThrowsArgumentNullException837()
{
	this.RequireArgumentIsLessThanTest03
		(default(DateTime?), (string)null, default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest03ThrowsArgumentOutOfRangeException298()
{
	this.RequireArgumentIsLessThanTest03(default(DateTime?), "", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest0397()
{
	this.RequireArgumentIsLessThanTest03
		(default(DateTime?), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest03905()
{
	this.RequireArgumentIsLessThanTest03
		(new DateTime?(default(DateTime)), "\0", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest03ThrowsArgumentOutOfRangeException192()
{
	this.RequireArgumentIsLessThanTest03
		(new DateTime?(default(DateTime)), "\0", new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest03ThrowsArgumentOutOfRangeException460()
{
	this.RequireArgumentIsLessThanTest03
		(default(DateTime?), "\t", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest03539()
{
	this.RequireArgumentIsLessThanTest03
		(default(DateTime?), "Ā", default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest03ThrowsArgumentOutOfRangeException531()
{
	this.RequireArgumentIsLessThanTest03
		(default(DateTime?), "\t\t", default(DateTime?));
}
	}
}
