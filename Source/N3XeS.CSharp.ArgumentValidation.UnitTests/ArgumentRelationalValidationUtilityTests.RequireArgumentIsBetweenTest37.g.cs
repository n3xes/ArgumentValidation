using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest37.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest37ThrowsArgumentNullException791()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)0), (string)null, (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest37ThrowsArgumentOutOfRangeException193()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)0), "", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest3758()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)0), "\0", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest37ThrowsArgumentOutOfRangeException288()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)(-1)), "\0", (float)0, new float?((float)(-2)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest37ThrowsArgumentOutOfRangeException912()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)(-1)), "\0", (float)0, new float?((float)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest37667()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)0), "Ā", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest37697()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)0), "Ā", (float)0, default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest37ThrowsArgumentOutOfRangeException268()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)0), "\t", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest37876()
{
	this.RequireArgumentIsBetweenTest37
		(default(float?), "Ā", (float)0, new float?((float)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest37531()
{
	this.RequireArgumentIsBetweenTest37
		(new float?((float)0), "\t\0", (float)0, new float?((float)1));
}
	}
}
