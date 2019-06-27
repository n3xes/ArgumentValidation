// <copyright file="ArgumentRelationalValidationUtilityTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Extensions;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for ArgumentRelationalValidationExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(ArgumentRelationalValidationExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class ArgumentRelationalValidationExtensionTest
	{

		/// <summary>Test stub for RequireArgumentIsBetween(DateTime, String, DateTime, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest(DateTime, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(DateTime, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest01(DateTime, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(DateTime, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		 public void RequireArgumentIsBetweenTest02(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest02(DateTime, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(DateTime, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest03(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest03(DateTime, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;DateTime&gt;, String, DateTime, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest04(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest04(Nullable`1<DateTime>, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;DateTime&gt;, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest05(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest05(Nullable`1<DateTime>, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest06(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest06(Nullable`1<DateTime>, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest07(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest07(Nullable`1<DateTime>, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Byte, String, Byte, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest08(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest08(Byte, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Byte, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest09(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest09(Byte, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Byte, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest10(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest10(Byte, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Byte, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest11(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest11(Byte, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Byte&gt;, String, Byte, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest12(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest12(Nullable`1<Byte>, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Byte&gt;, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest13(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest13(Nullable`1<Byte>, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest14(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest14(Nullable`1<Byte>, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest15(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest15(Nullable`1<Byte>, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Decimal, String, Decimal, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest16(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest16(Decimal, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Decimal, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest17(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest17(Decimal, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Decimal, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest18(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest18(Decimal, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Decimal, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest19(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest19(Decimal, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Decimal&gt;, String, Decimal, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest20(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest20(Nullable`1<Decimal>, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Decimal&gt;, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest21(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest21(Nullable`1<Decimal>, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest22(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest22(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest23(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest23(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Double, String, Double, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest24(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest24(Double, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Double, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest25(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest25(Double, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Double, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest26(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest26(Double, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Double, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest27(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest27(Double, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Double&gt;, String, Double, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest28(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest28(Nullable`1<Double>, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Double&gt;, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest29(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest29(Nullable`1<Double>, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest30(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest30(Nullable`1<Double>, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest31(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest31(Nullable`1<Double>, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Single, String, Single, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest32(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest32(Single, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Single, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest33(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest33(Single, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Single, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest34(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest34(Single, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Single, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest35(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest35(Single, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Single&gt;, String, Single, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest36(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest36(Nullable`1<Single>, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Single&gt;, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest37(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest37(Nullable`1<Single>, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest38(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest38(Nullable`1<Single>, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest39(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest39(Nullable`1<Single>, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int32, String, Int32, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest40(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest40(Int32, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int32, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest41(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest41(Int32, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int32, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest42(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest42(Int32, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int32, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest43(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest43(Int32, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int32&gt;, String, Int32, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest44(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest44(Nullable`1<Int32>, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int32&gt;, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest45(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest45(Nullable`1<Int32>, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest46(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest46(Nullable`1<Int32>, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest47(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest47(Nullable`1<Int32>, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int64, String, Int64, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest48(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest48(Int64, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int64, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest49(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest49(Int64, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int64, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest50(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest50(Int64, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int64, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest51(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest51(Int64, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int64&gt;, String, Int64, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest52(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest52(Nullable`1<Int64>, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int64&gt;, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest53(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest53(Nullable`1<Int64>, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest54(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest54(Nullable`1<Int64>, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest55(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest55(Nullable`1<Int64>, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(SByte, String, SByte, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest56(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest56(SByte, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(SByte, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest57(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest57(SByte, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(SByte, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest58(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest58(SByte, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(SByte, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest59(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest59(SByte, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;SByte&gt;, String, SByte, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest60(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest60(Nullable`1<SByte>, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;SByte&gt;, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest61(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest61(Nullable`1<SByte>, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest62(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest62(Nullable`1<SByte>, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest63(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest63(Nullable`1<SByte>, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int16, String, Int16, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest64(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest64(Int16, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int16, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest65(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest65(Int16, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int16, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest66(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest66(Int16, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Int16, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest67(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest67(Int16, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int16&gt;, String, Int16, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest68(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest68(Nullable`1<Int16>, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int16&gt;, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest69(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest69(Nullable`1<Int16>, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest70(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest70(Nullable`1<Int16>, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest71(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest71(Nullable`1<Int16>, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt32, String, UInt32, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest72(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest72(UInt32, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt32, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest73(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest73(UInt32, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt32, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest74(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest74(UInt32, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt32, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest75(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest75(UInt32, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt32&gt;, String, UInt32, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest76(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest76(Nullable`1<UInt32>, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt32&gt;, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest77(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest77(Nullable`1<UInt32>, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest78(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest78(Nullable`1<UInt32>, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest79(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest79(Nullable`1<UInt32>, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt64, String, UInt64, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest80(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest80(UInt64, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt64, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest81(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest81(UInt64, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt64, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest82(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest82(UInt64, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt64, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest83(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest83(UInt64, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt64&gt;, String, UInt64, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest84(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest84(Nullable`1<UInt64>, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt64&gt;, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest85(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest85(Nullable`1<UInt64>, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest86(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest86(Nullable`1<UInt64>, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest87(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest87(Nullable`1<UInt64>, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt16, String, UInt16, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenTest88(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest88(UInt16, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt16, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest89(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest89(UInt16, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt16, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest90(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest90(UInt16, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(UInt16, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest91(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest91(UInt16, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt16&gt;, String, UInt16, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest92(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest92(Nullable`1<UInt16>, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt16&gt;, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest93(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest93(Nullable`1<UInt16>, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest94(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest94(Nullable`1<UInt16>, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest95(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetween
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenTest95(Nullable`1<UInt16>, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(DateTime, String, DateTime, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest(DateTime, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(DateTime, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest01(DateTime, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(DateTime, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest02(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest02(DateTime, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(DateTime, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest03(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest03(DateTime, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;DateTime&gt;, String, DateTime, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest04(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest04(Nullable`1<DateTime>, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;DateTime&gt;, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest05(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest05(Nullable`1<DateTime>, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest06(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest06(Nullable`1<DateTime>, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest07(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest07(Nullable`1<DateTime>, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Byte, String, Byte, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest08(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest08(Byte, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Byte, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest09(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest09(Byte, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Byte, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest10(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest10(Byte, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Byte, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest11(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest11(Byte, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Byte&gt;, String, Byte, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest12(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest12(Nullable`1<Byte>, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Byte&gt;, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest13(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest13(Nullable`1<Byte>, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest14(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest14(Nullable`1<Byte>, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest15(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest15(Nullable`1<Byte>, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Decimal, String, Decimal, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest16(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest16(Decimal, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Decimal, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest17(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest17(Decimal, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Decimal, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest18(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest18(Decimal, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Decimal, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest19(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest19(Decimal, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Decimal&gt;, String, Decimal, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest20(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest20(Nullable`1<Decimal>, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Decimal&gt;, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest21(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest21(Nullable`1<Decimal>, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest22(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest22(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest23(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest23(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Double, String, Double, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest24(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest24(Double, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Double, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest25(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest25(Double, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Double, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest26(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest26(Double, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Double, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest27(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest27(Double, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Double&gt;, String, Double, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest28(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest28(Nullable`1<Double>, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Double&gt;, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest29(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest29(Nullable`1<Double>, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest30(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest30(Nullable`1<Double>, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest31(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest31(Nullable`1<Double>, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Single, String, Single, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest32(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest32(Single, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Single, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest33(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest33(Single, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Single, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest34(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest34(Single, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Single, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest35(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest35(Single, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Single&gt;, String, Single, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest36(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest36(Nullable`1<Single>, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Single&gt;, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest37(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest37(Nullable`1<Single>, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest38(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest38(Nullable`1<Single>, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest39(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest39(Nullable`1<Single>, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int32, String, Int32, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest40(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest40(Int32, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int32, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest41(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest41(Int32, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int32, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest42(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest42(Int32, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int32, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest43(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest43(Int32, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int32&gt;, String, Int32, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest44(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest44(Nullable`1<Int32>, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int32&gt;, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest45(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest45(Nullable`1<Int32>, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest46(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest46(Nullable`1<Int32>, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest47(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest47(Nullable`1<Int32>, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int64, String, Int64, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest48(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest48(Int64, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int64, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest49(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest49(Int64, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int64, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest50(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest50(Int64, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int64, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest51(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest51(Int64, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int64&gt;, String, Int64, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest52(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest52(Nullable`1<Int64>, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int64&gt;, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest53(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest53(Nullable`1<Int64>, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest54(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest54(Nullable`1<Int64>, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest55(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest55(Nullable`1<Int64>, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(SByte, String, SByte, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest56(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest56(SByte, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(SByte, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest57(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest57(SByte, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(SByte, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest58(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest58(SByte, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(SByte, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest59(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest59(SByte, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;SByte&gt;, String, SByte, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest60(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest60(Nullable`1<SByte>, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;SByte&gt;, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest61(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest61(Nullable`1<SByte>, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest62(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest62(Nullable`1<SByte>, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest63(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest63(Nullable`1<SByte>, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int16, String, Int16, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest64(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest64(Int16, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int16, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest65(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest65(Int16, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int16, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest66(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest66(Int16, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Int16, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest67(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest67(Int16, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int16&gt;, String, Int16, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest68(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest68(Nullable`1<Int16>, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int16&gt;, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest69(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest69(Nullable`1<Int16>, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest70(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest70(Nullable`1<Int16>, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest71(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest71(Nullable`1<Int16>, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt32, String, UInt32, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest72(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest72(UInt32, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt32, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest73(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest73(UInt32, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt32, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest74(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest74(UInt32, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt32, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest75(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest75(UInt32, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt32&gt;, String, UInt32, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest76(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest76(Nullable`1<UInt32>, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt32&gt;, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest77(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest77(Nullable`1<UInt32>, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest78(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest78(Nullable`1<UInt32>, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest79(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest79(Nullable`1<UInt32>, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt64, String, UInt64, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest80(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest80(UInt64, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt64, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest81(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest81(UInt64, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt64, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest82(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest82(UInt64, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt64, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest83(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest83(UInt64, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt64&gt;, String, UInt64, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest84(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest84(Nullable`1<UInt64>, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt64&gt;, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest85(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest85(Nullable`1<UInt64>, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest86(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest86(Nullable`1<UInt64>, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest87(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest87(Nullable`1<UInt64>, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt16, String, UInt16, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest88(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest88(UInt16, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt16, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest89(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest89(UInt16, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt16, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest90(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest90(UInt16, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(UInt16, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest91(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest91(UInt16, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt16&gt;, String, UInt16, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest92(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest92(Nullable`1<UInt16>, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt16&gt;, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest93(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest93(Nullable`1<UInt16>, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest94(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest94(Nullable`1<UInt16>, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest95(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsBetweenExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest95(Nullable`1<UInt16>, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(DateTime, String, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest(DateTime, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(DateTime, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest01(DateTime, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;DateTime&gt;, String, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest02(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest02(Nullable`1<DateTime>, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest03(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest03(Nullable`1<DateTime>, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Byte, String, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest04(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest04(Byte, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Byte, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest05(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest05(Byte, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Byte&gt;, String, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest06(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest06(Nullable`1<Byte>, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest07(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest07(Nullable`1<Byte>, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Decimal, String, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest08(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest08(Decimal, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Decimal, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest09(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest09(Decimal, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Decimal&gt;, String, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest10(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest10(Nullable`1<Decimal>, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest11(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest11(Nullable`1<Decimal>, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Double, String, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest12(
			double valueArgument,
			string nameArgument,
			double valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest12(Double, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Double, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest13(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest13(Double, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Double&gt;, String, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest14(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest14(Nullable`1<Double>, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest15(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest15(Nullable`1<Double>, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Single, String, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest16(
			float valueArgument,
			string nameArgument,
			float valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest16(Single, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Single, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest17(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest17(Single, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Single&gt;, String, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest18(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest18(Nullable`1<Single>, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest19(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest19(Nullable`1<Single>, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Int32, String, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest20(
			int valueArgument,
			string nameArgument,
			int valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest20(Int32, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Int32, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest21(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest21(Int32, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Int32&gt;, String, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest22(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest22(Nullable`1<Int32>, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest23(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest23(Nullable`1<Int32>, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Int64, String, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest24(
			long valueArgument,
			string nameArgument,
			long valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest24(Int64, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Int64, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest25(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest25(Int64, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Int64&gt;, String, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest26(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest26(Nullable`1<Int64>, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest27(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest27(Nullable`1<Int64>, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(SByte, String, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest28(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest28(SByte, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(SByte, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest29(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest29(SByte, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;SByte&gt;, String, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest30(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest30(Nullable`1<SByte>, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest31(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest31(Nullable`1<SByte>, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Int16, String, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest32(
			short valueArgument,
			string nameArgument,
			short valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest32(Int16, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Int16, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest33(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest33(Int16, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Int16&gt;, String, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest34(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest34(Nullable`1<Int16>, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest35(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest35(Nullable`1<Int16>, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(UInt32, String, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest36(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest36(UInt32, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(UInt32, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest37(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest37(UInt32, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;UInt32&gt;, String, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest38(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest38(Nullable`1<UInt32>, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest39(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest39(Nullable`1<UInt32>, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(UInt64, String, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest40(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest40(UInt64, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(UInt64, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest41(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest41(UInt64, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;UInt64&gt;, String, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest42(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest42(Nullable`1<UInt64>, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest43(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest43(Nullable`1<UInt64>, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(UInt16, String, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest44(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest44(UInt16, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(UInt16, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest45(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest45(UInt16, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;UInt16&gt;, String, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest46(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest46(Nullable`1<UInt16>, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest47(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThan
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest47(Nullable`1<UInt16>, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(DateTime, String, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest(DateTime, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(DateTime, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest01(DateTime, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, String, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest02(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest02(Nullable`1<DateTime>, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest03(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest03(Nullable`1<DateTime>, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Byte, String, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest04(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest04(Byte, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Byte, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest05(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest05(Byte, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, String, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest06(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest06(Nullable`1<Byte>, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest07(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest07(Nullable`1<Byte>, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Decimal, String, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest08(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest08(Decimal, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Decimal, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest09(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest09(Decimal, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, String, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest10(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest10(Nullable`1<Decimal>, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest11(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest11(Nullable`1<Decimal>, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Double, String, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest12(
			double valueArgument,
			string nameArgument,
			double valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest12(Double, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Double, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest13(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest13(Double, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, String, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest14(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest14(Nullable`1<Double>, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest15(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest15(Nullable`1<Double>, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Single, String, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest16(
			float valueArgument,
			string nameArgument,
			float valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest16(Single, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Single, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest17(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest17(Single, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, String, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest18(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest18(Nullable`1<Single>, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest19(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest19(Nullable`1<Single>, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Int32, String, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest20(
			int valueArgument,
			string nameArgument,
			int valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest20(Int32, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Int32, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest21(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest21(Int32, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, String, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest22(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest22(Nullable`1<Int32>, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest23(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest23(Nullable`1<Int32>, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Int64, String, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest24(
			long valueArgument,
			string nameArgument,
			long valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest24(Int64, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Int64, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest25(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest25(Int64, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, String, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest26(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest26(Nullable`1<Int64>, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest27(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest27(Nullable`1<Int64>, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(SByte, String, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest28(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest28(SByte, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(SByte, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest29(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest29(SByte, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, String, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest30(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest30(Nullable`1<SByte>, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest31(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest31(Nullable`1<SByte>, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Int16, String, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest32(
			short valueArgument,
			string nameArgument,
			short valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest32(Int16, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Int16, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest33(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest33(Int16, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, String, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest34(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest34(Nullable`1<Int16>, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest35(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest35(Nullable`1<Int16>, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(UInt32, String, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest36(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest36(UInt32, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(UInt32, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest37(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest37(UInt32, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, String, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest38(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest38(Nullable`1<UInt32>, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest39(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest39(Nullable`1<UInt32>, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(UInt64, String, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest40(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest40(UInt64, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(UInt64, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest41(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest41(UInt64, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, String, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest42(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest42(Nullable`1<UInt64>, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest43(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest43(Nullable`1<UInt64>, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(UInt16, String, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest44(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest44(UInt16, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(UInt16, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest45(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest45(UInt16, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, String, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest46(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest46(Nullable`1<UInt16>, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest47(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest47(Nullable`1<UInt16>, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(DateTime, String, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest(DateTime, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(DateTime, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest01(DateTime, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;DateTime&gt;, String, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest02(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest02(Nullable`1<DateTime>, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest03(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest03(Nullable`1<DateTime>, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Byte, String, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest04(
			byte valueArgument,
			string nameArgument,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest04(Byte, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Byte, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest05(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest05(Byte, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Byte&gt;, String, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest06(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest06(Nullable`1<Byte>, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest07(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest07(Nullable`1<Byte>, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Decimal, String, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest08(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest08(Decimal, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Decimal, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest09(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest09(Decimal, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Decimal&gt;, String, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest10(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest10(Nullable`1<Decimal>, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest11(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest11(Nullable`1<Decimal>, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Double, String, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest12(
			double valueArgument,
			string nameArgument,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest12(Double, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Double, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest13(
			double valueArgument,
			string nameArgument,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest13(Double, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Double&gt;, String, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest14(
			double? valueArgument,
			string nameArgument,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest14(Nullable`1<Double>, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest15(
			double? valueArgument,
			string nameArgument,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest15(Nullable`1<Double>, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Single, String, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest16(
			float valueArgument,
			string nameArgument,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest16(Single, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Single, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest17(
			float valueArgument,
			string nameArgument,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest17(Single, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Single&gt;, String, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest18(
			float? valueArgument,
			string nameArgument,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest18(Nullable`1<Single>, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest19(
			float? valueArgument,
			string nameArgument,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest19(Nullable`1<Single>, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Int32, String, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest20(
			int valueArgument,
			string nameArgument,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest20(Int32, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Int32, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest21(
			int valueArgument,
			string nameArgument,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest21(Int32, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Int32&gt;, String, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest22(
			int? valueArgument,
			string nameArgument,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest22(Nullable`1<Int32>, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest23(
			int? valueArgument,
			string nameArgument,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest23(Nullable`1<Int32>, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Int64, String, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest24(
			long valueArgument,
			string nameArgument,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest24(Int64, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Int64, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest25(
			long valueArgument,
			string nameArgument,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest25(Int64, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Int64&gt;, String, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest26(
			long? valueArgument,
			string nameArgument,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest26(Nullable`1<Int64>, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest27(
			long? valueArgument,
			string nameArgument,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest27(Nullable`1<Int64>, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(SByte, String, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest28(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest28(SByte, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(SByte, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest29(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest29(SByte, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;SByte&gt;, String, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest30(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest30(Nullable`1<SByte>, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest31(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest31(Nullable`1<SByte>, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Int16, String, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest32(
			short valueArgument,
			string nameArgument,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest32(Int16, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Int16, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest33(
			short valueArgument,
			string nameArgument,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest33(Int16, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Int16&gt;, String, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest34(
			short? valueArgument,
			string nameArgument,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest34(Nullable`1<Int16>, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest35(
			short? valueArgument,
			string nameArgument,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest35(Nullable`1<Int16>, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(UInt32, String, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest36(
			uint valueArgument,
			string nameArgument,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest36(UInt32, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(UInt32, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest37(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest37(UInt32, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;UInt32&gt;, String, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest38(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest38(Nullable`1<UInt32>, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest39(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest39(Nullable`1<UInt32>, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(UInt64, String, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest40(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest40(UInt64, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(UInt64, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest41(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest41(UInt64, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;UInt64&gt;, String, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest42(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest42(Nullable`1<UInt64>, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest43(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest43(Nullable`1<UInt64>, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(UInt16, String, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanTest44(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest44(UInt16, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(UInt16, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest45(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest45(UInt16, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;UInt16&gt;, String, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest46(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest46(Nullable`1<UInt16>, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest47(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThan
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanTest47(Nullable`1<UInt16>, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(DateTime, String, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest(DateTime, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(DateTime, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest01(DateTime, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, String, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest02(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest02(Nullable`1<DateTime>, String, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest03(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest03(Nullable`1<DateTime>, String, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Byte, String, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest04(
			byte valueArgument,
			string nameArgument,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest04(Byte, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Byte, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest05(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest05(Byte, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Byte&gt;, String, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest06(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest06(Nullable`1<Byte>, String, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest07(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest07(Nullable`1<Byte>, String, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Decimal, String, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest08(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest08(Decimal, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Decimal, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest09(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest09(Decimal, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, String, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest10(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest10(Nullable`1<Decimal>, String, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest11(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest11(Nullable`1<Decimal>, String, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Double, String, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest12(
			double valueArgument,
			string nameArgument,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest12(Double, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Double, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest13(
			double valueArgument,
			string nameArgument,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest13(Double, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Double&gt;, String, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest14(
			double? valueArgument,
			string nameArgument,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest14(Nullable`1<Double>, String, Double)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest15(
			double? valueArgument,
			string nameArgument,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest15(Nullable`1<Double>, String, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Single, String, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest16(
			float valueArgument,
			string nameArgument,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest16(Single, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Single, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest17(
			float valueArgument,
			string nameArgument,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest17(Single, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Single&gt;, String, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest18(
			float? valueArgument,
			string nameArgument,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest18(Nullable`1<Single>, String, Single)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest19(
			float? valueArgument,
			string nameArgument,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest19(Nullable`1<Single>, String, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Int32, String, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest20(
			int valueArgument,
			string nameArgument,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest20(Int32, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Int32, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest21(
			int valueArgument,
			string nameArgument,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest21(Int32, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Int32&gt;, String, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest22(
			int? valueArgument,
			string nameArgument,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest22(Nullable`1<Int32>, String, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest23(
			int? valueArgument,
			string nameArgument,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest23(Nullable`1<Int32>, String, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Int64, String, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest24(
			long valueArgument,
			string nameArgument,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest24(Int64, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Int64, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest25(
			long valueArgument,
			string nameArgument,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest25(Int64, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Int64&gt;, String, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest26(
			long? valueArgument,
			string nameArgument,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest26(Nullable`1<Int64>, String, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest27(
			long? valueArgument,
			string nameArgument,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest27(Nullable`1<Int64>, String, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(SByte, String, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest28(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest28(SByte, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(SByte, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest29(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest29(SByte, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;SByte&gt;, String, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest30(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest30(Nullable`1<SByte>, String, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest31(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest31(Nullable`1<SByte>, String, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Int16, String, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest32(
			short valueArgument,
			string nameArgument,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest32(Int16, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Int16, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest33(
			short valueArgument,
			string nameArgument,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest33(Int16, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Int16&gt;, String, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest34(
			short? valueArgument,
			string nameArgument,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest34(Nullable`1<Int16>, String, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest35(
			short? valueArgument,
			string nameArgument,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest35(Nullable`1<Int16>, String, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(UInt32, String, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest36(
			uint valueArgument,
			string nameArgument,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest36(UInt32, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(UInt32, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest37(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest37(UInt32, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, String, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest38(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest38(Nullable`1<UInt32>, String, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest39(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest39(Nullable`1<UInt32>, String, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(UInt64, String, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest40(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest40(UInt64, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(UInt64, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest41(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest41(UInt64, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, String, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest42(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest42(Nullable`1<UInt64>, String, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest43(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest43(Nullable`1<UInt64>, String, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(UInt16, String, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest44(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest44(UInt16, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(UInt16, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest45(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest45(UInt16, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, String, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest46(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest46(Nullable`1<UInt16>, String, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest47(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsLessThanOrEqual
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest47(Nullable`1<UInt16>, String, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(DateTime, String, DateTime, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest(DateTime, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(DateTime, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest01(DateTime, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(DateTime, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest02(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest02(DateTime, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(DateTime, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest03(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest03(DateTime, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;DateTime&gt;, String, DateTime, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest04(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest04(Nullable`1<DateTime>, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;DateTime&gt;, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest05(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest05(Nullable`1<DateTime>, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest06(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest06(Nullable`1<DateTime>, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest07(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest07(Nullable`1<DateTime>, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Byte, String, Byte, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest08(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest08(Byte, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Byte, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest09(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest09(Byte, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Byte, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest10(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest10(Byte, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Byte, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest11(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest11(Byte, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Byte&gt;, String, Byte, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest12(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest12(Nullable`1<Byte>, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Byte&gt;, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest13(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest13(Nullable`1<Byte>, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest14(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest14(Nullable`1<Byte>, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest15(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest15(Nullable`1<Byte>, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Decimal, String, Decimal, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest16(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest16(Decimal, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Decimal, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest17(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest17(Decimal, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Decimal, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest18(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest18(Decimal, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Decimal, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest19(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest19(Decimal, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Decimal&gt;, String, Decimal, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest20(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest20(Nullable`1<Decimal>, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Decimal&gt;, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest21(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest21(Nullable`1<Decimal>, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest22(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest22(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest23(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest23(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Double, String, Double, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest24(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest24(Double, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Double, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest25(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest25(Double, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Double, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest26(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest26(Double, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Double, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest27(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest27(Double, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Double&gt;, String, Double, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest28(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest28(Nullable`1<Double>, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Double&gt;, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest29(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest29(Nullable`1<Double>, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest30(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest30(Nullable`1<Double>, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest31(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest31(Nullable`1<Double>, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Single, String, Single, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest32(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest32(Single, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Single, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest33(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest33(Single, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Single, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest34(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest34(Single, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Single, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest35(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest35(Single, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Single&gt;, String, Single, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest36(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest36(Nullable`1<Single>, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Single&gt;, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest37(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest37(Nullable`1<Single>, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest38(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest38(Nullable`1<Single>, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest39(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest39(Nullable`1<Single>, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int32, String, Int32, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest40(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest40(Int32, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int32, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest41(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest41(Int32, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int32, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest42(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest42(Int32, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int32, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest43(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest43(Int32, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int32&gt;, String, Int32, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest44(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest44(Nullable`1<Int32>, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int32&gt;, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest45(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest45(Nullable`1<Int32>, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest46(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest46(Nullable`1<Int32>, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest47(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest47(Nullable`1<Int32>, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int64, String, Int64, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest48(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest48(Int64, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int64, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest49(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest49(Int64, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int64, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest50(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest50(Int64, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int64, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest51(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest51(Int64, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int64&gt;, String, Int64, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest52(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest52(Nullable`1<Int64>, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int64&gt;, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest53(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest53(Nullable`1<Int64>, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest54(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest54(Nullable`1<Int64>, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest55(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest55(Nullable`1<Int64>, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(SByte, String, SByte, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest56(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest56(SByte, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(SByte, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest57(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest57(SByte, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(SByte, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest58(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest58(SByte, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(SByte, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest59(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest59(SByte, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;SByte&gt;, String, SByte, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest60(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest60(Nullable`1<SByte>, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;SByte&gt;, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest61(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest61(Nullable`1<SByte>, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest62(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest62(Nullable`1<SByte>, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest63(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest63(Nullable`1<SByte>, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int16, String, Int16, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest64(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest64(Int16, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int16, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest65(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest65(Int16, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int16, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest66(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest66(Int16, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Int16, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest67(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest67(Int16, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int16&gt;, String, Int16, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest68(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest68(Nullable`1<Int16>, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int16&gt;, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest69(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest69(Nullable`1<Int16>, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest70(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest70(Nullable`1<Int16>, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest71(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest71(Nullable`1<Int16>, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt32, String, UInt32, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest72(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest72(UInt32, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt32, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest73(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest73(UInt32, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt32, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest74(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest74(UInt32, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt32, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest75(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest75(UInt32, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt32&gt;, String, UInt32, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest76(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest76(Nullable`1<UInt32>, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt32&gt;, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest77(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest77(Nullable`1<UInt32>, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest78(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest78(Nullable`1<UInt32>, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest79(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest79(Nullable`1<UInt32>, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt64, String, UInt64, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest80(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest80(UInt64, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt64, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest81(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest81(UInt64, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt64, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest82(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest82(UInt64, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt64, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest83(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest83(UInt64, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt64&gt;, String, UInt64, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest84(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest84(Nullable`1<UInt64>, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt64&gt;, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest85(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest85(Nullable`1<UInt64>, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest86(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest86(Nullable`1<UInt64>, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest87(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest87(Nullable`1<UInt64>, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt16, String, UInt16, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideTest88(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest88(UInt16, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt16, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest89(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest89(UInt16, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt16, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest90(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest90(UInt16, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(UInt16, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest91(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest91(UInt16, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt16&gt;, String, UInt16, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest92(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest92(Nullable`1<UInt16>, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt16&gt;, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest93(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest93(Nullable`1<UInt16>, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest94(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest94(Nullable`1<UInt16>, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest95(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutside
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideTest95(Nullable`1<UInt16>, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(DateTime, String, DateTime, DateTime)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest(DateTime, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(DateTime, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest01(
			DateTime valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest01(DateTime, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(DateTime, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest02(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest02(DateTime, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(DateTime, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest03(
			DateTime valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest03(DateTime, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;DateTime&gt;, String, DateTime, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest04(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest04(Nullable`1<DateTime>, String, DateTime, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;DateTime&gt;, String, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest05(
			DateTime? valueArgument,
			string nameArgument,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest05(Nullable`1<DateTime>, String, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest06(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest06(Nullable`1<DateTime>, String, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;DateTime&gt;, String, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest07(
			DateTime? valueArgument,
			string nameArgument,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest07(Nullable`1<DateTime>, String, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Byte, String, Byte, Byte)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest08(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest08(Byte, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Byte, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest09(
			byte valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest09(Byte, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Byte, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest10(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest10(Byte, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Byte, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest11(
			byte valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest11(Byte, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Byte&gt;, String, Byte, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest12(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest12(Nullable`1<Byte>, String, Byte, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Byte&gt;, String, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest13(
			byte? valueArgument,
			string nameArgument,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest13(Nullable`1<Byte>, String, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest14(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest14(Nullable`1<Byte>, String, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Byte&gt;, String, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest15(
			byte? valueArgument,
			string nameArgument,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest15(Nullable`1<Byte>, String, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Decimal, String, Decimal, Decimal)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest16(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest16(Decimal, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Decimal, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest17(
			decimal valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest17(Decimal, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Decimal, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest18(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest18(Decimal, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Decimal, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest19(
			decimal valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest19(Decimal, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Decimal&gt;, String, Decimal, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest20(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest20(Nullable`1<Decimal>, String, Decimal, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Decimal&gt;, String, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest21(
			decimal? valueArgument,
			string nameArgument,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest21(Nullable`1<Decimal>, String, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest22(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest22(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Decimal&gt;, String, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest23(
			decimal? valueArgument,
			string nameArgument,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest23(Nullable`1<Decimal>, String, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Double, String, Double, Double)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest24(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest24(Double, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Double, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest25(
			double valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest25(Double, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Double, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest26(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest26(Double, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Double, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest27(
			double valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest27(Double, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Double&gt;, String, Double, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest28(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest28(Nullable`1<Double>, String, Double, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Double&gt;, String, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest29(
			double? valueArgument,
			string nameArgument,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest29(Nullable`1<Double>, String, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest30(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest30(Nullable`1<Double>, String, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Double&gt;, String, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest31(
			double? valueArgument,
			string nameArgument,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest31(Nullable`1<Double>, String, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Single, String, Single, Single)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest32(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest32(Single, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Single, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest33(
			float valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest33(Single, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Single, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest34(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest34(Single, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Single, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest35(
			float valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest35(Single, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Single&gt;, String, Single, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest36(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest36(Nullable`1<Single>, String, Single, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Single&gt;, String, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest37(
			float? valueArgument,
			string nameArgument,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest37(Nullable`1<Single>, String, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest38(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest38(Nullable`1<Single>, String, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Single&gt;, String, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest39(
			float? valueArgument,
			string nameArgument,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest39(Nullable`1<Single>, String, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int32, String, Int32, Int32)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest40(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest40(Int32, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int32, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest41(
			int valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest41(Int32, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int32, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest42(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest42(Int32, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int32, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest43(
			int valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest43(Int32, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int32&gt;, String, Int32, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest44(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest44(Nullable`1<Int32>, String, Int32, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int32&gt;, String, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest45(
			int? valueArgument,
			string nameArgument,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest45(Nullable`1<Int32>, String, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest46(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest46(Nullable`1<Int32>, String, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int32&gt;, String, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest47(
			int? valueArgument,
			string nameArgument,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest47(Nullable`1<Int32>, String, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int64, String, Int64, Int64)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest48(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest48(Int64, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int64, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest49(
			long valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest49(Int64, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int64, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest50(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest50(Int64, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int64, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest51(
			long valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest51(Int64, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int64&gt;, String, Int64, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest52(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest52(Nullable`1<Int64>, String, Int64, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int64&gt;, String, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest53(
			long? valueArgument,
			string nameArgument,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest53(Nullable`1<Int64>, String, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest54(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest54(Nullable`1<Int64>, String, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int64&gt;, String, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest55(
			long? valueArgument,
			string nameArgument,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest55(Nullable`1<Int64>, String, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(SByte, String, SByte, SByte)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest56(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest56(SByte, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(SByte, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest57(
			sbyte valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest57(SByte, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(SByte, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest58(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest58(SByte, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(SByte, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest59(
			sbyte valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest59(SByte, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;SByte&gt;, String, SByte, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest60(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest60(Nullable`1<SByte>, String, SByte, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;SByte&gt;, String, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest61(
			sbyte? valueArgument,
			string nameArgument,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest61(Nullable`1<SByte>, String, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest62(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest62(Nullable`1<SByte>, String, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;SByte&gt;, String, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest63(
			sbyte? valueArgument,
			string nameArgument,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest63(Nullable`1<SByte>, String, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int16, String, Int16, Int16)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest64(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest64(Int16, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int16, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest65(
			short valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest65(Int16, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int16, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest66(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest66(Int16, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Int16, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest67(
			short valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest67(Int16, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int16&gt;, String, Int16, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest68(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest68(Nullable`1<Int16>, String, Int16, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int16&gt;, String, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest69(
			short? valueArgument,
			string nameArgument,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest69(Nullable`1<Int16>, String, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest70(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest70(Nullable`1<Int16>, String, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;Int16&gt;, String, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest71(
			short? valueArgument,
			string nameArgument,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest71(Nullable`1<Int16>, String, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt32, String, UInt32, UInt32)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest72(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest72(UInt32, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt32, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest73(
			uint valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest73(UInt32, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt32, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest74(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest74(UInt32, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt32, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest75(
			uint valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest75(UInt32, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt32&gt;, String, UInt32, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest76(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest76(Nullable`1<UInt32>, String, UInt32, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt32&gt;, String, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest77(
			uint? valueArgument,
			string nameArgument,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest77(Nullable`1<UInt32>, String, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest78(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest78(Nullable`1<UInt32>, String, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt32&gt;, String, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest79(
			uint? valueArgument,
			string nameArgument,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest79(Nullable`1<UInt32>, String, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt64, String, UInt64, UInt64)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest80(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest80(UInt64, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt64, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest81(
			ulong valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest81(UInt64, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt64, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest82(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest82(UInt64, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt64, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest83(
			ulong valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest83(UInt64, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt64&gt;, String, UInt64, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest84(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest84(Nullable`1<UInt64>, String, UInt64, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt64&gt;, String, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest85(
			ulong? valueArgument,
			string nameArgument,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest85(Nullable`1<UInt64>, String, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest86(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest86(Nullable`1<UInt64>, String, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt64&gt;, String, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest87(
			ulong? valueArgument,
			string nameArgument,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest87(Nullable`1<UInt64>, String, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt16, String, UInt16, UInt16)</summary>
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest88(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest88(UInt16, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt16, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest89(
			ushort valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest89(UInt16, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt16, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest90(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest90(UInt16, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(UInt16, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest91(
			ushort valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest91(UInt16, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt16&gt;, String, UInt16, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest92(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest92(Nullable`1<UInt16>, String, UInt16, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt16&gt;, String, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest93(
			ushort? valueArgument,
			string nameArgument,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest93(Nullable`1<UInt16>, String, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest94(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest94(Nullable`1<UInt16>, String, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;UInt16&gt;, String, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest95(
			ushort? valueArgument,
			string nameArgument,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			ArgumentRelationalValidationExtension.RequireArgumentIsOutsideExclusive
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest95(Nullable`1<UInt16>, String, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}
	}
}
