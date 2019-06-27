using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest10.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest10ThrowsArgumentNullException634()
{
	this.RequireArgumentIsOutsideTest10
		((byte)0, (string)null, new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest10ThrowsArgumentOutOfRangeException797()
{
	this.RequireArgumentIsOutsideTest10((byte)0, "", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest10521()
{
	this.RequireArgumentIsOutsideTest10((byte)0, "\0", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest10ThrowsArgumentOutOfRangeException74()
{
	this.RequireArgumentIsOutsideTest10((byte)3, "\0", new byte?((byte)2), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest10ThrowsArgumentOutOfRangeException944()
{
	this.RequireArgumentIsOutsideTest10
		((byte)1, "\0", new byte?((byte)128), (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest10990()
{
	this.RequireArgumentIsOutsideTest10((byte)0, "Ā", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest10664()
{
	this.RequireArgumentIsOutsideTest10((byte)0, "Ā", default(byte?), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest10ThrowsArgumentOutOfRangeException211()
{
	this.RequireArgumentIsOutsideTest10((byte)0, "\t", new byte?((byte)1), (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest10937()
{
	this.RequireArgumentIsOutsideTest10
		((byte)0, "\t\0", new byte?((byte)1), (byte)0);
}
	}
}
