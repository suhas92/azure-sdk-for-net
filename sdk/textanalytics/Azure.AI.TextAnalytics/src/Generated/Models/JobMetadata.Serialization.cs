// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class JobMetadata
    {
        internal static JobMetadata DeserializeJobMetadata(JsonElement element)
        {
            DateTimeOffset createdDateTime = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> expirationDateTime = default;
            Guid jobId = default;
            DateTimeOffset lastUpdateDateTime = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDateTime"))
                {
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
            }
            return new JobMetadata(createdDateTime, displayName.Value, Optional.ToNullable(expirationDateTime), jobId, lastUpdateDateTime, status);
        }
    }
}
