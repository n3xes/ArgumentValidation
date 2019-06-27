// <copyright file="ArgumentGenericRelationalValidationExtensionTest.cs">Copyright (c) 2013, John Caruthers</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.ArgumentValidation.Extensions;

namespace N3XeS.CSharp.ArgumentValidation.Extensions.UnitTests
{
    /// <summary>This class contains parameterized unit tests for ArgumentGenericRelationalValidationExtension</summary>
    [TestClass]
	[ExcludeFromCodeCoverage]
    [PexClass(typeof(ArgumentGenericRelationalValidationExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArgumentGenericRelationalValidationExtensionTest
    {

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest01<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest02<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest03<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest04<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest05<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest06<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetween(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenTest07<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetween<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest01<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest02<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest03<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest04<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest05<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest06<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsBetweenExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsBetweenExclusiveTest07<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsBetweenExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsBetweenExclusiveTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(!!0, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThan<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest01<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThan<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest02<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThan<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThan(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanTest03<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThan<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(!!0, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest01<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest02<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsGreaterThanOrEqualTest03<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsGreaterThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundLower);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsGreaterThanOrEqualTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(!!0, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThan<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest01<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThan<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest02<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThan<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThan(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanTest03<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThan<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(!!0, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest(!!0, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(!!0, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest01<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest01(!!0, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;!!0&gt;, String, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest02<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest02(Nullable`1<!!0>, String, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsLessThanOrEqual(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsLessThanOrEqualTest03<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsLessThanOrEqual<T>
				(valueArgument, nameArgument, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsLessThanOrEqualTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest01<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest02<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest03<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest04<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest05<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest06<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutside(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideTest07<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutside<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest(!!0, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest01<T>(
			T valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest01(!!0, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest02<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest02(!!0, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(!!0, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest03<T>(
			T valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, !!0, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest04<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest04(Nullable`1<!!0>, String, !!0, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest05<T>(
			T? valueArgument,
			string nameArgument,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest06<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for RequireArgumentIsOutsideExclusive(Nullable`1&lt;!!0&gt;, String, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexAllowedException(typeof(ArgumentOutOfRangeException))]
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireArgumentIsOutsideExclusiveTest07<T>(
			T? valueArgument,
			string nameArgument,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			ArgumentGenericRelationalValidationExtension.RequireArgumentIsOutsideExclusive<T>
				(valueArgument, nameArgument, valueBoundLower, valueBoundUpper);
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTest.RequireArgumentIsOutsideExclusiveTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}
	}
}
