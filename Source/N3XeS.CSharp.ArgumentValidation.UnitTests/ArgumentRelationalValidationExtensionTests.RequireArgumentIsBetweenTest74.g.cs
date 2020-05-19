using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenTest74.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest74ThrowsArgumentNullException399()
{
	this.RequireArgumentIsBetweenTest74(0u, (string)null, new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest74ThrowsArgumentOutOfRangeException64()
{
	this.RequireArgumentIsBetweenTest74(0u, "", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest74ThrowsArgumentOutOfRangeException405()
{
	this.RequireArgumentIsBetweenTest74(0u, "\0", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenTest74460()
{
	this.RequireArgumentIsBetweenTest74(0u, "\0", default(uint?), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest74ThrowsArgumentOutOfRangeException845()
{
	this.RequireArgumentIsBetweenTest74(0u, "Ā", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest74ThrowsArgumentOutOfRangeException772()
{
	this.RequireArgumentIsBetweenTest74(3u, "Ā", new uint?(1u), 2u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest74ThrowsArgumentOutOfRangeException358()
{
	this.RequireArgumentIsBetweenTest74(0u, "\t", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest74ThrowsArgumentOutOfRangeException824()
{
	this.RequireArgumentIsBetweenTest74(0u, "\t\0", new uint?(1u), 0u);
}
	}
}
