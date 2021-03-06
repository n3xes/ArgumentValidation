using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenTest70.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest70ThrowsArgumentNullException377()
{
	this.RequireArgumentIsBetweenTest70
		(new short?((short)33), (string)null, new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest70ThrowsArgumentOutOfRangeException311()
{
	this.RequireArgumentIsBetweenTest70
		(new short?((short)64), "", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest70ThrowsArgumentOutOfRangeException488()
{
	this.RequireArgumentIsBetweenTest70
		(new short?((short)65), "\0", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest70538()
{
	this.RequireArgumentIsBetweenTest70
		(default(short?), "\0", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest70ThrowsArgumentOutOfRangeException493()
{
	this.RequireArgumentIsBetweenTest70
		(new short?((short)32), "\0", new short?((short)33), (short)33);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest70ThrowsArgumentOutOfRangeException306()
{
	this.RequireArgumentIsBetweenTest70
		(new short?((short)65), "Ȁ", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest70ThrowsArgumentOutOfRangeException612()
{
	this.RequireArgumentIsBetweenTest70
		(new short?((short)65), "\t", new short?((short)33), (short)64);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest70694()
{
	this.RequireArgumentIsBetweenTest70
		(default(short?), "\t\0", default(short?), (short)65);
}
	}
}
