using BLToolkit.EditableObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Core
{
    public class UtilityValueModel<T> : EditableObject
    {
        
        public T ValueMember{get;set;}


        public string DisplayMember { get; set; }
       
        


    }
}
