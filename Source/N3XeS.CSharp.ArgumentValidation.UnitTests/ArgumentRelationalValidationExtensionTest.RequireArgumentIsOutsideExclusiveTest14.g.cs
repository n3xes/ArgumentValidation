using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest14.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest14ThrowsArgumentNullException799()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(new byte?((byte)1), (string)null, new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest14ThrowsArgumentOutOfRangeException276()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(new byte?((byte)1), "", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest14ThrowsArgumentOutOfRangeException938()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(new byte?((byte)1), "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest14373()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(default(byte?), "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest14ThrowsArgumentOutOfRangeException206()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(new byte?((byte)1), "\0", new byte?((byte)1), (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest14ThrowsArgumentOutOfRangeException693()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(new byte?((byte)1), "Ā", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest14ThrowsArgumentOutOfRangeException612()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(new byte?((byte)1), "\t", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest14ThrowsArgumentOutOfRangeException450()
{
	this.RequireArgumentIsOutsideExclusiveTest14
		(new byte?((byte)1), "\t\0", new byte?((byte)1), (byte)0);
}
	}
}
