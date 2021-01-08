﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKutyaAdapter
{
    public class KutyaAdapter
    {
        string connString;
        public NevAdapter nevadapter;
        public FajtaAdapter fajtaadapter;
        KezelesAdapter kezelesadapter;

        public KutyaAdapter(string connstring)
        {
            connString = connstring;
            nevadapter = new NevAdapter(connString);
            fajtaadapter = new FajtaAdapter(connString);
            
        }
    }
}
