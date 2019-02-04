using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace QUAZ
{
    [Serializable]
    public class QuestionBlock
    {
        [XmlAttribute]
        public int id { get; set; }
        [XmlElement]
        public string Text { get; set; }
        [XmlArray]
        public List<Answer> Answers { get; set; }
    }
}
