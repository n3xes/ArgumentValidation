using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsOutsideExclusiveTest15ThrowsArgumentNullException431()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), (string)null, new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest15ThrowsArgumentOutOfRangeException356()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), "", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest15ThrowsArgumentOutOfRangeException890()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), "\0", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest15ThrowsArgumentOutOfRangeException209()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), "\0", new byte?((byte)1), default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest15451()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)2), "\0", new byte?((byte)1), new byte?((byte)3));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest1552()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), "\0", default(byte?), default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest15ThrowsArgumentOutOfRangeException112()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), "\t", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest15930()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(default(byte?), "\0", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest15ThrowsArgumentOutOfRangeException275()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest15ThrowsArgumentOutOfRangeException183()
{
	this.RequireArgumentIsOutsideExclusiveTest15
		(new byte?((byte)1), "\t\0", new byte?((byte)1), new byte?((byte)1));
}
	}
}
