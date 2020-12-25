using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class CustomFieldsValue
    {
        public uint ValueId { get; set; }
        public string Value { get; set; }
        public uint FieldId { get; set; }
        public uint NodeId { get; set; }
        public string NodeType { get; set; }
    }
}
