using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentSignedIntegralNumberValidationExtensionTests.RequireArgumentIsNegativeTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentSignedIntegralNumberValidationExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsNegativeTest05ThrowsArgumentNullException270()
{
	this.RequireArgumentIsNegativeTest05(new long?(1L), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest05ThrowsArgumentOutOfRangeException392()
{
	this.RequireArgumentIsNegativeTest05(new long?(1L), "");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest05ThrowsArgumentOutOfRangeException81()
{
	this.RequireArgumentIsNegativeTest05(new long?(1L), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
public void RequireArgumentIsNegativeTest05912()
{
	this.RequireArgumentIsNegativeTest05(default(long?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest05ThrowsArgumentOutOfRangeException758()
{
	this.RequireArgumentIsNegativeTest05(new long?(1L), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest05ThrowsArgumentOutOfRangeException370()
{
	this.RequireArgumentIsNegativeTest05(new long?(1L), "\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentSignedIntegralNumberValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsNegativeTest05ThrowsArgumentOutOfRangeException590()
{
	this.RequireArgumentIsNegativeTest05(new long?(1L), "\t\t");
}
	}
}
