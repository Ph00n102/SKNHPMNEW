using System.ComponentModel.DataAnnotations;

namespace SKNHPMNEW.Models
{
    public class JobStatus
    {
        [Key]
        public int JobStatusId { get; set; }
        public string JobStatusName { get; set; }   
    }
}