using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest11.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentNullException519()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, (string)null, new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentOutOfRangeException990()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, "", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentOutOfRangeException864()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, "\0", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest118()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, "\0", default(byte?), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentOutOfRangeException857()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentOutOfRangeException672()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)128, "Ā", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentOutOfRangeException776()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, "\t", new byte?((byte)1), new byte?((byte)1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentOutOfRangeException582()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, "Ā", new byte?((byte)1), default(byte?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest11ThrowsArgumentOutOfRangeException978()
{
	this.RequireArgumentIsOutsideExclusiveTest11
		((byte)0, "\t\0", new byte?((byte)1), new byte?((byte)1));
}
	}
}
