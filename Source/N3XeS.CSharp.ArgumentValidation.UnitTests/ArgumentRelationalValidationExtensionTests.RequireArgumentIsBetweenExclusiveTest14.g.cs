using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest14.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest14ThrowsArgumentNullException213()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(new byte?((byte)1), (string)null, new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest14ThrowsArgumentOutOfRangeException27()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(new byte?((byte)1), "", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest14ThrowsArgumentOutOfRangeException276()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(new byte?((byte)1), "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest14373()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(default(byte?), "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest14ThrowsArgumentOutOfRangeException475()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(new byte?((byte)1), "\0", new byte?((byte)1), (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest14ThrowsArgumentOutOfRangeException105()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(new byte?((byte)1), "Ā", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest14ThrowsArgumentOutOfRangeException644()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(new byte?((byte)1), "\t", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest14ThrowsArgumentOutOfRangeException410()
{
	this.RequireArgumentIsBetweenExclusiveTest14
		(new byte?((byte)1), "\t\0", new byte?((byte)1), (byte)0);
}
	}
}
