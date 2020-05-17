using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest11.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class ArgumentIntegralParityValidationUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void RequireArgumentIsEvenTest11ThrowsArgumentNullException603()
{
	this.RequireArgumentIsEvenTest11(default(short?), (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest11912()
{
	this.RequireArgumentIsEvenTest11(default(short?), "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest11894()
{
	this.RequireArgumentIsEvenTest11(default(short?), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest11ThrowsArgumentOutOfRangeException378()
{
	this.RequireArgumentIsEvenTest11(default(short?), "\t\t");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
public void RequireArgumentIsEvenTest11253()
{
	this.RequireArgumentIsEvenTest11(new short?((short)0), "Ā");
}

[TestMethod]
[PexGeneratedBy(typeof(ArgumentIntegralParityValidationUtilityTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void RequireArgumentIsEvenTest11ThrowsArgumentOutOfRangeException775()
{
	this.RequireArgumentIsEvenTest11(new short?((short)95), "Ā");
}
	}
}
