using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenTest45.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest45ThrowsArgumentNullException736()
{
	this.RequireArgumentIsBetweenTest45
		(default(int?), (string)null, 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest45ThrowsArgumentOutOfRangeException220()
{
	this.RequireArgumentIsBetweenTest45(default(int?), "", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest4580()
{
	this.RequireArgumentIsBetweenTest45(default(int?), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest45ThrowsArgumentOutOfRangeException872()
{
	this.RequireArgumentIsBetweenTest45(new int?(0), "\0", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest45870()
{
	this.RequireArgumentIsBetweenTest45(default(int?), "Ȁ", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest45ThrowsArgumentOutOfRangeException181()
{
	this.RequireArgumentIsBetweenTest45(new int?(0), "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest45ThrowsArgumentOutOfRangeException365()
{
	this.RequireArgumentIsBetweenTest45(default(int?), "\t", 1, default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest45ThrowsArgumentOutOfRangeException903()
{
	this.RequireArgumentIsBetweenTest45(new int?(1), "\0", 1, new int?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest45702()
{
	this.RequireArgumentIsBetweenTest45(default(int?), "\t\0", 1, default(int?));
}
	}
}
