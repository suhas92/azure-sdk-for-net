// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial struct LinkedEntity
    {
        internal static LinkedEntity DeserializeLinkedEntity(JsonElement element)
        {
            string name = default;
            IEnumerable<LinkedEntityMatch> matches = default;
            string language = default;
            Optional<string> id = default;
            Uri url = default;
            string dataSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matches"))
                {
                    List<LinkedEntityMatch> array = new List<LinkedEntityMatch>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedEntityMatch.DeserializeLinkedEntityMatch(item));
                    }
                    matches = array;
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSource"))
                {
                    dataSource = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedEntity(name, matches, language, id.Value, url, dataSource);
        }
    }
}
