using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest06.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest06ThrowsArgumentNullException995()
{
	this.RequireArgumentIsLessThanOrEqualTest06
		(new byte?((byte)1), (string)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest06ThrowsArgumentOutOfRangeException657()
{
	this.RequireArgumentIsLessThanOrEqualTest06(new byte?((byte)1), "", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest06ThrowsArgumentOutOfRangeException185()
{
	this.RequireArgumentIsLessThanOrEqualTest06(new byte?((byte)1), "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest06904()
{
	this.RequireArgumentIsLessThanOrEqualTest06(default(byte?), "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest06ThrowsArgumentOutOfRangeException637()
{
	this.RequireArgumentIsLessThanOrEqualTest06(new byte?((byte)1), "Ā", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest06ThrowsArgumentOutOfRangeException349()
{
	this.RequireArgumentIsLessThanOrEqualTest06(new byte?((byte)1), "\t", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest06ThrowsArgumentOutOfRangeException117()
{
	this.RequireArgumentIsLessThanOrEqualTest06(new byte?((byte)1), "\t\t", (byte)0);
}
	}
}
