using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest34.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest34ThrowsArgumentNullException368()
{
	this.RequireArgumentIsLessThanOrEqualTest34
		(new short?((short)65), (string)null, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest34ThrowsArgumentOutOfRangeException217()
{
	this.RequireArgumentIsLessThanOrEqualTest34
		(new short?((short)65), "", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest34ThrowsArgumentOutOfRangeException562()
{
	this.RequireArgumentIsLessThanOrEqualTest34
		(new short?((short)65), "\0", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest34947()
{
	this.RequireArgumentIsLessThanOrEqualTest34(default(short?), "\0", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest34ThrowsArgumentOutOfRangeException596()
{
	this.RequireArgumentIsLessThanOrEqualTest34
		(new short?((short)65), "Ā", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest34ThrowsArgumentOutOfRangeException777()
{
	this.RequireArgumentIsLessThanOrEqualTest34
		(new short?((short)65), "\t", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest34ThrowsArgumentOutOfRangeException414()
{
	this.RequireArgumentIsLessThanOrEqualTest34
		(new short?((short)65), "\t\t", (short)64);
}
	}
}
