using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest69.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest69ThrowsArgumentNullException531()
{
	this.RequireArgumentIsBetweenTest69
		(default(short?), (string)null, (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest69ThrowsArgumentOutOfRangeException450()
{
	this.RequireArgumentIsBetweenTest69
		(default(short?), "", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest69258()
{
	this.RequireArgumentIsBetweenTest69
		(default(short?), "\0", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest69ThrowsArgumentOutOfRangeException360()
{
	this.RequireArgumentIsBetweenTest69
		(new short?((short)0), "\0", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest6965()
{
	this.RequireArgumentIsBetweenTest69
		(default(short?), "Ā", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest69ThrowsArgumentOutOfRangeException56()
{
	this.RequireArgumentIsBetweenTest69
		(new short?((short)0), "\0", (short)65, new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest69ThrowsArgumentOutOfRangeException882()
{
	this.RequireArgumentIsBetweenTest69
		(default(short?), "\t", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest69ThrowsArgumentOutOfRangeException184()
{
	this.RequireArgumentIsBetweenTest69
		(new short?((short)80), "\0", (short)65, new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest69916()
{
	this.RequireArgumentIsBetweenTest69
		(default(short?), "\t\0", (short)65, default(short?));
}
	}
}
