﻿using BrightIdeasSoftware;
using System.Windows.Forms;
using System;

namespace WinFwk.UITools
{
    public class DefaultListView : FastObjectListView
    {
        public DefaultListView()
        {
            this.Init();
        }

        public void BuildGroups(string colName, SortOrder order, bool colIsVisible=false)
        {
            var col = AllColumns.Find(c => c.Name == colName);
            col.IsVisible = colIsVisible;
            BuildGroups(col, order);
        }

        public void InitColumns<T>()
        {
            Generator.GenerateColumns(this, typeof(T), false);
        }
    }
}