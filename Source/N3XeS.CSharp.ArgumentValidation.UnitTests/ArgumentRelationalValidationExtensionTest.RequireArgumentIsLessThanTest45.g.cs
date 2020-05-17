using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest45.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsLessThanTest45ThrowsArgumentNullException93()
{
	this.RequireArgumentIsLessThanTest45((ushort)65, (string)null, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest45ThrowsArgumentOutOfRangeException969()
{
	this.RequireArgumentIsLessThanTest45((ushort)65, "", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanTest45787()
{
	this.RequireArgumentIsLessThanTest45((ushort)65, "\0", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest45ThrowsArgumentOutOfRangeException646()
{
	this.RequireArgumentIsLessThanTest45((ushort)65, "\0", new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsLessThanTest45857()
{
	this.RequireArgumentIsLessThanTest45((ushort)65, "Ā", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest45ThrowsArgumentOutOfRangeException694()
{
	this.RequireArgumentIsLessThanTest45((ushort)65, "\t", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsLessThanTest45ThrowsArgumentOutOfRangeException812()
{
	this.RequireArgumentIsLessThanTest45((ushort)65, "\n\t", default(ushort?));
}
	}
}
