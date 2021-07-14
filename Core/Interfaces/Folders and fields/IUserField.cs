/*
 *  "Custom object application core"
 *  Application for creating and using freely customizable configuration of data, forms, actions and other things
 *  Copyright (C) 2018 by Maxim V. Yugov.
 *
 *  This file is part of "Custom object application".
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System.ComponentModel;

namespace CoaApp.Core.Interfaces
{
    /// <summary>
    /// Object user field
    /// </summary>
    public interface IUserField : IBase, IDataErrorInfo, INotifyPropertyChanged
    {
        /// <summary>
        /// Field value
        /// </summary>
        dynamic TValue { get; set; }
        /// <summary>
        /// Field definition
        /// </summary>
        IUserFieldDefinition Definition { get; }
        /// <summary>
        /// Is value null flag
        /// </summary>
        bool IsNull { get; }
        /// <summary>
        /// Field avaliability for editing
        /// </summary>
        bool IsEnabled { get; }
        /// <summary>
        /// Field mandatory for value
        /// </summary>
        bool IsRequired { get; }
    }
}