using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest45.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest45ThrowsArgumentNullException231()
{
	this.RequireArgumentIsBetweenExclusiveTest45
		(default(int?), (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest45ThrowsArgumentOutOfRangeException98()
{
	this.RequireArgumentIsBetweenExclusiveTest45
		(default(int?), "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest4580()
{
	this.RequireArgumentIsBetweenExclusiveTest45
		(default(int?), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest45ThrowsArgumentOutOfRangeException123()
{
	this.RequireArgumentIsBetweenExclusiveTest45
		(new int?(0), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest45870()
{
	this.RequireArgumentIsBetweenExclusiveTest45
		(default(int?), "Ȁ", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest45ThrowsArgumentOutOfRangeException668()
{
	this.RequireArgumentIsBetweenExclusiveTest45(new int?(0), "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest45ThrowsArgumentOutOfRangeException189()
{
	this.RequireArgumentIsBetweenExclusiveTest45
		(default(int?), "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest45702()
{
	this.RequireArgumentIsBetweenExclusiveTest45
		(default(int?), "\t\0", 1, default(int?));
}
	}
}
