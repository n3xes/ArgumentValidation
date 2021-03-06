using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsOutsideTest12.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest12ThrowsArgumentNullException814()
{
	this.RequireArgumentIsOutsideTest12
		(new byte?((byte)1), (string)null, (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest12ThrowsArgumentOutOfRangeException15()
{
	this.RequireArgumentIsOutsideTest12(new byte?((byte)1), "", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest12ThrowsArgumentOutOfRangeException755()
{
	this.RequireArgumentIsOutsideTest12(new byte?((byte)1), "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest12511()
{
	this.RequireArgumentIsOutsideTest12(default(byte?), "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsOutsideTest1201()
{
	this.RequireArgumentIsOutsideTest12
		(new byte?((byte)1), "\0", (byte)128, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest12ThrowsArgumentOutOfRangeException()
{
	this.RequireArgumentIsOutsideTest12
		(new byte?((byte)1), "\0", (byte)128, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest12ThrowsArgumentOutOfRangeException341()
{
	this.RequireArgumentIsOutsideTest12(new byte?((byte)1), "Ā", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest12ThrowsArgumentOutOfRangeException793()
{
	this.RequireArgumentIsOutsideTest12(new byte?((byte)1), "\t", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest12ThrowsArgumentOutOfRangeException473()
{
	this.RequireArgumentIsOutsideTest12
		(new byte?((byte)1), "\t\0", (byte)0, (byte)0);
}
	}
}
