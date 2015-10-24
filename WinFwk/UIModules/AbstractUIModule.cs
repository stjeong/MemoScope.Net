﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WinFwk.UIMessages;
using WinFwk.UITools;

namespace WinFwk.UIModules
{
    public class UIModule : UserControl
    {
        protected MessageBus MessageBus { get; private set; }
        public Bitmap Icon { get; protected set; }
        public string Info { get; protected set; }
        public string Summary { get; protected set; }

        public void InitBus(MessageBus bus)
        {
            MessageBus = bus;
            MessageBus.Subscribe(this);
        }

        protected void Log(string text, LogLevelType logLevel= LogLevelType.Info)
        {
            MessageBus.SendMessage(new LogMessage(this, text, logLevel));
        }
        protected void Log(string text, Exception exception)
        {
            MessageBus.SendMessage(new LogMessage(this, text, exception));
        }
    }
}