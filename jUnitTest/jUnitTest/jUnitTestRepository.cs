﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace jUnitTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the jUnitTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    [RepositoryFolder("1a1d8efe-adb1-42ae-81f8-fd3f5bdf9035")]
    public partial class jUnitTestRepository : RepoGenBaseFolder
    {
        static jUnitTestRepository instance = new jUnitTestRepository();

        /// <summary>
        /// Gets the singleton class instance representing the jUnitTestRepository element repository.
        /// </summary>
        [RepositoryFolder("1a1d8efe-adb1-42ae-81f8-fd3f5bdf9035")]
        public static jUnitTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public jUnitTestRepository() 
            : base("jUnitTestRepository", "/", null, 0, false, "1a1d8efe-adb1-42ae-81f8-fd3f5bdf9035", ".\\RepositoryImages\\jUnitTestRepository1a1d8efe.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1a1d8efe-adb1-42ae-81f8-fd3f5bdf9035")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    public partial class jUnitTestRepositoryFolders
    {
    }
#pragma warning restore 0436
}