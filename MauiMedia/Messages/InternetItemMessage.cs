// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiMedia.Messages;
/// <summary>
/// A class that manages messages for whether the internet is working.
/// </summary>
public class InternetItemMessage : ValueChangedMessage<bool>
{
    public InternetItemMessage(bool value) : base(value)
    {
    }
}
