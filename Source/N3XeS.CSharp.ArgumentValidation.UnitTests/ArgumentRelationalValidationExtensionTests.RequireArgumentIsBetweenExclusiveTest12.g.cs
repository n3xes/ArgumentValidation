using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest12.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest12ThrowsArgumentNullException137()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)1), (string)null, (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest12ThrowsArgumentOutOfRangeException907()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)1), "", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest12ThrowsArgumentOutOfRangeException130()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)1), "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest12511()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(default(byte?), "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest12814()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)1), "\0", (byte)0, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest12ThrowsArgumentOutOfRangeException55()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)0), "\0", (byte)0, (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest12ThrowsArgumentOutOfRangeException905()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)1), "Ā", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest12ThrowsArgumentOutOfRangeException811()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)1), "\t", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest12ThrowsArgumentOutOfRangeException755()
{
	this.RequireArgumentIsBetweenExclusiveTest12
		(new byte?((byte)1), "\t\0", (byte)0, (byte)0);
}
	}
}
