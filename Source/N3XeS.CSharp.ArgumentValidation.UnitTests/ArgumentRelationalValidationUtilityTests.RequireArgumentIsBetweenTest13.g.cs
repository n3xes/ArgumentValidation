using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest13.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest13ThrowsArgumentNullException374()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), (string)null, (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest13ThrowsArgumentOutOfRangeException219()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), "", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest13738()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), "\0", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest13ThrowsArgumentOutOfRangeException129()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)3), "\0", (byte)0, new byte?((byte)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest13ThrowsArgumentOutOfRangeException660()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), "\0", (byte)2, new byte?((byte)128));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest13686()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), "Ā", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest13564()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), "Ā", (byte)0, default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest13ThrowsArgumentOutOfRangeException489()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), "\t", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest13979()
{
	this.RequireArgumentIsBetweenTest13
		(default(byte?), "Ā", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest1329()
{
	this.RequireArgumentIsBetweenTest13
		(new byte?((byte)1), "\t\0", (byte)0, new byte?((byte)1));
}
	}
}
