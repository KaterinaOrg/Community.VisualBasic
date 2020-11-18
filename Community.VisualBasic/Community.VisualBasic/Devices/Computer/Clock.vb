﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Option Strict On
Option Explicit On

Namespace Global.Community.VisualBasic.Devices

  ''' <summary>
  ''' A wrapper object that acts as a discovery mechanism to quickly find out
  ''' the current local time of the machine and the GMT time.
  ''' </summary>
  Public Class Clock

    ''' <summary>
    ''' Gets a Date that is the current local date and time on this computer.
    ''' </summary>
    ''' <value>A Date whose value is the current date and time.</value>
    Public ReadOnly Property LocalTime() As Date
      Get
        Return Date.Now
      End Get
    End Property

    ''' <summary>
    ''' Gets a DateTime that is the current local date and time on this
    ''' computer expressed as GMT time.
    ''' </summary>
    ''' <value>A Date whose value is the current date and time expressed as GMT time.</value>
    Public ReadOnly Property GmtTime() As Date
      Get
        Return Date.UtcNow
      End Get
    End Property

    ''' <summary>
    ''' This property wraps the Environment.TickCount property to get the
    ''' number of milliseconds elapsed since the system started.
    ''' </summary>
    ''' <value>An Integer containing the amount of time in milliseconds.</value>
    Public ReadOnly Property TickCount() As Integer
      Get
        Return Environment.TickCount
      End Get
    End Property

  End Class

End Namespace