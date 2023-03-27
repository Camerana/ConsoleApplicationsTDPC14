using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Classi
{
    internal class Madre
    {
        public string PublicProperty_Madre { get; set; }
        protected string ProtectedProperty_Madre { get; set; }
        private string PrivateProperty_Madre { get; set; }

        public void PublicMethod_Madre() { }
        protected void ProtectedMethod_Madre() { }
        private void PrivateMethod_Madre() { }
    }
}
