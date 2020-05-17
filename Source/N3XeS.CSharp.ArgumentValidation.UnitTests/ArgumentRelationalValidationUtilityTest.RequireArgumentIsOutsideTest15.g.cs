using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsOutsideTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest15ThrowsArgumentNullException67()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), (string)null, new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest15ThrowsArgumentOutOfRangeException77()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest15552()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "\0", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest15130()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "\0", new byte?((byte)1), default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest15ThrowsArgumentOutOfRangeException970()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "\0", new byte?((byte)64), new byte?((byte)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest15627()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest15417()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "Ā", default(byte?), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest15ThrowsArgumentOutOfRangeException356()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "\t", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest15423()
{
	this.RequireArgumentIsOutsideTest15
		(default(byte?), "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest15ThrowsArgumentOutOfRangeException743()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)3), "Ā", new byte?((byte)2), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsOutsideTest15974()
{
	this.RequireArgumentIsOutsideTest15
		(new byte?((byte)1), "\t\0", new byte?((byte)1), new byte?((byte)1));
}
	}
}
