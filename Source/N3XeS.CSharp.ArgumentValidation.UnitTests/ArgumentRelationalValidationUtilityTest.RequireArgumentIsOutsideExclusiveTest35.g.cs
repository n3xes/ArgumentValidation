using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideExclusiveTest35.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentNullException799()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, (string)null, new float?((float)0), new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentOutOfRangeException318()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "", new float?((float)0), new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentOutOfRangeException245()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "\0", new float?((float)0), new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideExclusiveTest35504()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "\0", default(float?), new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentOutOfRangeException111()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "Ā", new float?((float)0), new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentOutOfRangeException651()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "Ā", new float?((float)0), new float?((float)(-1)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentOutOfRangeException83()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "\t", new float?((float)0), new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentOutOfRangeException50()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "Ā", new float?((float)0), default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest35ThrowsArgumentOutOfRangeException641()
{
	this.RequireArgumentIsOutsideExclusiveTest35
		((float)0, "\t\0", new float?((float)0), new float?((float)1));
}
	}
}
