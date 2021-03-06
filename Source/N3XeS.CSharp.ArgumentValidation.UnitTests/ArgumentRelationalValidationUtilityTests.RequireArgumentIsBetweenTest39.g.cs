using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest39.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest39ThrowsArgumentNullException890()
{
	this.RequireArgumentIsBetweenTest39(new float?((float)0), (string)null, 
										new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest39ThrowsArgumentOutOfRangeException109()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)0), "", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest39ThrowsArgumentOutOfRangeException39()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)0), "\0", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest39170()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)0), "\0", default(float?), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest39ThrowsArgumentOutOfRangeException829()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)0), "Ā", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest39ThrowsArgumentOutOfRangeException494()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)0), "Ā", new float?((float)1), default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest39ThrowsArgumentOutOfRangeException530()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)0), "\t", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest39795()
{
	this.RequireArgumentIsBetweenTest39
		(default(float?), "Ā", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest39ThrowsArgumentOutOfRangeException370()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)(-1)), "Ā", new float?((float)1), new float?((float)(-2)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest39ThrowsArgumentOutOfRangeException453()
{
	this.RequireArgumentIsBetweenTest39
		(new float?((float)0), "\t\0", new float?((float)1), new float?((float)2));
}
	}
}
