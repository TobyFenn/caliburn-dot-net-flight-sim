﻿#pragma checksum "..\..\..\Views\ShellView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F5FE73983D34093C3AE8BDBC83320F35A58D6D924DD4EF54C0CE41BC82D64BE0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFUI.ViewModels;
using WPFUI.Views;


namespace WPFUI.Views {
    
    
    /// <summary>
    /// ShellView
    /// </summary>
    public partial class ShellView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 103 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spNics;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl testItemsControl;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TrajectoriesComboBox;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunButton;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseButton;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopButton;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopyAllButton;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LatCopy;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LongCopy;
        
        #line default
        #line hidden
        
        
        #line 243 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YawCopy;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PitchCopy;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RollCopy;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YawROCCopy;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PitchROCCopy;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RollROCCopy;
        
        #line default
        #line hidden
        
        
        #line 273 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AltitudeCopy;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AirspeedCopy;
        
        #line default
        #line hidden
        
        
        #line 285 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PresetTextBox;
        
        #line default
        #line hidden
        
        
        #line 306 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PresetNameBorder;
        
        #line default
        #line hidden
        
        
        #line 315 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PresetSuccessBorder;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InitialPositionSaveButton;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CurrentPositionSaveButton;
        
        #line default
        #line hidden
        
        
        #line 335 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border InitialPosBorder;
        
        #line default
        #line hidden
        
        
        #line 346 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CurrentPosBorder;
        
        #line default
        #line hidden
        
        
        #line 375 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LatInputBox;
        
        #line default
        #line hidden
        
        
        #line 376 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LongInputBox;
        
        #line default
        #line hidden
        
        
        #line 377 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YawInputBox;
        
        #line default
        #line hidden
        
        
        #line 378 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PitchInputBox;
        
        #line default
        #line hidden
        
        
        #line 379 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RollInputBox;
        
        #line default
        #line hidden
        
        
        #line 380 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YawROCInputBox;
        
        #line default
        #line hidden
        
        
        #line 381 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PitchROCInputBox;
        
        #line default
        #line hidden
        
        
        #line 382 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RollROCInputBox;
        
        #line default
        #line hidden
        
        
        #line 383 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AltitudeInputBox;
        
        #line default
        #line hidden
        
        
        #line 386 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AirspeedInputBox;
        
        #line default
        #line hidden
        
        
        #line 388 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AirspeedUnitsInputBox;
        
        #line default
        #line hidden
        
        
        #line 399 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClimbAngleInputBox;
        
        #line default
        #line hidden
        
        
        #line 402 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox XInputBox;
        
        #line default
        #line hidden
        
        
        #line 405 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YInputBox;
        
        #line default
        #line hidden
        
        
        #line 408 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZInputBox;
        
        #line default
        #line hidden
        
        
        #line 411 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GroundSpeedInputBox;
        
        #line default
        #line hidden
        
        
        #line 414 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GroundCourseInputBox;
        
        #line default
        #line hidden
        
        
        #line 418 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox latOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 419 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox longOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 420 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yawOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 421 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pitchOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 422 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rollOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 423 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yawROCOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 424 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pitchROCOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 425 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rollROCOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 426 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox altitudeOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 427 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox airspeedOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 428 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox climbAngleOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 429 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox XOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 430 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 431 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 432 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox groundSpeedOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 433 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox groundCourseOutputTextBox;
        
        #line default
        #line hidden
        
        
        #line 450 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CustomTimestampBorder;
        
        #line default
        #line hidden
        
        
        #line 462 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CTSCheck;
        
        #line default
        #line hidden
        
        
        #line 465 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border InitialCTSBorder;
        
        #line default
        #line hidden
        
        
        #line 473 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CTSLabel;
        
        #line default
        #line hidden
        
        
        #line 475 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CTSInputBox;
        
        #line default
        #line hidden
        
        
        #line 476 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CTSOutputBox;
        
        #line default
        #line hidden
        
        
        #line 481 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CTSCopy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFUI;component/views/shellview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ShellView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.spNics = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.testItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 3:
            this.TrajectoriesComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.RunButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.StopButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.CopyAllButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.LatCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.LongCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.YawCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.PitchCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.RollCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.YawROCCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.PitchROCCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.RollROCCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.AltitudeCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 17:
            this.AirspeedCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 18:
            this.PresetTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.PresetNameBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 20:
            this.PresetSuccessBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 21:
            this.InitialPositionSaveButton = ((System.Windows.Controls.Button)(target));
            return;
            case 22:
            this.CurrentPositionSaveButton = ((System.Windows.Controls.Button)(target));
            return;
            case 23:
            this.InitialPosBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 24:
            this.CurrentPosBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 25:
            this.LatInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 26:
            this.LongInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 27:
            this.YawInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 28:
            this.PitchInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 29:
            this.RollInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 30:
            this.YawROCInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 31:
            this.PitchROCInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 32:
            this.RollROCInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 33:
            this.AltitudeInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 34:
            this.AirspeedInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 35:
            this.AirspeedUnitsInputBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 36:
            this.ClimbAngleInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 37:
            this.XInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 38:
            this.YInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 39:
            this.ZInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 40:
            this.GroundSpeedInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 41:
            this.GroundCourseInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 42:
            this.latOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 43:
            this.longOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 44:
            this.yawOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 45:
            this.pitchOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 46:
            this.rollOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 47:
            this.yawROCOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 48:
            this.pitchROCOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 49:
            this.rollROCOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 50:
            this.altitudeOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 51:
            this.airspeedOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 52:
            this.climbAngleOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 53:
            this.XOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 54:
            this.YOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 55:
            this.ZOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 56:
            this.groundSpeedOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 57:
            this.groundCourseOutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 58:
            this.CustomTimestampBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 59:
            this.CTSCheck = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 60:
            this.InitialCTSBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 61:
            this.CTSLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 62:
            this.CTSInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 63:
            this.CTSOutputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 64:
            this.CTSCopy = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

