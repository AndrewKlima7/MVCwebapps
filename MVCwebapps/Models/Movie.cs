using System.Runtime.InteropServices;
using System;
// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("b4b5eb5d-c631-4898-9ea5-5935b66df213")]
namespace MVCwebapps.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public string Genre { get; set; }
    }
}