using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest04ThrowsArgumentNullException491()
{
	this.RequireArgumentIsGreaterThanTest04((byte)0, (string)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest04ThrowsArgumentOutOfRangeException623()
{
	this.RequireArgumentIsGreaterThanTest04((byte)0, "", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest04ThrowsArgumentOutOfRangeException672()
{
	this.RequireArgumentIsGreaterThanTest04((byte)0, "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest04411()
{
	this.RequireArgumentIsGreaterThanTest04((byte)1, "\0", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest04ThrowsArgumentOutOfRangeException767()
{
	this.RequireArgumentIsGreaterThanTest04((byte)0, "Ā", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest04ThrowsArgumentOutOfRangeException897()
{
	this.RequireArgumentIsGreaterThanTest04((byte)0, "\t", (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest04ThrowsArgumentOutOfRangeException997()
{
	this.RequireArgumentIsGreaterThanTest04((byte)0, "\t\t", (byte)0);
}
	}
}
