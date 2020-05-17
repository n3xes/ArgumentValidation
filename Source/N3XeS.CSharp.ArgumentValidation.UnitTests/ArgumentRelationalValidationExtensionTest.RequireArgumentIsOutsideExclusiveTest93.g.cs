using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest93.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest93ThrowsArgumentNullException66()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(default(ushort?), (string)null, (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest93ThrowsArgumentOutOfRangeException214()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(default(ushort?), "", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest93258()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(default(ushort?), "\0", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest93ThrowsArgumentOutOfRangeException826()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(new ushort?((ushort)0), "\0", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest9365()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(default(ushort?), "Ā", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest93ThrowsArgumentOutOfRangeException610()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(new ushort?((ushort)0), "\0", (ushort)65, new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest93ThrowsArgumentOutOfRangeException265()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(default(ushort?), "\t", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideExclusiveTest93916()
{
	this.RequireArgumentIsOutsideExclusiveTest93
		(default(ushort?), "\t\0", (ushort)65, default(ushort?));
}
	}
}
