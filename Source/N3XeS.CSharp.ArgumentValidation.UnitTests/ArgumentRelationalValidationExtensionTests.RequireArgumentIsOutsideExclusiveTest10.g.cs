using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest10.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentNullException721()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, (string)null, new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException10()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException583()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException883()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\0", new byte?((byte)1), (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest10451()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)2, "\0", new byte?((byte)1), (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException421()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "Ā", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest108()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\0", default(byte?), (byte)1);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException411()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\t", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest10ThrowsArgumentOutOfRangeException992()
{
	this.RequireArgumentIsOutsideExclusiveTest10
		((byte)0, "\t\0", new byte?((byte)1), (byte)0);
}
	}
}
