﻿// Copyright (c) Hochschule für Technik Rapperswil. All Rights Reserved.
// Licensed under the Apache 2.0 license. See LICENSE.txt in the project root for license information.

namespace Hsr.Campus.iOS
{
    using System;
    using MvvmCross.Platform.Converters;

    public class LocalTimeConverter
        : MvxValueConverter<DateTime>
    {
        protected override object Convert(DateTime value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => value.ToLocalTime();
    }
}
