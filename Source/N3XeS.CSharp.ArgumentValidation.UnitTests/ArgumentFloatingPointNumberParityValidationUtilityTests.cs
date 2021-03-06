using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Utilities;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentFloatingPointNumberParityValidationUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentFloatingPointNumberParityValidationUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentFloatingPointNumberParityValidationUtilityTests
	{

		/// <summary>Test stub for RequireArgumentIsEven(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest(double valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsEvenTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest01(double? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsEvenTest01(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest02(float valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsEvenTest02(Single, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest03(float? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsEven
				(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsEvenTest03(Nullable`1<Single>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Double, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest(double valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsOddTest(Double, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Double&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest01(double? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsOddTest01(Nullable`1<Double>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Single, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest02(float valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsOddTest02(Single, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Single&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest03(float? valueArgument, string nameArgument)
		{
			ArgumentFloatingPointNumberParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentFloatingPointNumberParityValidationUtilityTests.RequireArgumentIsOddTest03(Nullable`1<Single>, String)
		}
	}
}
