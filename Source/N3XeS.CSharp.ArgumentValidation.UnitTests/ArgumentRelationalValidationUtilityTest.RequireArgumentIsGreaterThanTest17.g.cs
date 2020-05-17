using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest17ThrowsArgumentNullException822()
{
	this.RequireArgumentIsGreaterThanTest17
		((float)0, (string)null, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest17ThrowsArgumentOutOfRangeException859()
{
	this.RequireArgumentIsGreaterThanTest17((float)0, "", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest17ThrowsArgumentOutOfRangeException571()
{
	this.RequireArgumentIsGreaterThanTest17((float)0, "\0", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanTest17120()
{
	this.RequireArgumentIsGreaterThanTest17((float)0, "\0", default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest17ThrowsArgumentOutOfRangeException627()
{
	this.RequireArgumentIsGreaterThanTest17((float)0, "Ā", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest17ThrowsArgumentOutOfRangeException33()
{
	this.RequireArgumentIsGreaterThanTest17((float)0, "\t", new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest17ThrowsArgumentOutOfRangeException164()
{
	this.RequireArgumentIsGreaterThanTest17((float)0, "\t\t", new float?((float)0));
}
	}
}
