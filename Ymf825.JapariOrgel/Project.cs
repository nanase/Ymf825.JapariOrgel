﻿using System;
using System.Collections.Generic;

namespace Ymf825.JapariOrgel
{
    [Serializable]
    public class Project
    {
        #region -- Public Properties --

        public IEnumerable<ToneItem> Tones { get; set; }

        public IEnumerable<EqualizerItem> Equalizers { get; set; }

        #endregion
    }
}
