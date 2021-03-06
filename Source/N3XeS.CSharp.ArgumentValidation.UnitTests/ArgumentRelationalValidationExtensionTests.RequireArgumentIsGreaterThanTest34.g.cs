using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest34.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest34ThrowsArgumentNullException199()
{
	this.RequireArgumentIsGreaterThanTest34
		(new short?((short)65), (string)null, (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest34ThrowsArgumentOutOfRangeException779()
{
	this.RequireArgumentIsGreaterThanTest34(new short?((short)65), "", (short)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest34384()
{
	this.RequireArgumentIsGreaterThanTest34(new short?((short)65), "\0", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest34268()
{
	this.RequireArgumentIsGreaterThanTest34(default(short?), "\0", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest34ThrowsArgumentOutOfRangeException302()
{
	this.RequireArgumentIsGreaterThanTest34(new short?((short)0), "\0", (short)65);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest34884()
{
	this.RequireArgumentIsGreaterThanTest34(new short?((short)65), "Ā", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest34ThrowsArgumentOutOfRangeException150()
{
	this.RequireArgumentIsGreaterThanTest34(new short?((short)65), "\t", (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest34ThrowsArgumentOutOfRangeException544()
{
	this.RequireArgumentIsGreaterThanTest34
		(new short?((short)65), "\t\t", (short)64);
}
	}
}
