﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using dnSpy.Contracts.Hex.Editor;

namespace dnSpy.Contracts.Settings.HexGroups {
	/// <summary>
	/// Hex view option changed event args
	/// </summary>
	public sealed class HexViewOptionChangedEventArgs : EventArgs {
		/// <summary>
		/// Tag
		/// </summary>
		public string Tag { get; }

		/// <summary>
		/// Option id, eg. <see cref="DefaultHexViewOptions.BytesPerLineName"/>
		/// </summary>
		public string OptionId { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tag">Tag</param>
		/// <param name="optionId">Option id, eg. <see cref="DefaultHexViewOptions.BytesPerLineName"/></param>
		public HexViewOptionChangedEventArgs(string tag, string optionId) {
			if (tag == null)
				throw new ArgumentNullException(nameof(tag));
			if (optionId == null)
				throw new ArgumentNullException(nameof(optionId));
			Tag = tag;
			OptionId = optionId;
		}
	}
}