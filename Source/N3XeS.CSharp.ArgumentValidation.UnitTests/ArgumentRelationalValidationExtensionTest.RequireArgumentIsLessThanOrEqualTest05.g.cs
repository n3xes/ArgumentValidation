using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentNullException516()
{
	this.RequireArgumentIsLessThanOrEqualTest05
		((byte)0, (string)null, new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException915()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest05843()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\0", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest05359()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\0", default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException464()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)3, "\0", new byte?((byte)2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanOrEqualTest05801()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "Ā", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException748()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\t", new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanOrEqualTest05ThrowsArgumentOutOfRangeException394()
{
	this.RequireArgumentIsLessThanOrEqualTest05((byte)0, "\t\t", new byte?((byte)1));
}
	}
}
