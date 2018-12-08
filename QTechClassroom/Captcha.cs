﻿using System;
using System.Collections;
using System.Linq;

namespace QTechClassroom
{
    public class Captcha
    {

    }

    public class CaptchaModel
    {
        #region [Fields] ...
        static readonly string labels = "0123456789ABCDEFHJKLMNPQRSTUVWXYZabdefghjmnqrtwxy";
        static readonly string[] modelsBase64 = {
            "cIA/MAaDYTAMhsEwGAbDYDAG/gAHAAAAAAAAAA==",
            "cIAP8AEwAAbAABgAA2AADIAB/sE/AAAAAAAAAA==",
            "fMAfCAbAABiAARiAARiAARgA/+AfAAAAAAAAAA==",
            "fMA/CAbAAAz4AD8ADoABMAgHf8AHAAAAAAAAAA==",
            "gAAcgAN4gA2wATNgBv7DfwADYAAMAAAAAAAAAA==",
            "/sE/GAADYAB8gD8ADoABNAgHf8AHAAAAAAAAAA==",
            "8AA/MAQGYADsgX9wHAbDYDAO/gAPAAAAAAAAAA==",
            "/IN/AAyAABiAARAAAyAABsAADIABAAAAAAAAAA==",
            "+IA/MAbGwAnwAT5gDgbDYDgO/oAPAAAAAAAAAA==",
            "eIA/OAaDYTAcB/+AGwADMBAGfoAHAAAAAAAAAA==",
            "cAAOYANsgA04A2NgDP7DfxiMATNgAAAAAAAAAA==",
            "fsAfGANjYAZ8gB8wBobBMBgHf+AHAAAAAAAAAA==",
            "8AF/cAgHYAAMgAEwAAbAAXAI+AEfAAAAAAAAAA==",
            "/sA/GA6DY2AMjIExMAbGYBgO/+APAAAAAAAAAA==",
            "/sE/GAADYAD8gT8wAAbAABgA/+AfAAAAAAAAAA==",
            "/sAfGAADYAAMgB/wAwbAABgAA2AAAAAAAAAAAA==",
            "BsbAGBgDY2D8j/8xMAbGwBgYA2NgAAAAAAAAAA==",
            "DIABMAAGwAAYAANgAAyAATAABsAAHMADGAAAAA==",
            "BsMwGAMzYAZsgAewAWbAGBgGg2FgAAAAAAAAAA==",
            "BsAAGAADYAAMgAEwAAbAABgA/+AfAAAAAAAAAA==",
            "DtiDe3APbmdtrI01m2bTbBpH42gAAQAAAAAAAA==",
            "BsbBeBgPY2NsjJkxNsbG8Bgeg2NgAAAAAAAAAA==",
            "fsAfGAfDYBiMgz/wAQbAABgAA2AAAAAAAAAAAA==",
            "8AF/cBwGZ8AMmAEzYAaMwXEc/AEfAA6AB0AAAA==",
            "fsAfGAfDYBiMgz/wA2bAGBgGg2FgAAAAAAAAAA==",
            "PMAPGAEDYAA4AB4AB8AAGAgDP8ADAAAAAAAAAA==",
            "/+N/wAAYAANgAAyAATAABsAAGAADAAAAAAAAAA==",
            "BsNgGAyDYTAMhsEwGAbDYDgO/oAPAAAAAAAAAA==",
            "A0ZAGAyDwRgYA2PABtgAG8ABOAAAAAAAAAAAAA==",
            "w2E4GEejaDbNJttm22ybZeM4HIfjAAAAAAAAAA==",
            "A8MwGAZmgAfwAAzAA3iAGRgGwzAwAAAAAAAAAA==",
            "A8MwGAZmwAzwAAyAATAABsAAGAAAAAAAAAAAAA==",
            "/sE/AAZgAAbAAAzAABiAARgA/+AfAAAAAAAAAA==",
            "AAAAAAA8wA+IATDAB/zAGBgD/8AZAAAAAAAAAA==",
            "BsAAGAA74A+cg2EwDIbBMDgHf2AHAAAAAAAAAA==",
            "gAEwAAbcwB+cg2EwDIbBMDgH/oAbAAAAAAAAAA==",
            "AAAAAAAcwAecgTnwB/7AALgCfoAHAAAAAAAAAA==",
            "eIAPMAAf4AMYAANgAAyAATAABsAAAAAAAAAAAA==",
            "AAAAAADcwB+cg2EwDIbBMDgH/oAbAANx4Ad4AA==",
            "BsAAGABzYB8cg2EwDIbBMBgGw2AYAAAAAAAAAA==",
            "BsAAAAADYAAMgAEwAAbAABgAA2AADIABOAADAA==",
            "AAAAAABzbN8dh2EwDIbBMBgGw2AYAAAAAAAAAA==",
            "AAAAAABzYB8cg2EwDIbBMBgGw2AYAAAAAAAAAA==",
            "AAAAAADcwB+cg2EwDIbBMDgH/oAbAANgAAyAAQ==",
            "AAAAAAAf4AMcgAEwAAbAABgAA2AAAAAAAAAAAA==",
            "AMAAGIAP8AEMgAEwAAbAABgAD8ABAAAAAAAAAA==",
            "AAAAAIBxPI5HsW2zbbbNtlk0jsNxAAAAAAAAAA==",
            "AAAAAADDwAyYAR6AAzgADzADZmAYAAAAAAAAAA==",
            "AAAAAIDBMBiMgTEwBGyADaAAHIADMAACYAAMAA==",
        };
        static BitArray[] models = null;
        #endregion

        public static string Labels => labels;
        public static BitArray[] Models
        {
            get
            {
                models = models ?? modelsBase64.Select(b => Base64ToBitArray(b)).ToArray();
                return models;
            }
        }

        private static BitArray Base64ToBitArray(string base64)
            => new BitArray(Convert.FromBase64String(base64));
    }
}