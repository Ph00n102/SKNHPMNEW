
using System.ComponentModel.DataAnnotations;

namespace SKNHPMNEW.Models
{
    public class Urgent
    {
        [Key]
        public int UrgentId { get; set; }
        public string   UrgentType { get; set;}    
    }
}