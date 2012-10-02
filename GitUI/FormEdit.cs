﻿using System;
﻿
namespace GitUI
{
    public partial class FormEdit : GitExtensionsForm
    {
        public FormEdit(string text)
            : base(true)
        {
            InitializeComponent();
            Translate();
            Viewer.ViewText("", text);
            Viewer.IsReadOnly = false;
        }
    }
}