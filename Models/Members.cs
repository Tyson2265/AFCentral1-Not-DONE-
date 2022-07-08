namespace AFCentral1.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public string FullName { get; set; }

        public string SAIdentityNo { get; set; }

        public int ParkingSpotNo { get; set; }

        public int DepartmentId { get; set; }

        public int PositionId { get; set; }

        public int CelebratesBirthday { get; set; }

        public DateTime BirthDay { get; set; }

        public DateTime StartDate { get; set; } 
        
        public DateTime EndDate { get; set; }

        public string Pass_Word { get; set; }   


    }
}
