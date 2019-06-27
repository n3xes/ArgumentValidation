using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanOrEqualTest35.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentNullException865()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), (string)null, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException497()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest3597()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest3529()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(new short?((short)0), "\0", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest35817()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(new short?((short)0), "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException803()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(new short?((short)48), "\0", new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException657()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "\t", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanOrEqualTest35539()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "Ā", default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest35ThrowsArgumentOutOfRangeException720()
{
	this.RequireArgumentIsLessThanOrEqualTest35
		(default(short?), "\t\t", default(short?));
}
	}
}
