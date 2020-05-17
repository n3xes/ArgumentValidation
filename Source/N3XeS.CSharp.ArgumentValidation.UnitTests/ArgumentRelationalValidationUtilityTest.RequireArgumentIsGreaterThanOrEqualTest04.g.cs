using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsGreaterThanOrEqualTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanOrEqualTest04ThrowsArgumentNullException995()
{
	this.RequireArgumentIsGreaterThanOrEqualTest04((byte)0, (string)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest04ThrowsArgumentOutOfRangeException483()
{
	this.RequireArgumentIsGreaterThanOrEqualTest04((byte)0, "", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest04316()
{
	this.RequireArgumentIsGreaterThanOrEqualTest04((byte)0, "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest04ThrowsArgumentOutOfRangeException844()
{
	this.RequireArgumentIsGreaterThanOrEqualTest04((byte)0, "\0", (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsGreaterThanOrEqualTest04648()
{
	this.RequireArgumentIsGreaterThanOrEqualTest04((byte)0, "Ā", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest04ThrowsArgumentOutOfRangeException614()
{
	this.RequireArgumentIsGreaterThanOrEqualTest04((byte)0, "\t", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanOrEqualTest04ThrowsArgumentOutOfRangeException354()
{
	this.RequireArgumentIsGreaterThanOrEqualTest04((byte)0, "\t\t", (byte)0);
}
	}
}
