using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KFP.DATA;
using System.Web;

namespace KFP.DATA
{
    public class Booking
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }
        public string bookingNO { get; set; }
        [ForeignKey("Klass")]
        public int KlassId { get; set; }
        public string ClassName { get; set; }
        public int Size { get; set; }
        [DataType(DataType.Time)]
        public DateTime CreatedTime { get; set; }
        public string Time_in { get; set; }
        [DataType(DataType.Time)]
        public string Time_Out { get; set; }
        public User TrainerName { get; set; }
        [ForeignKey("Client")]

        public string Email { get; set; }
        public virtual Client Client { get; set; }
        public virtual Klass Klass { get; set; }
    }

}
