﻿#pragma checksum "C:\Users\admin\source\repos\UwAssigement\UwAssigement\Views\Register.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F03DF6466B2552D6C2DD0E9CE9896A04"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UwAssigement.Views
{
    partial class Register : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Register.xaml line 14
                {
                    this.LeftForm1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Views\Register.xaml line 27
                {
                    this.LeftForm2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\Register.xaml line 46
                {
                    this.ImageUrl = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Views\Register.xaml line 47
                {
                    this.MyAvatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6: // Views\Register.xaml line 50
                {
                    this.btn1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn1).Click += this.btnSumit;
                }
                break;
            case 7: // Views\Register.xaml line 51
                {
                    this.btn2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn2).Click += this.btnReset;
                }
                break;
            case 8: // Views\Register.xaml line 52
                {
                    this.btn3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn3).Click += this.btnCancel;
                }
                break;
            case 9: // Views\Register.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Capture_Photo;
                }
                break;
            case 10: // Views\Register.xaml line 29
                {
                    this.Gender_Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\Register.xaml line 35
                {
                    this.BirthDay = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.BirthDay).DateChanged += this.Change_Birthday;
                }
                break;
            case 12: // Views\Register.xaml line 36
                {
                    this.Birthday_Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\Register.xaml line 37
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Address).TextChanged += this.Address_TextChanged;
                }
                break;
            case 14: // Views\Register.xaml line 38
                {
                    this.Introduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Views\Register.xaml line 31
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element15 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element15).Checked += this.Select_Gender;
                }
                break;
            case 16: // Views\Register.xaml line 32
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element16 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element16).Checked += this.Select_Gender;
                }
                break;
            case 17: // Views\Register.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element17 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element17).Checked += this.Select_Gender;
                }
                break;
            case 18: // Views\Register.xaml line 15
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19: // Views\Register.xaml line 16
                {
                    this.Email_Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // Views\Register.xaml line 17
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 21: // Views\Register.xaml line 18
                {
                    this.Password_Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22: // Views\Register.xaml line 19
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 23: // Views\Register.xaml line 20
                {
                    this.FirstName_Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24: // Views\Register.xaml line 21
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 25: // Views\Register.xaml line 22
                {
                    this.Lastname_Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26: // Views\Register.xaml line 23
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 27: // Views\Register.xaml line 24
                {
                    this.Phone_Message = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

