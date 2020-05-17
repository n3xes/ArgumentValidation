// <copyright company="John Caruthers" file="ArgumentIntegralParityValidationExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Extensions;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentIntegralParityValidationExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentIntegralParityValidationExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentIntegralParityValidationExtensionTest
	{

		/// <summary>Test stub for RequireArgumentIsEven(Byte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest(byte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest01(byte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest01(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest02(decimal valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest02(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest03(decimal? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest03(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest04(int valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest04(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest05(int? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest05(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest06(long valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest06(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest07(long? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest07(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest08(sbyte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest08(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest09(sbyte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest09(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest10(short valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest10(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest11(short? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest11(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(UInt32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest12(uint valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest12(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest13(uint? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest13(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(UInt64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest14(ulong valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest14(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest15(ulong? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest15(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(UInt16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsEvenTest16(ushort valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest16(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentIsEven(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsEvenTest17(ushort? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsEven(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsEvenTest17(Nullable`1<UInt16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Byte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest(byte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest(Byte, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Byte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest01(byte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest01(Nullable`1<Byte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Decimal, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest02(decimal valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest02(Decimal, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Decimal&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest03(decimal? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest03(Nullable`1<Decimal>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Int32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest04(int valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest04(Int32, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Int32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest05(int? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest05(Nullable`1<Int32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Int64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest06(long valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest06(Int64, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Int64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest07(long? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest07(Nullable`1<Int64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(SByte, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest08(sbyte valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest08(SByte, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;SByte&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest09(sbyte? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest09(Nullable`1<SByte>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Int16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest10(short valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest10(Int16, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;Int16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest11(short? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest11(Nullable`1<Int16>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(UInt32, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest12(uint valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest12(UInt32, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;UInt32&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest13(uint? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest13(Nullable`1<UInt32>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(UInt64, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest14(ulong valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest14(UInt64, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;UInt64&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest15(ulong? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest15(Nullable`1<UInt64>, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(UInt16, String)</summary>
		[PexMethod]
		public void RequireArgumentIsOddTest16(ushort valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest16(UInt16, String)
		}

		/// <summary>Test stub for RequireArgumentIsOdd(Nullable`1&lt;UInt16&gt;, String)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOddTest17(ushort? valueArgument, string nameArgument)
		{
			ArgumentIntegralParityValidationExtension.RequireArgumentIsOdd(valueArgument, nameArgument);
			// TODO: add assertions to method ArgumentIntegralParityValidationExtensionTest.RequireArgumentIsOddTest17(Nullable`1<UInt16>, String)
		}
	}
}
