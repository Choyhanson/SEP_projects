using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
   public class TableViewModel
    {
        public IEnumerable<MovieCardByIdModel> Movies { get; set; }
        public IEnumerable<MovieCardResponseModel> Genres { get; set; }
    }
}
