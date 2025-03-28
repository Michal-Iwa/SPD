﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackson_Algorithm
{
    public class Task
    {
        public int id;
        public int relaese_date;
        public int processing_time;
        public int delivery_time;
        public bool done;
        public Task()
        {
            id=0;
            relaese_date = 0;
            processing_time = 0;
            delivery_time = 0;
            done = false;
        }
        public Task(int i, int r, int p, int d)
        {
            id = i;
            relaese_date = r;
            processing_time = p;
            delivery_time = d;
            done = false;
        }
        public override string ToString()
        {
            return "Id : " + id + " Termin gotowosci: " + relaese_date + ", Czas wykonania: " + processing_time + ", Czas dostarczania: " + delivery_time + "\n";
        }
    }
}
