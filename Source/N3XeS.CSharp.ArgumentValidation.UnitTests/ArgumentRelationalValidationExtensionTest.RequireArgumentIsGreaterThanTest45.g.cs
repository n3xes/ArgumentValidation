using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest45.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest45ThrowsArgumentNullException896()
{
	this.RequireArgumentIsGreaterThanTest45
		((ushort)65, (string)null, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest45ThrowsArgumentOutOfRangeException793()
{
	this.RequireArgumentIsGreaterThanTest45((ushort)65, "", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest45208()
{
	this.RequireArgumentIsGreaterThanTest45((ushort)65, "\0", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest45933()
{
	this.RequireArgumentIsGreaterThanTest45
		((ushort)65, "\0", new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest45ThrowsArgumentOutOfRangeException566()
{
	this.RequireArgumentIsGreaterThanTest45
		((ushort)64, "\0", new ushort?((ushort)65));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsGreaterThanTest45884()
{
	this.RequireArgumentIsGreaterThanTest45((ushort)65, "Ā", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest45ThrowsArgumentOutOfRangeException939()
{
	this.RequireArgumentIsGreaterThanTest45((ushort)65, "\t", default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest45ThrowsArgumentOutOfRangeException517()
{
	this.RequireArgumentIsGreaterThanTest45((ushort)65, "\n\t", default(ushort?));
}
	}
}
