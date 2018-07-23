﻿/*
==============================================================================
Copyright © Jason Tanner (Antebyte)

All rights reserved.

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

Except as contained in this notice, the name of the above copyright holder
shall not be used in advertising or otherwise to promote the sale, use or
other dealings in this Software without prior written authorization.
==============================================================================
*/

#region Imports

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion
namespace Networking
{
    // Completed event handlers.
    public delegate void ScanCompleteHandler(object sender, ScanCompleteEventArgs e);
    public delegate void ScanAsyncCompleteHandler(object sender, ScanAsyncCompleteEventArgs e);
    public delegate void ScanRangeCompleteHandler(object sender, ScanRangeCompleteEventArgs e);
    public delegate void ScanRangeAsyncCompleteHandler(object sender, ScanRangeAsyncCompleteEventArgs e);
    public delegate void ScanListCompleteHandler(object sender, ScanListCompleteEventArgs e);
    public delegate void ScanListAsyncCompleteHandler(object sender, ScanListAsyncCompleteEventArgs e);
    public delegate void PortKnockCompleteHandler(object sender, PortKnockCompleteEventArgs e);
    public delegate void PortKnockAsyncCompeleteHandler(object sender, PortKnockAsyncCompleteEventArgs e);
    public delegate void PortKnockRangeCompleteHandler(object sender, PortKnockRangeCompleteEventArgs e);
    public delegate void PortKnockRangeAsyncCompleteHandler(object sender, PortKnockRangeAsyncCompleteEventArgs e);
    public delegate void PortKnockListCompleteHandler(object sender, PortKnockListCompleteEventArgs e);
    public delegate void PortKnockListAsyncCompleteHandler(object sender, PortKnockListAsyncCompleteEventArgs e);

    // Progress changed event handlers.
    public delegate void ScanProgressChangedHandler(object sender, ScanProgressChangedEventArgs e);
    public delegate void ScanAsyncProgressChangedHandler(object sender, ScanAsyncProgressChangedEventArgs e);
    public delegate void ScanRangeProgressChangedHandler(object sender, ScanRangeProgressChangedEventArgs e);
    public delegate void ScanRangeAsyncProgressChangedHandler(object sender, ScanRangeAsyncProgressChangedEventArgs e);
    public delegate void ScanListProgressChangedHandler(object sender, ScanListProgressChangedEventArgs e);
    public delegate void ScanListAsyncProgressChangedHandler(object sender, ScanListAsyncProgressChangedEventArgs e);
    public delegate void PortKnockProgressChangedHandler(object sender, PortKnockProgressChangedEventArgs e);
    public delegate void PortKnockAsyncProgressChangedHandler(object sender, PortKnockAsyncProgressChangedEventArgs e);
    public delegate void PortKnockRangeProgressChangedHandler(object sender, PortKnockRangeProgressChangedEventArgs e);
    public delegate void PortKnockRangeAsyncProgressChangedHandler(object sender, PortKnockRangeAsyncProgressChangedEventArgs e);
    public delegate void PortKnockListProgressChangedHandler(object sender, PortKnockListProgressChangedEventArgs e);
    public delegate void PortKnockListAsyncProgressChangedHandler(object sender, PortKnockListAsyncProgressChangedEventArgs e);

    // Compeletd event args.
    public class ScanCompleteEventArgs : EventArgs
    {
        public IPScanObject Result { get; private set; }
        public ScanCompleteEventArgs(IPScanObject result)
        {
            Result = result;
        }
    }
    public class ScanAsyncCompleteEventArgs : EventArgs
    {
        public IPScanObject Result { get; private set; }
        public ScanAsyncCompleteEventArgs(IPScanObject result)
        {
            Result = result;
        }
    }
    public class ScanRangeCompleteEventArgs : EventArgs
    {
        public List<IPScanObject> Results { get; private set; }
        public ScanRangeCompleteEventArgs(List<IPScanObject> results)
        {
            Results = results;
        }
    }
    public class ScanRangeAsyncCompleteEventArgs : EventArgs
    {
        public List<IPScanObject> Results { get; private set; }
        public ScanRangeAsyncCompleteEventArgs(List<IPScanObject> results)
        {
            Results = results;
        }
    }
    public class ScanListCompleteEventArgs : EventArgs
    {
        public List<IPScanObject> Results { get; private set; }
        public ScanListCompleteEventArgs(List<IPScanObject> results)
        {
            Results = results;
        }
    }
    public class ScanListAsyncCompleteEventArgs : EventArgs
    {
        public List<IPScanObject> Results { get; private set; }
        public ScanListAsyncCompleteEventArgs(List<IPScanObject> results)
        {
            Results = results;
        }
    }
    public class PortKnockCompleteEventArgs : EventArgs
    {
        public PKScanObject Result { get; private set; }
        public PortKnockCompleteEventArgs(PKScanObject result)
        {
            Result = result;
        }
    }
    public class PortKnockAsyncCompleteEventArgs : EventArgs
    {
        public PKScanObject Result { get; private set; }
        public PortKnockAsyncCompleteEventArgs(PKScanObject result)
        {
            Result = result;
        }
    }
    public class PortKnockRangeCompleteEventArgs : EventArgs
    {
        public List<PKScanObject> Results { get; private set; }
        public PortKnockRangeCompleteEventArgs(List<PKScanObject> results)
        {
            Results = results;
        }
    }
    public class PortKnockRangeAsyncCompleteEventArgs : EventArgs
    {
        public List<PKScanObject> Results { get; private set; }
        public PortKnockRangeAsyncCompleteEventArgs(List<PKScanObject> results)
        {
            Results = results;
        }
    }
    public class PortKnockListCompleteEventArgs : EventArgs
    {
        public List<PKScanObject> Results { get; private set; }
        public PortKnockListCompleteEventArgs(List<PKScanObject> results)
        {
            Results = results;
        }
    }
    public class PortKnockListAsyncCompleteEventArgs : EventArgs
    {
        public List<PKScanObject> Results { get; private set; }
        public PortKnockListAsyncCompleteEventArgs(List<PKScanObject> results)
        {
            Results = results;
        }
    }

    // Progress changed event args.
    public class ScanProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public ScanProgressChangedEventArgs(int progress)
        {
            Progress = progress;
        }
    }
    public class ScanAsyncProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public ScanAsyncProgressChangedEventArgs(int progress)
        {
            Progress = progress;
        }
    }
    public class ScanRangeProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public ScanRangeProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
    public class ScanRangeAsyncProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public ScanRangeAsyncProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
    public class ScanListProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public ScanListProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
    public class ScanListAsyncProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public ScanListAsyncProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
    public class PortKnockProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public PortKnockProgressChangedEventArgs(int progress)
        {
            if (progress > Progress)
                Progress = progress;
        }
    }
    public class PortKnockAsyncProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public PortKnockAsyncProgressChangedEventArgs(int progress)
        {
            if (progress > Progress)
                Progress = progress;
        }
    }
    public class PortKnockRangeProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public PortKnockRangeProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
    public class PortKnockRangeAsyncProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public PortKnockRangeAsyncProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
    public class PortKnockListProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public PortKnockListProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
    public class PortKnockListAsyncProgressChangedEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        public string CurrentlyScanning { get; private set; }
        public PortKnockListAsyncProgressChangedEventArgs(int progress, string current = "Unknown")
        {
            Progress = progress;
            CurrentlyScanning = current;
        }
    }
}
