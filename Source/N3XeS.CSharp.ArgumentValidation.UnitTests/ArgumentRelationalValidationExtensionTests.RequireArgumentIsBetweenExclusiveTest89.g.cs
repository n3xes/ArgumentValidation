using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest89.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest89ThrowsArgumentNullException543()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)65, (string)null, (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest89ThrowsArgumentOutOfRangeException735()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)65, "", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest89ThrowsArgumentOutOfRangeException654()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)65, "\0", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest89ThrowsArgumentOutOfRangeException325()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)65, "\0", (ushort)65, new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest896()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)67, "\0", (ushort)66, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest89ThrowsArgumentOutOfRangeException627()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)65, "Ā", (ushort)65, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest89ThrowsArgumentOutOfRangeException300()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)33, "\t", (ushort)33, default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest89ThrowsArgumentOutOfRangeException611()
{
	this.RequireArgumentIsBetweenExclusiveTest89
		((ushort)65, "\t\0", (ushort)65, default(ushort?));
}
	}
}
