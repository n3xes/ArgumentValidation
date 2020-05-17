using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest65.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest65ThrowsArgumentNullException528()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)65, (string)null, (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest65ThrowsArgumentOutOfRangeException904()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)65, "", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest65ThrowsArgumentOutOfRangeException302()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)65, "\0", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest65ThrowsArgumentOutOfRangeException440()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)65, "\0", (short)65, new short?((short)0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenExclusiveTest6560()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)33, "\0", (short)32, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest65ThrowsArgumentOutOfRangeException662()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)65, "Ā", (short)65, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest65ThrowsArgumentOutOfRangeException882()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)33, "\t", (short)33, default(short?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest65ThrowsArgumentOutOfRangeException791()
{
	this.RequireArgumentIsBetweenExclusiveTest65
		((short)65, "\t\0", (short)65, default(short?));
}
	}
}
