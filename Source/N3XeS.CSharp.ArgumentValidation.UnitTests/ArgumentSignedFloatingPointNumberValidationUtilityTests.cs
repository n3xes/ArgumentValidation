// <copyright file="ArgumentSignedFloatingPointNumberValidationUtilityTests.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Utilities;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentSignedFloatingPointNumberValidationUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentSignedFloatingPointNumberValidationUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentSignedFloatingPointNumberValidationUtilityTests
	{

		/// <summary>Test stub for RequireArgumentIsNegative(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest(double valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsNegativeTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest01(double? valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsNegativeTest01(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest02(float valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsNegativeTest02(Single, String)
		}

		/// <summary>Test stub for RequireArgumentIsNegative(Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsNegativeTest03(float? valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsNegative
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsNegativeTest03(Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest(double valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsPositiveTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest01(double? valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsPositiveTest01(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest02(float valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsPositiveTest02(Single, String)
		}

		/// <summary>Test stub for RequireArgumentIsPositive(Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsPositiveTest03(float? valueArgument, string nameArgument)
		{
			ArgumentSignedFloatingPointNumberValidationUtility.RequireArgumentIsPositive
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentSignedFloatingPointNumberValidationUtilityTests.RequireArgumentIsPositiveTest03(Nullable`1<Single>, String)
		}
	}
}
