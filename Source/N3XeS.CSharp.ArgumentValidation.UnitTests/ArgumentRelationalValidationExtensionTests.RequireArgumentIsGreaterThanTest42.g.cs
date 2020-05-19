using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest42.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentNullException332()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), (string)null, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException468()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest42223()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest4239()
{
	this.RequireArgumentIsGreaterThanTest42(default(ulong?), "\0", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException87()
{
	this.RequireArgumentIsGreaterThanTest42
		(new ulong?(1uL), "\0", 9223372036854775808uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsGreaterThanTest42808()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "Ā", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException930()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "\t", 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsGreaterThanTest42ThrowsArgumentOutOfRangeException374()
{
	this.RequireArgumentIsGreaterThanTest42(new ulong?(1uL), "\t\t", 0uL);
}
	}
}
