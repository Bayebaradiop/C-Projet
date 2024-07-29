using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    public class Td_Erreur
    {

        [Key]
        public int id { get; set; }
        public Nullable<System.DateTime> DateErreur { get; set; }
        public string DescriptionErreur { get; set; }
        public string TitreErreur { get; set; }
    }
}