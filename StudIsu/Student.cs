using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudIsu
{
    class Student
    {
        public int Id;
        public string Name;
        public string FName;
        public string Group;
        public double Mark;
    }
}
