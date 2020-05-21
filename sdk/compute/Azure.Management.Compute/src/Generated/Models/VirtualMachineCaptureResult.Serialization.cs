// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineCaptureResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Schema != null)
            {
                writer.WritePropertyName("$schema");
                writer.WriteStringValue(Schema);
            }
            if (ContentVersion != null)
            {
                writer.WritePropertyName("contentVersion");
                writer.WriteStringValue(ContentVersion);
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            if (Resources != null)
            {
                writer.WritePropertyName("resources");
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineCaptureResult DeserializeVirtualMachineCaptureResult(JsonElement element)
        {
            string schema = default;
            string contentVersion = default;
            object parameters = default;
            IList<object> resources = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("$schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("resources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineCaptureResult(id, schema, contentVersion, parameters, resources);
        }
    }
}