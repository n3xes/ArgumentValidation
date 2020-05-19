using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenTest52.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest52ThrowsArgumentNullException394()
{
	this.RequireArgumentIsBetweenTest52(new long?(1L), (string)null, 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest52ThrowsArgumentOutOfRangeException560()
{
	this.RequireArgumentIsBetweenTest52(new long?(1L), "", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest52ThrowsArgumentOutOfRangeException356()
{
	this.RequireArgumentIsBetweenTest52(new long?(1L), "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest52760()
{
	this.RequireArgumentIsBetweenTest52(default(long?), "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest52ThrowsArgumentOutOfRangeException738()
{
	this.RequireArgumentIsBetweenTest52
		(new long?(-9223372036854775807L), "\0", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest52ThrowsArgumentOutOfRangeException241()
{
	this.RequireArgumentIsBetweenTest52(new long?(1L), "Ā", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest52ThrowsArgumentOutOfRangeException174()
{
	this.RequireArgumentIsBetweenTest52(new long?(1L), "\t", 0L, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest52ThrowsArgumentOutOfRangeException762()
{
	this.RequireArgumentIsBetweenTest52(new long?(1L), "\t\0", 0L, 0L);
}
	}
}
