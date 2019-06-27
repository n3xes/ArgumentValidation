using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest91.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest91ThrowsArgumentNullException908()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, (string)null, default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException799()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest916()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\0", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException242()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\0", default(ushort?), new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest9161()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\0", new ushort?((ushort)0), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException822()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)32, "\0", new ushort?((ushort)33), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest91451()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "Ā", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException604()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\t", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest9132()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)65, "\t\0", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest91ThrowsArgumentOutOfRangeException15()
{
	this.RequireArgumentIsBetweenTest91
		((ushort)33, "\t\t", new ushort?((ushort)96), new ushort?((ushort)48));
}
	}
}
