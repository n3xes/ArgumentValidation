using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest25.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentRelationalValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsBetweenTest25ThrowsArgumentNullException98()
{
	this.RequireArgumentIsBetweenTest25(0, (string)null, 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest25ThrowsArgumentOutOfRangeException345()
{
	this.RequireArgumentIsBetweenTest25(0, "", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest25582()
{
	this.RequireArgumentIsBetweenTest25(0, "\0", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest25ThrowsArgumentOutOfRangeException193()
{
	this.RequireArgumentIsBetweenTest25(0, "\0", 0, new double?(-1));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest25ThrowsArgumentOutOfRangeException455()
{
	this.RequireArgumentIsBetweenTest25(0, "\0", 1, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest25915()
{
	this.RequireArgumentIsBetweenTest25(0, "Ā", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest25697()
{
	this.RequireArgumentIsBetweenTest25(0, "Ā", 0, default(double?));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest25ThrowsArgumentOutOfRangeException33()
{
	this.RequireArgumentIsBetweenTest25(0, "\t", 0, new double?(0));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest25623()
{
	this.RequireArgumentIsBetweenTest25(0, "\n\0", 0, new double?(0));
}
	}
}
