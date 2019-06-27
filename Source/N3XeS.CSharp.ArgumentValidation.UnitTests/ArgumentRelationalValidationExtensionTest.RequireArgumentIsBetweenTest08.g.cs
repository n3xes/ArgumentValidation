using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest08ThrowsArgumentNullException772()
{
	this.RequireArgumentIsBetweenTest08((byte)0, (string)null, (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest08ThrowsArgumentOutOfRangeException495()
{
	this.RequireArgumentIsBetweenTest08((byte)0, "", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest08895()
{
	this.RequireArgumentIsBetweenTest08((byte)0, "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest08ThrowsArgumentOutOfRangeException470()
{
	this.RequireArgumentIsBetweenTest08((byte)1, "\0", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest08ThrowsArgumentOutOfRangeException717()
{
	this.RequireArgumentIsBetweenTest08((byte)1, "\0", (byte)2, (byte)128);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest08586()
{
	this.RequireArgumentIsBetweenTest08((byte)0, "Ā", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest08ThrowsArgumentOutOfRangeException656()
{
	this.RequireArgumentIsBetweenTest08((byte)0, "\t", (byte)0, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest0858601()
{
	this.RequireArgumentIsBetweenTest08((byte)0, "\t\0", (byte)0, (byte)0);
}
	}
}
