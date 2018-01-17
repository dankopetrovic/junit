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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace jUnitTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("d671cc95-3bb6-4644-abb7-301f4105d891", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the jUnitTestRepository repository.
        /// </summary>
        public static jUnitTestRepository repo = jUnitTestRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            NewVariable = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewVariable;

        /// <summary>
        /// Gets or sets the value of variable NewVariable.
        /// </summary>
        [TestVariable("85407505-eaf1-4a4f-819d-364ce97324ec")]
        public string NewVariable
        {
            get { return _NewVariable; }
            set { _NewVariable = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(0));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Error, "User", "dg", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "User", "sdf", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "User", "gfh", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "User", "ghjsd", new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
