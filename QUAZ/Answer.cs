using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QUAZ
{
    [Serializable]
    public class Answer
    {
        [XmlAttribute]
        public string IsCorrect { get; set; }
        [XmlAttribute]
        public int id { get; set; }
        [XmlElement]
        public string Text { get; set; }
    }
}
