#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="ArgumentEqualityValidationExtension.cs">
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

namespace N3XeS.CSharp.ArgumentValidation.Extensions
{
	#region Directives

	using System;
	using System.Diagnostics.CodeAnalysis;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

	using System.Numerics;

#endif

	using JetBrains.Annotations;

	using Attributes;
	using Utilities;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		An argument equality validation related extension.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>06:59:38 PM</CreationTime>
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
	public static class ArgumentEqualityValidationExtension
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

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not <see langword="null"/>, empty, or white space.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.String"/> argument value to validate is not <see langword="null"/>, empty, or white space.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.String"/> value.</param>
		/// <exception cref="ArgumentNullException">
		///		The <paramref name="nameArgument"/> or <paramref name="valueArgument"/> is <see langword="null"/>.
		/// </exception>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="nameArgument"/> or <paramref name="valueArgument"/> is empty or white space.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt"),
		 SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.", MessageId = "WhiteSpace")]
		public static void RequireArgumentHasNonwhiteSpaceValue([NotNull, ArgumentValidatedNotNull] this String valueArgument,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasNonwhiteSpaceValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is <see langword="null"/> or empty.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.String"/> argument value to validate is <see langword="null"/> or empty.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.String"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is not <see langword="null"/> or empty.</exception>
		public static void RequireArgumentHasNoValue(this String valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasNoValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is <see langword="null"/>, empty, or white space.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.String"/> argument value to validate is <see langword="null"/>, empty, or white space.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.String"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not <see langword="null"/>, empty, or white space.
		/// </exception>
		[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.", MessageId = "WhiteSpace")]
		public static void RequireArgumentHasNullEmptyOrWhiteSpaceValue(this String valueArgument,
																		[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasNullEmptyOrWhiteSpaceValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not <see langword="null"/> or empty.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.String"/> argument value to validate is not <see langword="null"/> or empty.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.String"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="valueArgument"/> is <see langword="null"/>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is empty.</exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentHasValue([NotNull, ArgumentValidatedNotNull] this String valueArgument,
												   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentHasValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Double"/> argument value to validate is approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </exception>
		public static void RequireArgumentApproximatelyDefaultValue(this Double valueArgument,
																	[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyDefaultValue(valueArgument, nameArgument);
		}
		
		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Double valueArgumentA,
															 Double valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Double? valueArgumentA,
															 Double valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Double valueArgumentA,
															 Double? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Double? valueArgumentA,
															 Double? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}
		
		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Single valueArgumentA,
															 Single valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Single? valueArgumentA,
															 Single valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Single valueArgumentA,
															 Single? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentApproximatelyEqual(this Single? valueArgumentA,
															 Single? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefault<T>(this T valueArgument,
													 [NotNull] String nameArgument)
			where T : class
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefault(valueArgument, nameArgument);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Numerics.BigInteger"/> to validate is equal to the default value of <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </exception>
		public static void RequireArgumentDefaultValue(this BigInteger valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this BigInteger? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

#endif

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.DateTime"/> to validate is equal to the default value of <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.DateTime"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </exception>
		public static void RequireArgumentDefaultValue(this DateTime valueArgument,
													  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this DateTime? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Guid"/> to validate is equal to the default value of <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Guid"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </exception>
		public static void RequireArgumentDefaultValue(this Guid valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Guid? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Byte"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Byte"/> to validate is equal to the default value of <see cref="T:System.Byte"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Byte"/>, 0.
		/// </exception>
		public static void RequireArgumentDefaultValue(this Byte valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Byte? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Char"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Char"/> to validate is equal to the default value of <see cref="T:System.Char"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Char"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Char"/>, 0.
		/// </exception>
		public static void RequireArgumentDefaultValue(this Char valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Char? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Decimal"/>, 0.0M.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Decimal"/> to validate is equal to the default value of <see cref="T:System.Decimal"/>, 0.0M.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Decimal"/>, 0.0M.
		/// </exception>
		public static void RequireArgumentDefaultValue(this Decimal valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Decimal? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Double? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Single? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Int32"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Int32"/> to validate is equal to the default value of <see cref="T:System.Int32"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Int32"/>, 0.
		/// </exception>
		public static void RequireArgumentDefaultValue(this Int32 valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Int32? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Int64"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Int64"/> to validate is equal to the default value of <see cref="T:System.Int64"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Int64"/>, 0.
		/// </exception>
		public static void RequireArgumentDefaultValue(this Int64 valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Int64? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.SByte"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.SByte"/> to validate is equal to the default value of <see cref="T:System.SByte"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.SByte"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentDefaultValue(this SByte valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this SByte? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Int16"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Int16"/> to validate is equal to the default value of <see cref="T:System.Int16"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Int16"/>, 0.
		/// </exception>
		public static void RequireArgumentDefaultValue(this Int16 valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this Int16? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.UInt32"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.UInt32"/> to validate is equal to the default value of <see cref="T:System.UInt32"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.UInt32"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentDefaultValue(this UInt32 valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this UInt32? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.UInt64"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.UInt64"/> to validate is equal to the default value of <see cref="T:System.UInt64"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.UInt64"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentDefaultValue(this UInt64 valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this UInt64? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.UInt16"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.UInt16"/> to validate is equal to the default value of <see cref="T:System.UInt16"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.UInt16"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentDefaultValue(this UInt16 valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue(this UInt16? valueArgument,
													   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is equal to the default value of <typeparamref name="T"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <typeparamref name="T"/>.
		/// </exception>
		public static void RequireArgumentDefaultValue<T>(this T valueArgument,
														  [NotNull] String nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate is equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue<T>(this T? valueArgument,
														  [NotNull] String nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Double"/> argument value to validate is not approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </exception>
		public static void RequireArgumentNotApproximatelyDefaultValue(this Double valueArgument,
																	   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Single"/> argument value to validate is not approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </exception>
		public static void RequireArgumentNotApproximatelyDefaultValue(this Single valueArgument,
																	   [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyDefaultValue(valueArgument, nameArgument);
		}
		
		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Double valueArgumentA,
																Double valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Double? valueArgumentA,
																Double valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Double valueArgumentA,
																Double? valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

				/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Double? valueArgumentA,
																Double? valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}
		
		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Single valueArgumentA,
																Single valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Single? valueArgumentA,
																Single valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Single valueArgumentA,
																Single? valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

				/// <summary>
		///		Validates that the <paramref name="valueArgumentA"/> is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </summary>
		/// <param name="valueArgumentA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </param>
		/// <param name="valueArgumentB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> argument value to validate is not approximately equal to the <paramref name="valueArgumentA"/> value.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgumentA"/> is approximately equal to the <paramref name="valueArgumentB"/> value.
		/// </exception>
		public static void RequireArgumentNotApproximatelyEqual(this Single? valueArgumentA,
																Single? valueArgumentB,
																[NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotApproximatelyEqual(valueArgumentA, valueArgumentB, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is not equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefault<T>([NotNull, ArgumentValidatedNotNull] this T valueArgument,
														[NotNull] String nameArgument)
			where T : class
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefault(valueArgument, nameArgument);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Numerics.BigInteger"/> to validate is not equal to the default value of <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this BigInteger valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ValidatedNotNull] this BigInteger? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

#endif

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.DateTime"/> to validate is not equal to the default value of <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.DateTime"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this DateTime valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this DateTime? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Guid"/> to validate is not equal to the default value of <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Guid"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this Guid valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal not to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Guid? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Byte"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Byte"/> to validate is not equal to the default value of <see cref="T:System.Byte"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Byte"/>, 0.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this Byte valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Byte? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Char"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Char"/> to validate is not equal to the default value of <see cref="T:System.Char"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Char"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Char"/>, 0.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this Char valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Char? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Decimal"/>, 0.0M.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Decimal"/> to validate is not equal to the default value of <see cref="T:System.Decimal"/>, 0.0M.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Decimal"/>, 0.0M.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this Decimal valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Decimal? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Double? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Single? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Int32"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Int32"/> to validate is not equal to the default value of <see cref="T:System.Int32"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Int32"/>, 0.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this Int32 valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Int32? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Int64"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Int64"/> to validate is not equal to the default value of <see cref="T:System.Int64"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Int64"/>, 0.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this Int64 valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Int64? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.SByte"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.SByte"/> to validate is not equal to the default value of <see cref="T:System.SByte"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.SByte"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentNotDefaultValue(this SByte valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this SByte? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Int16"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Int16"/> to validate is not equal to the default value of <see cref="T:System.Int16"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Int16"/>, 0.
		/// </exception>
		public static void RequireArgumentNotDefaultValue(this Int16 valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this Int16? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.UInt32"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.UInt32"/> to validate is not equal to the default value of <see cref="T:System.UInt32"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.UInt32"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentNotDefaultValue(this UInt32 valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this UInt32? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.UInt64"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.UInt64"/> to validate is not equal to the default value of <see cref="T:System.UInt64"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.UInt64"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentNotDefaultValue(this UInt64 valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this UInt64? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.UInt16"/>, 0.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.UInt16"/> to validate is not equal to the default value of <see cref="T:System.UInt16"/>, 0.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.UInt16"/>, 0.
		/// </exception>
		[CLSCompliant(false)]
		public static void RequireArgumentNotDefaultValue(this UInt16 valueArgument,
														  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </exception>
		[CLSCompliant(false), ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue([NotNull, ArgumentValidatedNotNull] this UInt16? valueArgument,
														  [NotNull] String nameArgument)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is not equal to the default value of <typeparamref name="T"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <typeparamref name="T"/>.
		/// </exception>
		public static void RequireArgumentNotDefaultValue<T>(this T valueArgument,
															 [NotNull] String nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate is not equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>.
		/// </exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotDefaultValue<T>([NotNull, ArgumentValidatedNotNull] this T? valueArgument,
															 [NotNull] String nameArgument)
			where T : struct
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotDefaultValue(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is not <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is not equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="valueArgument"/> is <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotNull<T>([NotNull, ArgumentValidatedNotNull] this T valueArgument,
													 [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNotNull(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is not <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate is not equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="valueArgument"/> is <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotNull<T>([NotNull, ArgumentValidatedNotNull] this T? valueArgument,
													 [NotNull] String nameArgument)
			where T : struct
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			ArgumentEqualityValidationUtility.RequireArgumentNotNull(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is not equal to <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentNull<T>(this T valueArgument,
												  [NotNull] String nameArgument)
		{
			ArgumentEqualityValidationUtility.RequireArgumentNull(valueArgument, nameArgument);
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate is equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is not equal to <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentNull<T>(this T? valueArgument,
												  [NotNull] String nameArgument)
			where T : struct
		{
			ArgumentEqualityValidationUtility.RequireArgumentNull(valueArgument, nameArgument);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
