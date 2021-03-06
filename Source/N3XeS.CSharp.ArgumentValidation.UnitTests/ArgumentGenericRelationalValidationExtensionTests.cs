// <copyright file="ArgumentGenericRelationalValidationExtensionTests.cs">Copyright (c) 2013, John Caruthers</copyright>

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
    public partial class ArgumentGenericRelationalValidationExtensionTests
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest(!!0, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest01(!!0, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest02(!!0, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest04(Nullable`1<!!0>, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest(!!0, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest01(!!0, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest02(!!0, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest04(Nullable`1<!!0>, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsBetweenExclusiveTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest(!!0, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest01(!!0, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest02(Nullable`1<!!0>, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest(!!0, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest01(!!0, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest02(Nullable`1<!!0>, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsGreaterThanOrEqualTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanTest(!!0, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanTest01(!!0, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanTest02(Nullable`1<!!0>, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest(!!0, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest01(!!0, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest02(Nullable`1<!!0>, String, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsLessThanOrEqualTest03(Nullable`1<!!0>, String, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest(!!0, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest01(!!0, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest02(!!0, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest04(Nullable`1<!!0>, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest(!!0, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest01(!!0, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest02(!!0, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest03(!!0, String, Nullable`1<!!0>, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest04(Nullable`1<!!0>, String, !!0, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest05(Nullable`1<!!0>, String, !!0, Nullable`1<!!0>)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest06(Nullable`1<!!0>, String, Nullable`1<!!0>, !!0)
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
			// TODO: add assertions to method ArgumentGenericRelationalValidationExtensionTests.RequireArgumentIsOutsideExclusiveTest07(Nullable`1<!!0>, String, Nullable`1<!!0>, Nullable`1<!!0>)
		}
	}
}
