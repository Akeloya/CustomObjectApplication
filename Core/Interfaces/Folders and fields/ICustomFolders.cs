﻿/*
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
namespace CoaApp.Core.Interfaces
{
    /// <summary>
    /// Custom folder collection
    /// </summary>
    public interface ICustomFolders : IBase
    {
        /// <summary>
        /// Acces to collection by index
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ICustomFolder/null</returns>
        ICustomFolder this[int id] { get; }
        /// <summary>
        /// Access to folder in collection by alias
        /// </summary>
        /// <param name="alias">Folder alias</param>
        /// <returns>ICustomFolder/null</returns>
        ICustomFolder this[string alias] { get; }
        /// <summary>
        /// Folder count
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Add new folder
        /// </summary>
        /// <param name="name">Folder name</param>
        /// <param name="alias">Folder alias</param>
        /// <param name="parentFolder">Parent folder</param>
        /// <returns></returns>
        ICustomFolder Add(string name, string alias, ICustomFolder parentFolder);
        /// <summary>
        /// Remove folder
        /// </summary>
        /// <param name="id">Removing folder id</param>
        /// <param name="force">Ignore existing objects</param>
        void Remove(int id, bool force = false);
        /// <summary>
        /// Remove folder
        /// </summary>
        /// <param name="folder">Folder object to remove</param>
        /// <param name="force">Ignore existing objects</param>
        void Remove(ICustomFolder folder, bool force = false);
    }
}