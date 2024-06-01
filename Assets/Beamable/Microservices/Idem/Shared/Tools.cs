﻿using System;
using UnityEngine;

namespace Beamable.Microservices.Idem.Shared
{
    public static class JsonUtil
    {
        public static T Parse<T>(string json)
        {
            try
            {
                return CompactJson.Serializer.Parse<T>(json);
            }
            catch (Exception e)
            {
                Debug.LogError($"Could not parse json to {nameof(T)}: {e.Message}");
                return default;
            }
        }
    }

    public static class Extentions
    {
        public static string ToJson(this object obj, bool pretty = false)
            => CompactJson.Serializer.ToString(obj, pretty);
    }
}