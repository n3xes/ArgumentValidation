using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest65.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest65ThrowsArgumentNullException453()
{
	this.RequireArgumentIsOutsideTest65
		((short)65, (string)null, (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest65ThrowsArgumentOutOfRangeException863()
{
	this.RequireArgumentIsOutsideTest65((short)65, "", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest65885()
{
	this.RequireArgumentIsOutsideTest65((short)65, "\0", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest65ThrowsArgumentOutOfRangeException874()
{
	this.RequireArgumentIsOutsideTest65((short)33, "\0", (short)32, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest65545()
{
	this.RequireArgumentIsOutsideTest65
		((short)65, "\0", (short)65, new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest65ThrowsArgumentOutOfRangeException930()
{
	this.RequireArgumentIsOutsideTest65
		((short)32, "\0", (short)66, new short?((short)33));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest65598()
{
	this.RequireArgumentIsOutsideTest65((short)65, "Ā", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest65ThrowsArgumentOutOfRangeException967()
{
	this.RequireArgumentIsOutsideTest65((short)33, "\t", (short)33, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsOutsideTest6571()
{
	this.RequireArgumentIsOutsideTest65
		((short)65, "\t\0", (short)65, default(short?));
}
	}
}
