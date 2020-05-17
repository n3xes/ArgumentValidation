using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenExclusiveTest13.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest13ThrowsArgumentNullException615()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), (string)null, (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest13ThrowsArgumentOutOfRangeException922()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), "", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest13ThrowsArgumentOutOfRangeException699()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), "\0", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest13224()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), "\0", (byte)0, default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest13ThrowsArgumentOutOfRangeException118()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), "\0", (byte)128, default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenExclusiveTest13132()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(default(byte?), "\0", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest13ThrowsArgumentOutOfRangeException353()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), "Ā", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest13ThrowsArgumentOutOfRangeException387()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), "\t", (byte)0, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest13ThrowsArgumentOutOfRangeException203()
{
	this.RequireArgumentIsBetweenExclusiveTest13
		(new byte?((byte)1), "\t\0", (byte)0, new byte?((byte)1));
}
	}
}
