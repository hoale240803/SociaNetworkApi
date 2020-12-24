using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class CustomFieldsValues
    {
        public int ValueId { get; set; }
        public string Value { get; set; }
        public int FieldId { get; set; }
        public int NodeId { get; set; }
        public string NodeType { get; set; }
    }
}
