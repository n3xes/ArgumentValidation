using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest56.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenTest56ThrowsArgumentNullException756()
{
	this.RequireArgumentIsBetweenTest56((sbyte)0, (string)null, (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest56ThrowsArgumentOutOfRangeException88()
{
	this.RequireArgumentIsBetweenTest56((sbyte)0, "", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest56895()
{
	this.RequireArgumentIsBetweenTest56((sbyte)0, "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest56ThrowsArgumentOutOfRangeException836()
{
	this.RequireArgumentIsBetweenTest56((sbyte)1, "\0", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest56ThrowsArgumentOutOfRangeException614()
{
	this.RequireArgumentIsBetweenTest56
		((sbyte)(-127), "\0", (sbyte)(-126), (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest56586()
{
	this.RequireArgumentIsBetweenTest56((sbyte)0, "Ā", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenTest56ThrowsArgumentOutOfRangeException514()
{
	this.RequireArgumentIsBetweenTest56((sbyte)0, "\t", (sbyte)0, (sbyte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTest))]
public void RequireArgumentIsBetweenTest5658601()
{
	this.RequireArgumentIsBetweenTest56((sbyte)0, "\t\0", (sbyte)0, (sbyte)0);
}
	}
}
