using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace O.thompsonStore.Models
{
    public class MainPoint
    {
        [Key] 
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int EmployeeId { get; set; }
        public string licencePlate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; } 

        public int PartsId {  get; set; }
        public int ServiceId { get; set; }
        

        [ForeignKey("PartsId")]
        public  virtual Parts? Parts { get; set;}

        [ForeignKey("ServiceId")]
        public virtual Service? Service { get; set; }


    }
}
