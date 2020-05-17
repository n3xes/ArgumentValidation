using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest36.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest36ThrowsArgumentNullException702()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)0), (string)null, (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest36ThrowsArgumentOutOfRangeException353()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)0), "", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest36582()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)0), "\0", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest36ThrowsArgumentOutOfRangeException913()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)(-1)), "\0", (float)0, (float)(-2));
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest36ThrowsArgumentOutOfRangeException602()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)(-1)), "\0", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest36915()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)0), "Ā", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest36856()
{
	this.RequireArgumentIsBetweenTest36(default(float?), "Ā", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest36ThrowsArgumentOutOfRangeException158()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)0), "\t", (float)0, (float)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest36623()
{
	this.RequireArgumentIsBetweenTest36
		(new float?((float)0), "\n\0", (float)0, (float)0);
}
	}
}
