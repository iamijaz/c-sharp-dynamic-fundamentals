﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace CustomDynamic
{
    public class HtmlElement
    {
        public string TagName { get; }

        public HtmlElement(string tagName)
        {
            TagName = tagName;
        }
    }    
}