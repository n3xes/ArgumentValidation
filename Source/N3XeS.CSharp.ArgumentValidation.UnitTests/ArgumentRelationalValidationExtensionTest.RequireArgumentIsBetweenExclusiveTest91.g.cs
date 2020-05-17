using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest91.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest91ThrowsArgumentNullException225()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, (string)null, default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest91ThrowsArgumentOutOfRangeException238()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, "", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest916()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, "\0", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest91ThrowsArgumentOutOfRangeException665()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, "\0", default(ushort?), new ushort?((ushort)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest9161()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, "\0", new ushort?((ushort)0), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest91ThrowsArgumentOutOfRangeException914()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)32, "\0", new ushort?((ushort)32), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest91451()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, "Ā", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest91ThrowsArgumentOutOfRangeException373()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, "\t", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest9132()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)65, "\t\0", default(ushort?), default(ushort?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest91ThrowsArgumentOutOfRangeException198()
{
	this.RequireArgumentIsBetweenExclusiveTest91
		((ushort)64, "\t\t", new ushort?((ushort)65), new ushort?((ushort)65));
}
	}
}
