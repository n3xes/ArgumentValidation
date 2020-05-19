using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest43.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest43ThrowsArgumentNullException175()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, (string)null, default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest43ThrowsArgumentOutOfRangeException489()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest43358()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest43ThrowsArgumentOutOfRangeException322()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "\0", default(int?), new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest43579()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "\0", new int?(0), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest43ThrowsArgumentOutOfRangeException115()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "\0", new int?(512), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest43365()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "Ā", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest43ThrowsArgumentOutOfRangeException499()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "\t", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest43860()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(1, "\t\0", default(int?), default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest43ThrowsArgumentOutOfRangeException868()
{
	this.RequireArgumentIsBetweenExclusiveTest43
		(0, "\t\t", new int?(0), new int?(1));
}
	}
}
