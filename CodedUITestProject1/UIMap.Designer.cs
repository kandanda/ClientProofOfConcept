﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WpfWindow uIWpfWindow = this.UIWpfWindow;
            WpfEdit uITextBoxEdit = this.UIMainWindowWindow.UITextBoxEdit;
            #endregion

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(488, 91));

            // Type 'Hallo Welt' in 'textBox' text box
            uITextBoxEdit.Text = this.RecordedMethod1Params.UITextBoxEditText;

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(118, 111));

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(520, 94));

            // Type '{Enter}' in 'textBox' text box
            Keyboard.SendKeys(uITextBoxEdit, this.RecordedMethod1Params.UITextBoxEditSendKeys, ModifierKeys.None);
        }
        
        /// <summary>
        /// RecordedMethod2 - Use 'RecordedMethod2Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations
            WpfWindow uIWpfWindow = this.UIWpfWindow;
            WpfEdit uITextBoxEdit = this.UIMainWindowWindow.UITextBoxEdit;
            #endregion

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(488, 91));

            // Type 'Hallo Welt' in 'textBox' text box
            uITextBoxEdit.Text = this.RecordedMethod2Params.UITextBoxEditText;

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(118, 111));

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(520, 94));

            // Type '{Enter}' in 'textBox' text box
            Keyboard.SendKeys(uITextBoxEdit, this.RecordedMethod2Params.UITextBoxEditSendKeys, ModifierKeys.None);

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(145, 111));

            // Type 'asdfsdf' in 'textBox' text box
            uITextBoxEdit.Text = this.RecordedMethod2Params.UITextBoxEditText1;

            // Click 'Wpf' window
            Mouse.Click(uIWpfWindow, new Point(136, 92));
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual RecordedMethod2Params RecordedMethod2Params
        {
            get
            {
                if ((this.mRecordedMethod2Params == null))
                {
                    this.mRecordedMethod2Params = new RecordedMethod2Params();
                }
                return this.mRecordedMethod2Params;
            }
        }
        
        public UIWpfWindow UIWpfWindow
        {
            get
            {
                if ((this.mUIWpfWindow == null))
                {
                    this.mUIWpfWindow = new UIWpfWindow();
                }
                return this.mUIWpfWindow;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private RecordedMethod2Params mRecordedMethod2Params;
        
        private UIWpfWindow mUIWpfWindow;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'Hallo Welt' in 'textBox' text box
        /// </summary>
        public string UITextBoxEditText = "Hallo Welt";
        
        /// <summary>
        /// Type '{Enter}' in 'textBox' text box
        /// </summary>
        public string UITextBoxEditSendKeys = "{Enter}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class RecordedMethod2Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'Hallo Welt' in 'textBox' text box
        /// </summary>
        public string UITextBoxEditText = "Hallo Welt";
        
        /// <summary>
        /// Type '{Enter}' in 'textBox' text box
        /// </summary>
        public string UITextBoxEditSendKeys = "{Enter}";
        
        /// <summary>
        /// Type 'asdfsdf' in 'textBox' text box
        /// </summary>
        public string UITextBoxEditText1 = "asdfsdf";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIWpfWindow : WpfWindow
    {
        
        public UIWpfWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            #endregion
        }
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfEdit UITextBoxEdit
        {
            get
            {
                if ((this.mUITextBoxEdit == null))
                {
                    this.mUITextBoxEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITextBoxEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBox";
                    this.mUITextBoxEdit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUITextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUITextBoxEdit;
        #endregion
    }
}