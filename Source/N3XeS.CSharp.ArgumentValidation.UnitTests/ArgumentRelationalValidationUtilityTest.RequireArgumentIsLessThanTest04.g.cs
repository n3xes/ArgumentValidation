using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsLessThanTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest04ThrowsArgumentNullException232()
{
	this.RequireArgumentIsLessThanTest04((byte)0, (string)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest04ThrowsArgumentOutOfRangeException586()
{
	this.RequireArgumentIsLessThanTest04((byte)0, "", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest04ThrowsArgumentOutOfRangeException878()
{
	this.RequireArgumentIsLessThanTest04((byte)0, "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsLessThanTest04843()
{
	this.RequireArgumentIsLessThanTest04((byte)0, "\0", (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest04ThrowsArgumentOutOfRangeException857()
{
	this.RequireArgumentIsLessThanTest04((byte)0, "Ā", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest04ThrowsArgumentOutOfRangeException250()
{
	this.RequireArgumentIsLessThanTest04((byte)0, "\t", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest04ThrowsArgumentOutOfRangeException556()
{
	this.RequireArgumentIsLessThanTest04((byte)0, "\t\t", (byte)0);
}
	}
}
