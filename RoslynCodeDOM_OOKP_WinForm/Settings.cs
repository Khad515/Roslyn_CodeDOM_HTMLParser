using System;
using System.Collections.Generic;

namespace RoslynCodeDOM_OOKP_WinForm
{
    [Serializable]
    public class Settings
    {
        public int values;
        public string xpath;
        public List<string> HTML;

        public void SetValues(int _values)
        {
            values = _values;
        }

        public void SetXpath(string _xpath)
        {
            xpath = _xpath;
        }

        public void SetHTML(List<string> _HTML)
        {
            HTML = _HTML;
        }
    }
}
