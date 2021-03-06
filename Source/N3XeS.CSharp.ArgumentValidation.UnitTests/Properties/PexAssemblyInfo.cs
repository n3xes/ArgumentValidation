#region Header: Copyright © 2016, John Caruthers

// --------------------------------------------------------------------------------------------------------------------
// <copyright company="John Caruthers" file="AssemblyInfo.cs">
//		Copyright © 2016, John Caruthers
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
////-------------------------------------------------------------------------------------------------------------------

#endregion

#region Directives

using System;

using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Suppression;
using Microsoft.Pex.Framework.Validation;

#endregion

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.QualityTools.UnitTestFramework")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexSuppressStaticFieldStore("N3XeS.CSharp.ArgumentValidation.Properties.Resources", "resourceMan")]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(Math))]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("N3XeS.CSharp.ArgumentValidation")]
[assembly: PexInstrumentAssembly("Microsoft.Pex.Framework")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.QualityTools.UnitTestFramework")]
[assembly: PexInstrumentAssembly("System.Core")]

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

