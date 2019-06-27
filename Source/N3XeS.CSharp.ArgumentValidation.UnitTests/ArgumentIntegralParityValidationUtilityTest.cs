// <copyright file="ArgumentIntegralParityValidationUtilityTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Utilities;

namespace N3XeS.CSharp.ArgumentValidation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentIntegralParityValidationUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentIntegralParityValidationUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentIntegralParityValidationUtilityTest
	{

		/// <summary>Test stub for RequireArgumentIsEven(Byte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest(byte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest01(byte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest01(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest02(decimal valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest02(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest03(decimal? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest03(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest04(int valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest04(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest05(int? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest05(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest06(long valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest06(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest07(long? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest07(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest08(sbyte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest08(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest09(sbyte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest09(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest10(short valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest10(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest11(short? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest11(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(UInt32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest12(uint valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest12(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest13(uint? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest13(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(UInt64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest14(ulong valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest14(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest15(ulong? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest15(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(UInt16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest16(ushort valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest16(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest17(ushort? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsEvenTest17(Nullable`1<UInt16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Byte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest(byte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest01(byte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest01(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest02(decimal valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest02(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest03(decimal? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest03(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest04(int valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest04(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest05(int? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest05(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest06(long valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest06(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest07(long? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest07(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest08(sbyte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest08(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest09(sbyte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest09(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest10(short valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest10(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest11(short? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest11(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(UInt32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest12(uint valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest12(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest13(uint? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest13(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(UInt64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest14(ulong valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest14(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest15(ulong? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest15(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(UInt16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest16(ushort valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest16(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest17(ushort? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationUtility.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationUtilityTest.RequireArgumentIsOddTest17(Nullable`1<UInt16>, String)
		}
	}
}
