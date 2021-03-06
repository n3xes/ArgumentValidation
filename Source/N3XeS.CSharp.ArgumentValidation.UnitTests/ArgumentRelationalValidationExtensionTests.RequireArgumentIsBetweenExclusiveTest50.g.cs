using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ArgumentRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest50.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void RequireArgumentIsBetweenExclusiveTest50ThrowsArgumentNullException343()
{
	this.RequireArgumentIsBetweenExclusiveTest50
		(0L, (string)null, new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest50ThrowsArgumentOutOfRangeException254()
{
	this.RequireArgumentIsBetweenExclusiveTest50(0L, "", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest50ThrowsArgumentOutOfRangeException261()
{
	this.RequireArgumentIsBetweenExclusiveTest50(0L, "\0", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest50ThrowsArgumentOutOfRangeException230()
{
	this.RequireArgumentIsBetweenExclusiveTest50(0L, "\0", new long?(1L), 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest50661()
{
	this.RequireArgumentIsBetweenExclusiveTest50
		(0L, "\0", new long?(long.MinValue), 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest50ThrowsArgumentOutOfRangeException168()
{
	this.RequireArgumentIsBetweenExclusiveTest50(0L, "Ā", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
public void RequireArgumentIsBetweenExclusiveTest50504()
{
	this.RequireArgumentIsBetweenExclusiveTest50(0L, "\0", default(long?), 1L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest50ThrowsArgumentOutOfRangeException901()
{
	this.RequireArgumentIsBetweenExclusiveTest50(0L, "\t", new long?(1L), 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentRelationalValidationExtensionTests))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsBetweenExclusiveTest50ThrowsArgumentOutOfRangeException976()
{
	this.RequireArgumentIsBetweenExclusiveTest50(0L, "\t\0", new long?(1L), 0L);
}
	}
}
