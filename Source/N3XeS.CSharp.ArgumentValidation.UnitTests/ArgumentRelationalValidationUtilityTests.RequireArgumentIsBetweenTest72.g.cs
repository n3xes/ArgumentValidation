using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTests.RequireArgumentIsBetweenTest72.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	public partial class ArgumentRelationalValidationUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTest72ThrowsArgumentNullException862()
{
	this.RequireArgumentIsBetweenTest72(0u, (string)null, 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest72ThrowsArgumentOutOfRangeException268()
{
	this.RequireArgumentIsBetweenTest72(0u, "", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest72582()
{
	this.RequireArgumentIsBetweenTest72(0u, "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest72ThrowsArgumentOutOfRangeException246()
{
	this.RequireArgumentIsBetweenTest72(1u, "\0", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest72ThrowsArgumentOutOfRangeException888()
{
	this.RequireArgumentIsBetweenTest72(1022u, "\0", 1023u, 1022u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest72915()
{
	this.RequireArgumentIsBetweenTest72(0u, "Ā", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest72ThrowsArgumentOutOfRangeException469()
{
	this.RequireArgumentIsBetweenTest72(0u, "\t", 0u, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTests))]
public void RequireArgumentIsBetweenTest72867()
{
	this.RequireArgumentIsBetweenTest72(0u, "\t\0", 0u, 0u);
}
	}
}
