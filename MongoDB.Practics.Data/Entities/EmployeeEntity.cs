using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("Employee")]
    public  class EmployeeEntity : BaseEntity
    {
        public int EmpNo { get; set; }
        public string Ename { get; set; }
        public string job { get; set; }
        public string Mgr { get; set; }
        public DateTime HireDate { get; set; }
        public int Sal { get; set; }
        public int Comm { get; set; }
        public int DeptNo { get; set; }
    }
}
