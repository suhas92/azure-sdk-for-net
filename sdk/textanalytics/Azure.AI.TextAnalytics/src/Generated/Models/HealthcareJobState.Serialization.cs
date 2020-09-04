// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareJobState
    {
        internal static HealthcareJobState DeserializeHealthcareJobState(JsonElement element)
        {
            Optional<HealthcareResult> results = default;
            Optional<string> nextLink = default;
            DateTimeOffset createdDateTime = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> expirationDateTime = default;
            Guid jobId = default;
            DateTimeOffset lastUpdateDateTime = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = HealthcareResult.DeserializeHealthcareResult(property.Value);
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
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
            return new HealthcareJobState(createdDateTime, displayName.Value, Optional.ToNullable(expirationDateTime), jobId, lastUpdateDateTime, status, results.Value, nextLink.Value);
        }
    }
}
