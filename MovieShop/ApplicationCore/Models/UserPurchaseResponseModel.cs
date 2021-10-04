using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class UserPurchaseResponseModel
    {
        public UserPurchaseResponseModel()
        {
            Movies = new List<MovieCardResponseModel>();
        }
        public int UserId { get; set; }
        public Guid PurchaseNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }
        public string MoviePosterUrl { get; set; }

        public List<MovieCardResponseModel> Movies { get; set; }
    }
}
