using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest05ThrowsArgumentNullException18()
{
	this.RequireArgumentIsBetweenExclusiveTest05(default(DateTime?), (string)null, 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest05ThrowsArgumentOutOfRangeException373()
{
	this.RequireArgumentIsBetweenExclusiveTest05(default(DateTime?), "", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest05356()
{
	this.RequireArgumentIsBetweenExclusiveTest05(default(DateTime?), "\0", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest05ThrowsArgumentOutOfRangeException445()
{
	this.RequireArgumentIsBetweenExclusiveTest05
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest05802()
{
	this.RequireArgumentIsBetweenExclusiveTest05(default(DateTime?), "Ā", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest05ThrowsArgumentOutOfRangeException510()
{
	this.RequireArgumentIsBetweenExclusiveTest05
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest05ThrowsArgumentOutOfRangeException784()
{
	this.RequireArgumentIsBetweenExclusiveTest05(default(DateTime?), "\t", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest05997()
{
	this.RequireArgumentIsBetweenExclusiveTest05(default(DateTime?), "\t\0", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}
	}
}
