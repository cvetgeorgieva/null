﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface INewTaskPage
    {
        public void NewTaskPage(ObservableCollection<string> children);
    }
}
