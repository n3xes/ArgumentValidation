using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest39.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentNullException62()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), (string)null, 
		 new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentOutOfRangeException912()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), "", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentOutOfRangeException278()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), "\0", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest39170()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), "\0", default(float?), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentOutOfRangeException509()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), "Ā", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentOutOfRangeException674()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), "Ā", new float?((float)1), default(float?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentOutOfRangeException625()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), "\t", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest39795()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(default(float?), "Ā", new float?((float)1), new float?((float)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentOutOfRangeException728()
{
	this.RequireArgumentIsBetweenExclusiveTest39(new float?((float)(-1)), "Ā", 
												 new float?((float)1), new float?((float)(-7720)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest39ThrowsArgumentOutOfRangeException165()
{
	this.RequireArgumentIsBetweenExclusiveTest39
		(new float?((float)0), "\t\0", new float?((float)1), new float?((float)2));
}
	}
}
