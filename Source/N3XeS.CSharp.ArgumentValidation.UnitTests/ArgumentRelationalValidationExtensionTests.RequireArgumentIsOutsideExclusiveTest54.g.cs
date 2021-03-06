using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest54.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsOutsideExclusiveTest54ThrowsArgumentNullException43()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(1L), (string)null, new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest54ThrowsArgumentOutOfRangeException895()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(1L), "", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest54ThrowsArgumentOutOfRangeException528()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(1L), "\0", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest54648()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(default(long?), "\0", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsOutsideExclusiveTest54615()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(2L), "\0", new long?(1L), 3L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest54ThrowsArgumentOutOfRangeException677()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(long.MinValue), "\0", new long?(long.MinValue), 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest54ThrowsArgumentOutOfRangeException27()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(1L), "Ā", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest54ThrowsArgumentOutOfRangeException582()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(1L), "\t", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsOutsideExclusiveTest54ThrowsArgumentOutOfRangeException939()
{
	this.RequireArgumentIsOutsideExclusiveTest54
		(new long?(1L), "\t\0", new long?(1L), 0L);
}
	}
}
