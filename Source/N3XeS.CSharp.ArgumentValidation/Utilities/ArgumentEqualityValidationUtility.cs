#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="ArgumentEqualityValidationUtility.cs">
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

// These were put in to fix problems with 3rd party software misdiagnosing code problems.
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedTypeParameter
namespace N3XeS.CSharp.ArgumentValidation.Utilities
{
	#region Directives

	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Globalization;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

	using System.Numerics;

#endif

	using JetBrains.Annotations;

	using Analyzation.Extensions;

	using Attributes;
	using Extensions;
	using Properties;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		An argument equality validation related utility.
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
	public static class ArgumentEqualityValidationUtility
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
		 SuppressMessage("Microsoft.Naming", 
						 "CA1702:CompoundWordsShouldBeCasedCorrectly", 
						 Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.", 
						 MessageId = "WhiteSpace")]
		public static void RequireArgumentHasNonWhiteSpaceValue([CanBeNull, ValidatedNotNull] String valueArgument,
																[NotNull] String nameArgument)
		{
			if (nameArgument.IsNull())
			{
				throw new ArgumentNullException(nameof(nameArgument), String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustNotBeNull));
			}

			if (nameArgument.HasNullOrWhiteSpaceValue())
			{
				throw new ArgumentOutOfRangeException(nameof(nameArgument), nameArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.StringValueMustNotBeEmptyOrWhiteSpace));
			}

			if (valueArgument.IsNull())
			{
				throw new ArgumentNullException(nameArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustNotBeNull));
			}

			if (valueArgument.HasNullOrWhiteSpaceValue())
			{
				throw new ArgumentOutOfRangeException(valueArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.StringValueMustNotBeEmptyOrWhiteSpace));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is <see langword="null"/> or empty.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.String"/> argument value to validate is <see langword="null"/> or empty.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.String"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is not <see langword="null"/> or empty.</exception>
		public static void RequireArgumentHasNoValue([CanBeNull] String valueArgument,
													 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.HasValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.StringValueMustBeNullAndEmpty));
			}
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
		[SuppressMessage("Microsoft.Naming", 
						 "CA1702:CompoundWordsShouldBeCasedCorrectly", 
						 Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.", 
						 MessageId = "WhiteSpace")]
		public static void RequireArgumentHasNullEmptyOrWhiteSpaceValue([CanBeNull] String valueArgument,
																		[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.HasNonWhiteSpaceValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.StringValueMustBeNullEmptyOrWhiteSpace));
			}
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
		public static void RequireArgumentHasValue([CanBeNull, ValidatedNotNull] String valueArgument,
												   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNull())
			{
				throw new ArgumentNullException(nameArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustNotBeNull));
			}

			if (valueArgument.HasNoValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.StringValueMustNotBeEmpty));
			}
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
		public static void RequireArgumentApproximatelyDefaultValue(Double valueArgument,
																	[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotApproximatelyDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </summary>
		/// <param name="valueArgument">
		///		The <see cref="T:System.Single"/> argument value to validate is approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Single"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		///		The <paramref name="valueArgument"/> is not approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </exception>
		public static void RequireArgumentApproximatelyDefaultValue(Single valueArgument,
																	[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotApproximatelyDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual(Double valueArgumentA,
															 Double valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual([CanBeNull] Double? valueArgumentA,
															 Double valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual(Double valueArgumentA,
															 [CanBeNull] Double? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual([CanBeNull] Double? valueArgumentA,
															 [CanBeNull] Double? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual(Single valueArgumentA,
															 Single valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual([CanBeNull] Single? valueArgumentA,
															 Single valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual(Single valueArgumentA,
															 [CanBeNull] Single? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentApproximatelyEqual([CanBeNull] Single? valueArgumentA,
															 [CanBeNull] Single? valueArgumentB,
															 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsNotApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentDefault<T>([CanBeNull] T valueArgument,
													 [NotNull] String nameArgument)
			where T : class
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefault())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeDefault));
			}
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
		public static void RequireArgumentDefaultValue(BigInteger valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] BigInteger? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(DateTime valueArgument,
													  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeMinimumDateTime));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] DateTime? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(Guid valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeEmptyGuid));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Guid? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(Byte valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Byte? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(Char valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeDefaultCharacter));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Char? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(Decimal valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Decimal? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Double? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Single? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(Int32 valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Int32? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(Int64 valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Int64? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(SByte valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue([CanBeNull] SByte? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(Int16 valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentDefaultValue([CanBeNull] Int16? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(UInt32 valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue([CanBeNull] UInt32? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(UInt64 valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue([CanBeNull] UInt64? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue(UInt16 valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentDefaultValue([CanBeNull] UInt16? valueArgument,
													   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
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
		public static void RequireArgumentDefaultValue<T>(T valueArgument,
														  [NotNull] String nameArgument)
			where T : struct
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeDefault));
			}
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
		public static void RequireArgumentDefaultValue<T>([CanBeNull] T? valueArgument,
														  [NotNull] String nameArgument)
			where T : struct
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeDefault));
			}
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
		public static void RequireArgumentNotApproximatelyDefaultValue(Double valueArgument,
																	   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsApproximatelyDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyDefaultValue(Single valueArgument,
																	   [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsApproximatelyDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual(Double valueArgumentA,
																Double valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual([CanBeNull] Double? valueArgumentA,
																Double valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual(Double valueArgumentA,
																[CanBeNull] Double? valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual(Double? valueArgumentA,
																Double? valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual(Single valueArgumentA,
																Single valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual([CanBeNull] Single? valueArgumentA,
																Single valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual(Single valueArgumentA,
																[CanBeNull] Single? valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotApproximatelyEqual([CanBeNull] Single? valueArgumentA,
																[CanBeNull] Single? valueArgumentB,
																[NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgumentA.IsApproximatelyEqual(valueArgumentB))
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgumentB, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeZero));
			}
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
		public static void RequireArgumentNotDefault<T>([NotNull, ValidatedNotNull] T valueArgument,
														[NotNull] String nameArgument)
			where T : class
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefault())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeDefault));
			}
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
		public static void RequireArgumentNotDefaultValue(BigInteger valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		public static void RequireArgumentNotDefaultValue([NotNull, ValidatedNotNull] BigInteger? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(DateTime valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeMinimumDateTime));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] DateTime? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(Guid valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeEmptyGuid));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Guid? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(Byte valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Byte? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(Char valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeDefaultCharacter));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Char? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(Decimal valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Decimal? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Double? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Single? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(Int32 valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Int32? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(Int64 valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Int64? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(SByte valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:null => halt")]
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] SByte? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(Int16 valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] Int16? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(UInt32 valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:null => halt")]
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] UInt32? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(UInt64 valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:null => halt")]
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] UInt64? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue(UInt16 valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeZero));
			}
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
		[CLSCompliant(false), 
		 ContractAnnotation("valueArgument:null => halt")]
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue([CanBeNull, ValidatedNotNull] UInt16? valueArgument,
														  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeNull));
			}
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
		public static void RequireArgumentNotDefaultValue<T>(T valueArgument,
															 [NotNull] String nameArgument)
			where T : struct
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeDefault));
			}
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
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotDefaultValue<T>([CanBeNull, ValidatedNotNull] T? valueArgument,
															 [NotNull] String nameArgument)
			where T : struct
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsDefaultValue())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustNotBeDefault));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is not <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is not equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="valueArgument"/> is <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:null => halt")]
		public static void RequireArgumentNotNull<T>([CanBeNull, ValidatedNotNull] T valueArgument,
													 [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNull())
			{
				throw new ArgumentNullException(nameArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustNotBeNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is not <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate is not equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="valueArgument"/> is <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:null => halt")]
		// ReSharper disable once NotNullOnImplicitCanBeNull
		public static void RequireArgumentNotNull<T>([CanBeNull, ValidatedNotNull] T? valueArgument,
													 [NotNull] String nameArgument)
			where T : struct
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNull())
			{
				throw new ArgumentNullException(nameArgument, String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustNotBeNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <typeparamref name="T"/> to validate is equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is not equal to <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentNull<T>([CanBeNull] T valueArgument,
												  [NotNull] String nameArgument)
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotNull())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
		}

		/// <summary>
		///		Validates that the <paramref name="valueArgument"/> is equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type the value to validate is <see langword="null"/>.</typeparam>
		/// <param name="valueArgument">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to validate is equal to <see langword="null"/>.</param>
		/// <param name="nameArgument">The argument name of the <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> value.</param>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="valueArgument"/> is not equal to <see langword="null"/>.</exception>
		[ContractAnnotation("valueArgument:notnull => halt")]
		public static void RequireArgumentNull<T>([CanBeNull] T? valueArgument,
												  [NotNull] String nameArgument)
			where T : struct
		{
			nameArgument.RequireArgumentHasNonWhiteSpaceValue("nameArgument");

			if (valueArgument.IsNotNull())
			{
				throw new ArgumentOutOfRangeException(nameArgument, valueArgument, String.Format(CultureInfo.InvariantCulture, "{0}.  {1}.", Resources.ValueOutOfRange, Resources.ValueMustBeNull));
			}
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
