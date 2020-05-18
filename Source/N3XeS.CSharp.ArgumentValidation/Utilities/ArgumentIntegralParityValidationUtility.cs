#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="ArgumentIntegralParityValidationUtility.cs">
//		Copyright © 2013, John Caruthers
//		All rights reserved.
//
//		THIS PROGRAM ND ALL OF THE INFORMATION CONTAINED HEREIN IS FREE SOFTWARE:
//		YOU CAN REDISTRIBUTE IT AND/OR MODIFY IT UNDER THE TERMS OF THE GNU GENERAL
//		PUBLIC LICENSE AS PUBLISHED BY THE FREE SOFTWARE FOUNDATION, EITHER VERSION
//		3 OF THE LICENSE, OR (AT YOUR OPTION) ANY LATER VERSION.
//
//		THIS PROGRAM IS DISTRIBUTED IN THE HOPE THAT IT WILL BE USEFUL, BUT WITHOUT
//		ANY WARRANTY; WITHOUT EVEN THE IMPLIED WARRANTY OF MERCHANTABILITY OR FITNESS
//		FOR A PARTICULAR PURPOSE.SEE THE GNU GENERAL PUBLIC LICENSE FOR MORE DETAILS.
//
//		YOU SHOULD HAVE RECEIVED A COPY OF THE GNU GENERAL PUBLIC LICENSE ALONG
//		WITH THIS PROGRAM.  IF NOT, SEE https://www.gnu.org/licenses/.
//
// </copyright>
////====================================================================================================================

#endregion

namespace N3XeS.CSharp.ArgumentValidation.Utilities
{
	#region Directives

	using System;
	using System.Globalization;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

	using System.Numerics;

#endif

	using JetBrains.Annotations;

	using Analyzation.Extensions;

	using Extensions;
	using Properties;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A signed integral parity argument validation related utility.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Friday, October 18, 2013  (10/18/2013)</CreationDate>
	///  <CreationTime>03:36:49 PM</CreationTime>
	/// </author>
	/// <history>
	///  <Modification>
	///   <ModifierName></ModifierName>
	///   <ModificationDate></ModificationDate>
	///   <ModificationTime></ModificationTime>
	///   <ModificationDescription></ModificationDescription>
	///  </Modification>
	/// </history>
	[PublicAPI]
	// ReSharper disable once ClassTooBig
	public static class ArgumentIntegralParityValidationUtility
	{
		#region Constants

		#endregion

		#region Instance/Member/Field Variables

		#endregion

		#region Constructors

		#endregion

		#region Destructor

		#endregion

		#region Events

		#endregion

		#region Properties/Accessors/Mutators

		#endregion

		#region Indexers

		#endregion

		#region Event Handlers

		#endregion

		#region Methods/Functions

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Numerics.BigInteger"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(BigInteger valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven(BigInteger? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

#endif

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Byte"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(Byte valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("valueArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven(Byte? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("valueArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Decimal"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(Decimal valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven(Decimal? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Int32"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(Int32 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven(Int32? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Int64"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(Int64 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven(Int64? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.SByte"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(SByte valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(SByte? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Int16"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		public static void RequireArgumentIsEven(Int16 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		public static void RequireArgumentIsEven(Int16? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.UInt32"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(UInt32 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(UInt32? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.UInt64"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(UInt64 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(UInt64? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.UInt16"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(UInt16 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEven));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is even.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> argument value to validate is even.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or odd.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsEven(UInt16? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsOdd())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeEvenNotNull));
			}
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Numerics.BigInteger"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(BigInteger valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd(BigInteger? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

#endif

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Byte"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(Byte valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("valueArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd(Byte? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("valueArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Decimal"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(Decimal valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd(Decimal? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Int32"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(Int32 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd(Int32? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Int64"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(Int64 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd(Int64? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.SByte"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(SByte valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(SByte? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Int16"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		public static void RequireArgumentIsOdd(Int16 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		public static void RequireArgumentIsOdd(Int16? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.UInt32"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(UInt32 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(UInt32? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.UInt64"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(UInt64 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(UInt64? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.UInt16"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(UInt16 valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOdd));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is odd.
		/// </summary>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> argument value to validate is odd.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="nameArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is <see langword="null"/> or even.</exception>
		[CLSCompliant(false)]
		public static void RequireArgumentIsOdd(UInt16? valueArgument,
												 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonwhiteSpaceValue("nameArgument");

			if (valueArgument.IsEven())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeOddNotNull));
			}
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
