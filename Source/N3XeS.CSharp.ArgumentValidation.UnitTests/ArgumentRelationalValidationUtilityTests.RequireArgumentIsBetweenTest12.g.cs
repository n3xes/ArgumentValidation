using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest12.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest12ThrowsArgumentNullException530()
{
	this.RequireArgumentIsBetweenTest12
		(new byte?((byte)1), (string)null, (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest12ThrowsArgumentOutOfRangeException466()
{
	this.RequireArgumentIsBetweenTest12(new byte?((byte)1), "", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest12ThrowsArgumentOutOfRangeException588()
{
	this.RequireArgumentIsBetweenTest12(new byte?((byte)1), "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest12511()
{
	this.RequireArgumentIsBetweenTest12(default(byte?), "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest12926()
{
	this.RequireArgumentIsBetweenTest12
		(new byte?((byte)1), "\0", (byte)0, (byte)128);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest12ThrowsArgumentOutOfRangeException308()
{
	this.RequireArgumentIsBetweenTest12
		(new byte?((byte)1), "\0", (byte)2, (byte)128);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest12ThrowsArgumentOutOfRangeException90()
{
	this.RequireArgumentIsBetweenTest12(new byte?((byte)1), "Ā", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest12ThrowsArgumentOutOfRangeException46601()
{
	this.RequireArgumentIsBetweenTest12(new byte?((byte)1), "\t", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest12ThrowsArgumentOutOfRangeException238()
{
	this.RequireArgumentIsBetweenTest12
		(new byte?((byte)1), "\t\0", (byte)0, (byte)0);
}
	}
}
