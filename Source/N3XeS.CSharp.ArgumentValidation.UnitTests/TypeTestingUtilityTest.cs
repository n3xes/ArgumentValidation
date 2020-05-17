// <copyright company="John Caruthers" file="TypeTestingUtilityTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Utilities;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for TypeTestingUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(TypeTestingUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class TypeTestingUtilityTest
	{

		/// <summary>Test stub for IsBoxedTypeOf(Object)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBoxedTypeOfTest<T>(object valueBoxed)
		{
			bool result = TypeTestingUtility.IsBoxedTypeOf<T>(valueBoxed);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsBoxedTypeOfTest(Object)
		}

		/// <summary>Test stub for IsNotBoxedTypeOf(Object)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotBoxedTypeOfTest<T>(object valueBoxed)
		{
			bool result = TypeTestingUtility.IsNotBoxedTypeOf<T>(valueBoxed);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsNotBoxedTypeOfTest(Object)
		}

	}
}
