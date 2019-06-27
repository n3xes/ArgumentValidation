using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest67.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest67ThrowsArgumentNullException293()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, (string)null, default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest67ThrowsArgumentOutOfRangeException711()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, "", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest676()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest67ThrowsArgumentOutOfRangeException788()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, "\0", new short?((short)0), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest67846()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, "\0", default(short?), new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest67ThrowsArgumentOutOfRangeException686()
{
	this.RequireArgumentIsOutsideTest67
		((short)32, "\0", default(short?), new short?((short)64));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest67451()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, "Ā", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest67ThrowsArgumentOutOfRangeException809()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, "\t", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest6732()
{
	this.RequireArgumentIsOutsideTest67
		((short)65, "\t\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest67ThrowsArgumentOutOfRangeException579()
{
	this.RequireArgumentIsOutsideTest67
		((short)80, "Ā", new short?((short)80), new short?((short)88));
}
	}
}
