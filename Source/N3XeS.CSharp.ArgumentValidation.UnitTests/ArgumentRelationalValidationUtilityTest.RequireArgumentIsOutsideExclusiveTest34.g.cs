using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest34.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentNullException873()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, (string)null, new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException38()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException199()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException887()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", new float?((float)0), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest34372()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", new float?((float)(-1)), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException317()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "Ā", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest34504()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\0", default(float?), (float)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException101()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\t", new float?((float)0), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest34ThrowsArgumentOutOfRangeException950()
{
	this.RequireArgumentIsOutsideExclusiveTest34
		((float)0, "\n\0", new float?((float)0), (float)0);
}
	}
}
