using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest72.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest72ThrowsArgumentNullException750()
{
	this.RequireArgumentIsOutsideTest72(0u, (string)null, 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest72ThrowsArgumentOutOfRangeException852()
{
	this.RequireArgumentIsOutsideTest72(0u, "", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest72582()
{
	this.RequireArgumentIsOutsideTest72(0u, "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest72ThrowsArgumentOutOfRangeException322()
{
	this.RequireArgumentIsOutsideTest72(1u, "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest72ThrowsArgumentOutOfRangeException567()
{
	this.RequireArgumentIsOutsideTest72(1022u, "\0", 1022u, 1023u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest72915()
{
	this.RequireArgumentIsOutsideTest72(0u, "Ā", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest72ThrowsArgumentOutOfRangeException214()
{
	this.RequireArgumentIsOutsideTest72(0u, "\t", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest72867()
{
	this.RequireArgumentIsOutsideTest72(0u, "\t\0", 0u, 0u);
}
	}
}
