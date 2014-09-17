
namespace BasicApplication.Northwind
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    [Imported, Serializable, PreserveMemberCase]
    public partial class CategoryRow
    {
        public Int32? CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public byte[] Picture { get; set; }
    }
    
}
