using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest07ThrowsArgumentNullException10()
{
	this.RequireArgumentIsBetweenTest07
		(default(DateTime?), (string)null, default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException575()
{
	this.RequireArgumentIsBetweenTest07
		(default(DateTime?), "", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07668()
{
	this.RequireArgumentIsBetweenTest07
		(default(DateTime?), "\0", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07910()
{
	this.RequireArgumentIsBetweenTest07(new DateTime?(default(DateTime)), "\0", 
										default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07427()
{
	this.RequireArgumentIsBetweenTest07(new DateTime?(default(DateTime)), "\0", 
										new DateTime?(default(DateTime)), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException510()
{
	this.RequireArgumentIsBetweenTest07(new DateTime?(default(DateTime)), "\0", 
										new DateTime?(new DateTime(4611686018427387903L & 134217728L, 
																   (DateTimeKind)(134217728uL >> 62))), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest0744()
{
	this.RequireArgumentIsBetweenTest07(new DateTime?(default(DateTime)), "\0", 
										default(DateTime?), new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07703()
{
	this.RequireArgumentIsBetweenTest07
		(default(DateTime?), "Ā", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException968()
{
	this.RequireArgumentIsBetweenTest07
		(new DateTime?(new DateTime(4611686018427387903L & 134217728L, 
									(DateTimeKind)(134217728uL >> 62))), "\0", 
		 default(DateTime?), new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest07ThrowsArgumentOutOfRangeException465()
{
	this.RequireArgumentIsBetweenTest07
		(default(DateTime?), "\t", default(DateTime?), default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest07166()
{
	this.RequireArgumentIsBetweenTest07
		(default(DateTime?), "\t\0", default(DateTime?), default(DateTime?));
}
	}
}
