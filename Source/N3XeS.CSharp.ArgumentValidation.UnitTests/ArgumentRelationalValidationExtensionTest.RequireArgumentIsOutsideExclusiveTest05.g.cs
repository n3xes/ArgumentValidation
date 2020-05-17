using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentNullException408()
{
	this.RequireArgumentIsOutsideExclusiveTest05(default(DateTime?), (string)null, 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException675()
{
	this.RequireArgumentIsOutsideExclusiveTest05(default(DateTime?), "", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest05356()
{
	this.RequireArgumentIsOutsideExclusiveTest05(default(DateTime?), "\0", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException769()
{
	this.RequireArgumentIsOutsideExclusiveTest05
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest05802()
{
	this.RequireArgumentIsOutsideExclusiveTest05(default(DateTime?), "Ā", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException323()
{
	this.RequireArgumentIsOutsideExclusiveTest05
		(new DateTime?(default(DateTime)), "\0", 
		 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
		 new DateTime?(default(DateTime)));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest05ThrowsArgumentOutOfRangeException914()
{
	this.RequireArgumentIsOutsideExclusiveTest05(default(DateTime?), "\t", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest05997()
{
	this.RequireArgumentIsOutsideExclusiveTest05(default(DateTime?), "\t\0", 
												 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
												 default(DateTime?));
}
	}
}
