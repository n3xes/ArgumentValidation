using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest92.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest92ThrowsArgumentNullException813()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)65), (string)null, (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest92ThrowsArgumentOutOfRangeException578()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)65), "", (ushort)32, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest92ThrowsArgumentOutOfRangeException55()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)65), "\0", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest92684()
{
	this.RequireArgumentIsBetweenTest92
		(default(ushort?), "\0", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest92429()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)60), "\0", (ushort)32, (ushort)60);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest92ThrowsArgumentOutOfRangeException154()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)33), "\0", (ushort)34, (ushort)48);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest92ThrowsArgumentOutOfRangeException550()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)65), "Ā", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest92ThrowsArgumentOutOfRangeException675()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)65), "\t", (ushort)32, (ushort)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest92ThrowsArgumentOutOfRangeException14()
{
	this.RequireArgumentIsBetweenTest92
		(new ushort?((ushort)65), "\t\0", (ushort)32, (ushort)64);
}
	}
}
