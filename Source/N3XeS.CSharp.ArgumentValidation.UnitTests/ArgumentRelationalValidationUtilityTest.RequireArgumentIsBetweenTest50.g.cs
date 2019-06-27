using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationUtilityTest.RequireArgumentIsBetweenTest50.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest50ThrowsArgumentNullException214()
{
	this.RequireArgumentIsBetweenTest50(0L, (string)null, new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest50ThrowsArgumentOutOfRangeException406()
{
	this.RequireArgumentIsBetweenTest50(0L, "", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest50ThrowsArgumentOutOfRangeException285()
{
	this.RequireArgumentIsBetweenTest50(0L, "\0", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
public void RequireArgumentIsBetweenTest50460()
{
	this.RequireArgumentIsBetweenTest50(0L, "\0", default(long?), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest50ThrowsArgumentOutOfRangeException438()
{
	this.RequireArgumentIsBetweenTest50(0L, "Ā", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest50ThrowsArgumentOutOfRangeException226()
{
	this.RequireArgumentIsBetweenTest50(1L, "Ā", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest50ThrowsArgumentOutOfRangeException908()
{
	this.RequireArgumentIsBetweenTest50(0L, "\t", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest50ThrowsArgumentOutOfRangeException581()
{
	this.RequireArgumentIsBetweenTest50(0L, "\t\0", new long?(1L), 0L);
}
	}
}
