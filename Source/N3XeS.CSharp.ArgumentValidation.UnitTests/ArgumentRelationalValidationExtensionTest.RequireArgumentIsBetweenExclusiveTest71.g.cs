using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest71.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest71ThrowsArgumentNullException866()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(default(short?), (string)null, default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest71ThrowsArgumentOutOfRangeException436()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(default(short?), "", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest71668()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(default(short?), "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest71716()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(new short?((short)0), "\0", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest71ThrowsArgumentOutOfRangeException537()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(new short?((short)0), "\0", new short?((short)0), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest71ThrowsArgumentOutOfRangeException527()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(new short?((short)0), "\0", default(short?), new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest71480()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(default(short?), "Ȁ", new short?((short)65), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest71ThrowsArgumentOutOfRangeException849()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(default(short?), "\t", default(short?), default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest71166()
{
	this.RequireArgumentIsBetweenExclusiveTest71
		(default(short?), "\t\0", default(short?), default(short?));
}
	}
}
