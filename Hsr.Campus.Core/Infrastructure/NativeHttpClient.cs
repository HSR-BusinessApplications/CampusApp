﻿// Copyright (c) Hochschule für Technik Rapperswil. All Rights Reserved.
// Licensed under the Apache 2.0 license. See LICENSE.txt in the project root for license information.

namespace Hsr.Campus.Core.Infrastructure
{
    using System.Net.Http;
    using ApplicationServices;

    public class NativeHttpClient
        : HttpClient
    {
        public NativeHttpClient(IHttpClientConfiguration httpClientConfiguration)
            : base(httpClientConfiguration.MessageHandler)
        {
            httpClientConfiguration.RegisterServerCertificateValidationCallback();
        }
    }
}
