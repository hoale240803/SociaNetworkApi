using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class CustomFields
    {
        public int FieldId { get; set; }
        public string FieldFor { get; set; }
        public string Type { get; set; }
        public string SelectOptions { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public int Length { get; set; }
        public int FieldOrder { get; set; }
        public string Mandatory { get; set; }
        public string InRegistration { get; set; }
        public string InProfile { get; set; }
    }
}
