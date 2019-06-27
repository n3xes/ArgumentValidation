using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	public partial class ArgumentRelationalValidationExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenExclusiveTest15ThrowsArgumentNullException542()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), (string)null, new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest15ThrowsArgumentOutOfRangeException550()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), "", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest15ThrowsArgumentOutOfRangeException216()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), "\0", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest15ThrowsArgumentOutOfRangeException395()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), "\0", new byte?((byte)1), default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest15451()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)2), "\0", new byte?((byte)1), new byte?((byte)3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest1552()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), "\0", default(byte?), default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest15ThrowsArgumentOutOfRangeException389()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), "\t", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest15930()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(default(byte?), "\0", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest15ThrowsArgumentOutOfRangeException308()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest15ThrowsArgumentOutOfRangeException9()
{
	this.RequireArgumentIsBetweenExclusiveTest15
		(new byte?((byte)1), "\t\0", new byte?((byte)1), new byte?((byte)1));
}
	}
}
