﻿// Copyright (c) 2016-2017 Alexander Ong
// See LICENSE in project root for license information.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin {
    Dictionary<string, UnityEngine.Object> m_skinObjects = new Dictionary<string, UnityEngine.Object>();

    public T GetSkinItem<T>(string key, T defaultItem) where T : UnityEngine.Object
    {
        T skinItem = null;

        UnityEngine.Object outObject;
        if (m_skinObjects.TryGetValue(key, out outObject))
            skinItem = outObject as T;

        if (!skinItem)
            skinItem = defaultItem;

        return skinItem;
    }

    public void AddSkinItem<T>(string key, T skinItem) where T : UnityEngine.Object
    {
        if (skinItem)
            m_skinObjects.Add(key, skinItem);
    }

    public Texture2D[] reg_strum = new Texture2D[6];
    public Texture2D[] reg_hopo = new Texture2D[6];
    public Texture2D[] reg_tap = new Texture2D[5];
    public Texture2D[] sp_strum = new Texture2D[6];
    public Texture2D[] sp_hopo = new Texture2D[6];
    public Texture2D[] sp_tap = new Texture2D[5];

    public Texture2D[] sustains = new Texture2D[5];
    public Material[] sustain_mats = new Material[6];

    public Texture2D[] reg_strum_ghl = new Texture2D[3];
    public Texture2D[] reg_hopo_ghl = new Texture2D[3];
    public Texture2D[] reg_tap_ghl = new Texture2D[2];
    public Texture2D[] sp_strum_ghl = new Texture2D[3];
    public Texture2D[] sp_hopo_ghl = new Texture2D[3];
    public Texture2D[] sp_tap_ghl = new Texture2D[2];

    public enum AssestsAvaliable
    {
        None, All, Mixed
    }
}