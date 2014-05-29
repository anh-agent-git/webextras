/*
* This file is part of - WebExtras
* Copyright (C) 2014 Mihir Mone
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
*
* You should have received a copy of the GNU Lesser General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using WebExtras.Core;

#pragma warning disable 1591

namespace WebExtras.JQPlot.SubOptions
{
  /// <summary>
  /// Chart renderer type
  /// </summary>
  [Serializable]
  public enum EJQPlotChartRenderer
  {
    /// <summary>
    /// The default line renderer for jqPlot, this class has no options beyond the Series class.  
    /// Draws series as a line.
    /// </summary>
    [StringValue("$.jqplot.LineRenderer")]
    LineRenderer,

    /// <summary>
    /// Requires: jqplot.barRenderer.min.js
    /// </summary>
    [StringValue("$.jqplot.BarRenderer")]
    BarRenderer,

    /// <summary>
    /// Requires: jqplot.ohlcRenderer.min.js
    /// </summary>
    [StringValue("$.jqplot.OHLCRenderer")]
    OHLCRenderer
  }
}
