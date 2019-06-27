using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest24.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest24ThrowsArgumentNullException993()
{
	this.RequireArgumentIsBetweenTest24(0, (string)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest24ThrowsArgumentOutOfRangeException433()
{
	this.RequireArgumentIsBetweenTest24(0, "", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest24582()
{
	this.RequireArgumentIsBetweenTest24(0, "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest24ThrowsArgumentOutOfRangeException739()
{
	this.RequireArgumentIsBetweenTest24(1, "\0", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest24ThrowsArgumentOutOfRangeException501()
{
	this.RequireArgumentIsBetweenTest24(0, "\0", 1, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest24915()
{
	this.RequireArgumentIsBetweenTest24(0, "Ā", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest24ThrowsArgumentOutOfRangeException577()
{
	this.RequireArgumentIsBetweenTest24(0, "\t", 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest24867()
{
	this.RequireArgumentIsBetweenTest24(0, "\t\0", 0, 0);
}
	}
}
