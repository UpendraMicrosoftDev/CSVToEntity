//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSVToEntity
{
    using ExportLibrary;
    using System;
    using System.Collections.Generic;

    public partial class Student
    {
        public int ID { get; set; }
        [CsvField(0)]
        public string Name { get; set; }
        [CsvField(1)]
        public string SchoolName { get; set; }
        [CsvField(2)]
        public string Location { get; set; }
        public int Age { get; set; }
    }
}