﻿#region License

// -----------------------------------------------------------------------------------------------------------
// 
// Name: ToggleBase.cs
// VisualPlus - The VisualPlus Framework (VPF) for WinForms .NET development.
// 
// Created: 10/12/2018 - 11:45 PM
// Last Modified: 02/01/2019 - 1:27 AM
// 
// Copyright (c) 2016-2019 VisualPlus <https://darkbyte7.github.io/VisualPlus/>
// All Rights Reserved.
// 
// -----------------------------------------------------------------------------------------------------------
// 
// GNU General Public License v3.0 (GPL-3.0)
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER
// EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF
// MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//  
// This file is subject to the terms and conditions defined in the file 
// 'LICENSE.md', which should be in the root directory of the source code package.
// 
// -----------------------------------------------------------------------------------------------------------

#endregion

#region Namespace

using System.ComponentModel;
using System.Runtime.InteropServices;

using VisualPlus.Delegates;
using VisualPlus.Events;
using VisualPlus.Localization;

#endregion

namespace VisualPlus.Toolkit.VisualBase
{
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public abstract class ToggleBase : VisualStyleBase
    {
        #region Public Events

        [Category(EventCategory.PropertyChanged)]
        [Description("Occours when the toggle has been changed on the control.")]
        public event ToggleChangedEventHandler ToggleChanged;

        #endregion

        #region Properties

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal bool Toggle { get; set; }

        #endregion

        #region Methods

        protected virtual void OnToggleChanged(ToggleEventArgs e)
        {
            ToggleChanged?.Invoke(e);
        }

        #endregion
    }
}