using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest38.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest38ThrowsArgumentNullException287()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)0), (string)null, new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest38ThrowsArgumentOutOfRangeException594()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)0), "", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest38ThrowsArgumentOutOfRangeException382()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)0), "\0", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest38460()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)0), "\0", default(float?), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest38ThrowsArgumentOutOfRangeException898()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)0), "Ā", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest38ThrowsArgumentOutOfRangeException14()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)(-1)), "Ā", new float?((float)1), (float)(-2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest38ThrowsArgumentOutOfRangeException278()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)0), "\t", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest38681()
{
	this.RequireArgumentIsBetweenTest38
		(default(float?), "Ā", new float?((float)1), (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest38ThrowsArgumentOutOfRangeException738()
{
	this.RequireArgumentIsBetweenTest38
		(new float?((float)0), "\t\0", new float?((float)1), (float)0);
}
	}
}
