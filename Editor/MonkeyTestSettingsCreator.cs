﻿using com.guidoarkesteijn.monkeytester.runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace com.guidoarkesteijn.monkeytester.editor
{
    public static class MonkeyTesterSettingsCreator
    {
        [InitializeOnLoadMethod]
        public static void MonkeyTesterSettingsCreate()
        {
            var monkeyTesterSettings = Resources.Load<MonkeyTesterSettings>(nameof(MonkeyTesterSettings));

            if (monkeyTesterSettings == null)
            {
                CreateMonkeyTesterSettings();
            }
        }

        private static void CreateMonkeyTesterSettings()
        {
            var monkeyTesterSettings = ScriptableObject.CreateInstance<MonkeyTesterSettings>();

            if (!AssetDatabase.IsValidFolder("Assets/Resources"))
            {
                AssetDatabase.CreateFolder("Assets", "Resources");
            }

            AssetDatabase.CreateAsset(monkeyTesterSettings, $"Assets/Resources/{nameof(MonkeyTesterSettings)}.asset");
        }
    }
}
