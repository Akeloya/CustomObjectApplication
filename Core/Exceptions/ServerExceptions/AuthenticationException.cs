﻿/*
 *  "Custom object application core"
 *  An application that implements the ability to customize object templates and actions on them.
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
using CoaApp.Core.Properties;
using System;

namespace CoaApp.Core.Exceptions
{
    /// <summary>
    /// Authentication exception
    /// </summary>
    [Serializable]
    public class AuthenticationException : CoaApplicationException
    {
        public AuthenticationException(string message) : base(message, AppExceptionStatus.Work)
        {
        }

        public AuthenticationException(string message, Exception innerException) : base(message, innerException, AppExceptionStatus.Work)
        {
        }

        public AuthenticationException() : base(Resource.AuthenticationException, AppExceptionStatus.Work)
        {
        }

        public AuthenticationException(Exception innerException) : base(Resource.AuthenticationException, innerException, AppExceptionStatus.Work)
        {

        }
    }
}