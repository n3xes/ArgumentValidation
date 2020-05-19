using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest70.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest70ThrowsArgumentNullException407()
{
	this.RequireArgumentIsOutsideTest70
		(new short?((short)33), (string)null, new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest70ThrowsArgumentOutOfRangeException416()
{
	this.RequireArgumentIsOutsideTest70
		(new short?((short)64), "", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest70ThrowsArgumentOutOfRangeException560()
{
	this.RequireArgumentIsOutsideTest70
		(new short?((short)65), "\0", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest70772()
{
	this.RequireArgumentIsOutsideTest70
		(new short?((short)65), "\0", default(short?), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest70ThrowsArgumentOutOfRangeException451()
{
	this.RequireArgumentIsOutsideTest70
		(new short?((short)33), "\0", new short?((short)64), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest70538()
{
	this.RequireArgumentIsOutsideTest70
		(default(short?), "\0", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest70ThrowsArgumentOutOfRangeException491()
{
	this.RequireArgumentIsOutsideTest70
		(new short?((short)65), "Ȁ", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest70ThrowsArgumentOutOfRangeException904()
{
	this.RequireArgumentIsOutsideTest70
		(new short?((short)65), "\t", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest70694()
{
	this.RequireArgumentIsOutsideTest70
		(default(short?), "\t\0", default(short?), (short)65);
}
	}
}
