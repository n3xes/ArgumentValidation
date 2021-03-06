using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideTest78.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideTest78ThrowsArgumentNullException84()
{
	this.RequireArgumentIsOutsideTest78
		(new uint?(512u), (string)null, new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest78ThrowsArgumentOutOfRangeException682()
{
	this.RequireArgumentIsOutsideTest78(new uint?(1u), "", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest78806()
{
	this.RequireArgumentIsOutsideTest78(new uint?(1u), "\0", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest78ThrowsArgumentOutOfRangeException488()
{
	this.RequireArgumentIsOutsideTest78(new uint?(33u), "\0", new uint?(32u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest78ThrowsArgumentOutOfRangeException768()
{
	this.RequireArgumentIsOutsideTest78
		(new uint?(1021u), "\0", new uint?(1021u), 1022u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest78ThrowsArgumentOutOfRangeException978()
{
	this.RequireArgumentIsOutsideTest78(new uint?(2u), "耀", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest78580()
{
	this.RequireArgumentIsOutsideTest78(new uint?(2u), "耀", default(uint?), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideTest78ThrowsArgumentOutOfRangeException777()
{
	this.RequireArgumentIsOutsideTest78(new uint?(1u), "\t", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest7837()
{
	this.RequireArgumentIsOutsideTest78(default(uint?), "耀", new uint?(1u), 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideTest78446()
{
	this.RequireArgumentIsOutsideTest78(new uint?(1u), "\t\0", new uint?(1u), 0u);
}
	}
}
