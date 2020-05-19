using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsLessThanTest18.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest18ThrowsArgumentNullException859()
{
	this.RequireArgumentIsLessThanTest18
		(new float?((float)0), (string)null, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest18ThrowsArgumentOutOfRangeException9()
{
	this.RequireArgumentIsLessThanTest18(new float?((float)0), "", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest18ThrowsArgumentOutOfRangeException162()
{
	this.RequireArgumentIsLessThanTest18(new float?((float)0), "\0", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsLessThanTest18875()
{
	this.RequireArgumentIsLessThanTest18(default(float?), "\0", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest18ThrowsArgumentOutOfRangeException832()
{
	this.RequireArgumentIsLessThanTest18(new float?((float)0), "Ā", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest18ThrowsArgumentOutOfRangeException587()
{
	this.RequireArgumentIsLessThanTest18(new float?((float)0), "\t", (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest18ThrowsArgumentOutOfRangeException173()
{
	this.RequireArgumentIsLessThanTest18(new float?((float)0), "\t\t", (float)0);
}
	}
}
