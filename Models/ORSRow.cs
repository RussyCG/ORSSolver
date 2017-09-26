using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ORSRow
    {
        private List<float> elements;
        private string rowName;

        public ORSRow(string RowNameParam)
        {
            this.rowName = RowNameParam;
            this.Elements = new List<float>();
        }
        
        public int Count
        {
            get { return this.Elements.Count; }
        }

        public string RowName
        {
            get { return rowName; }
        }

        public List<float> Elements
        {
            get { return elements; }
            set { elements = value; }
        }

        // Indexer
        public float this[int index]
        {
            get
            {
                return this.Elements[index];
            }
            set
            {
                this.Elements[index] = value;
            }
        }
        
        public void Add(float value)
        {
            this.Elements.Add(value);
        }

        public void Clear()
        {
            this.Elements.Clear();
        }

        public bool Contains(float value)
        {
            return this.Elements.Contains(value);
        }

        public int IndexOf(float value)
        {
            return this.Elements.IndexOf(value);
        }

        public void Insert(int index, float value)
        {
            this.Elements.Insert(index, value);
        }

        public void RemoveAt(int index)
        {
            this.Elements.RemoveAt(index);
        }

        public override string ToString()
        {
            // 7 character spacing
            int charSpacing = 7;

            string temp = ExtensionMethods.GetCellValue(charSpacing, this.RowName);
            for (int i = 0; i < Elements.Count; i++)
            {
                temp += GetElementString(charSpacing, Elements[i]);
            }

            return temp;
        }

        private string GetElementString(int CharSpacing, float Element)
        {
            return ExtensionMethods.GetCellValue(CharSpacing, Element.ToString());
        }
    }
}
