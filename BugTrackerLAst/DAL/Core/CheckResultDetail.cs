﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Joystick.BOL.Core
{
    public class CheckResultDetail
    {
        public enum ErrorType { None = 0, Warning = 1, Error = 2 }
        public CheckResultDetail(ErrorType type, String propertyName,String message)
        {
            this.Type = type;
            this.PropertyName = propertyName;
            this.Message = message;
        }
        public ErrorType Type
        {
            get;
            set;
        }
        public string PropertyName
        {
            get;
            set;

        }

        public string Message
        {
            get;
            set;

        }

        public Image ErrorImage { get; set; }
     
    }
}
